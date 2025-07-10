using System.Windows.Input;
using StackLayoutDemos.Views.Reactor;
using MauiReactor;
using ContentPage = Microsoft.Maui.Controls.ContentPage;
using Page = Microsoft.Maui.Controls.Page;

namespace StackLayoutDemos
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public ICommand NavigateReactorCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async void (pageType) =>
            {
                if (pageType.IsSubclassOf(typeof(Component)))
                {
                    var pushAsync = typeof(NavigationExtensions)
                        .GetMethod("PushAsync", [typeof(INavigation)])!
                        .MakeGenericMethod(pageType);

                    await ((Task)pushAsync.Invoke(null, [Navigation]))!;
                }
                else
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                }
            });

            BindingContext = this;
        }
    }
}