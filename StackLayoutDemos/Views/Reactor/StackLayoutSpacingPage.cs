using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class StackLayoutSpacingPage : Component
{
    public override VisualNode Render()
        => ContentPage(
            StackLayout(
                Label("Primary Colors"),
                Box(Colors.Red),
                Box(Colors.Yellow),
                Box(Colors.Blue),
                Label("Secondary Colors"),
                Box(Colors.Green),
                Box(Colors.Orange),
                Box(Colors.Purple)
                )
            .Margin(20)
            .Spacing(6)
        )
        .Title("StackLayout Spacing demo");
    
    private static MauiReactor.BoxView Box(Color color)
        => new MauiReactor.BoxView()
            .Color(color)
            .HeightRequest(40);
}