using System.Windows.Input;
using MauiReactor;
using ContentPage = Microsoft.Maui.Controls.ContentPage;
using Page = Microsoft.Maui.Controls.Page;

namespace StackLayoutDemos.Views.XAML;

public partial class MainPage : ContentPage
{
    public ICommand NavigateCommand { get; private set; }

    public MainPage()
    {
        InitializeComponent();

        NavigateCommand = new Command<Type>(async void (pageType) =>
        {
            if (pageType.IsSubclassOf(typeof(Component)))
            {
                await ((Task)typeof(NavigationExtensions)
                    .GetMethod("PushAsync", [typeof(INavigation)])!
                    .MakeGenericMethod(pageType).Invoke(null, [Navigation]))!;
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
