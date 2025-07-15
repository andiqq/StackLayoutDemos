using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;
public class VerticalStackLayoutPage : Component
{
    public override VisualNode Render()
        => ContentPage(
            VStack(
                Label("Primary Colors"),
                Box(Colors.Red),
                Box(Colors.Yellow),
                Box(Colors.Blue),
                Label("Secondary Colors"),
                Box(Colors.Green),
                Box(Colors.Orange),
                Box(Colors.Purple)
                ).Margin(20)
        ).Title("Vertical StackLayout demo");

    private static MauiReactor.BoxView Box(Color color)
        => new MauiReactor.BoxView()
            .Color(color)
            .HeightRequest(40);
}