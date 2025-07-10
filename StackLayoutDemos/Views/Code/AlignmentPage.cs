namespace StackLayoutDemos.Views.Code
{
    public class AlignmentPage : ContentPage
    {
        public AlignmentPage()
        {
            Title = "Alignment demo";

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Spacing = 6,
                Children =
                {
                    new Label { Text = "Start", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Start },
                    new Label { Text = "Center", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Center },
                    new Label { Text = "End", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.End },
                    new Label { Text = "Fill", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Fill }
                }
            };
        }
    }
}
