using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class StackLayoutSpacingPage : Component
{
    public override VisualNode Render()
        => ContentPage(
            StackLayout(
                Label("Primary Colors"),
                BoxView().Color(Colors.Red).HeightRequest(40),
                BoxView().Color(Colors.Yellow).HeightRequest(40),
                BoxView().Color(Colors.Blue).HeightRequest(40),
                Label("Secondary Colors"),
                BoxView().Color(Colors.Green).HeightRequest(40),
                BoxView().Color(Colors.Orange).HeightRequest(40),
                BoxView().Color(Colors.Purple).HeightRequest(40)
            )
            .Margin(20)
            .Spacing(6)
        )
        .Title("StackLayout Spacing demo");
}