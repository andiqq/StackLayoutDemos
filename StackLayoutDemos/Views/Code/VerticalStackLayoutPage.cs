namespace StackLayoutDemos.Views.Code
{
    public class VerticalStackLayoutPage : ContentPage
    {
        public VerticalStackLayoutPage()
        {
            Title = "Vertical StackLayout demo";

            Content  = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
                {
                    new Label { Text = "Primary colors" },
                    new BoxView { Color = Colors.Red, HeightRequest = 40 },
                    new BoxView { Color = Colors.Yellow, HeightRequest = 40 },
                    new BoxView { Color = Colors.Blue, HeightRequest = 40 },
                    new Label { Text = "Secondary colors" },
                    new BoxView { Color = Colors.Green, HeightRequest = 40 },
                    new BoxView { Color = Colors.Orange, HeightRequest = 40 },
                    new BoxView { Color = Colors.Purple, HeightRequest = 40 }
                }
            };
        }
    }
}
