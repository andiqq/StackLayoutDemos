using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class HorizontalStackLayoutPage : Component
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
        ).Title("Horizontal StackLayout demo");

    private static MauiReactor.BoxView Box(Color color)
        => new MauiReactor.BoxView()
            .Color(color)
            .WidthRequest(40);
            
}