using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class HorizontalStackLayoutPage : Component
{
    public override VisualNode Render()
        => ContentPage(
                HStack(
                        BoxView().Color(Colors.Red).WidthRequest(40),
                        BoxView().Color(Colors.Yellow).WidthRequest(40),
                        BoxView().Color(Colors.Blue).WidthRequest(40),
                        BoxView().Color(Colors.Green).WidthRequest(40),
                        BoxView().Color(Colors.Orange).WidthRequest(40),
                        BoxView().Color(Colors.Purple).WidthRequest(40)
                    )
                    .Margin(20)
                    .HCenter()
            )
            .Title("Horizontal StackLayout demo");
}