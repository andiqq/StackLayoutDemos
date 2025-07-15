using MauiReactor;
using Border = MauiReactor.Border;

namespace StackLayoutDemos.Views.Reactor;

public class CombinedStackLayoutPage : Component
{
    public override VisualNode Render()
        => ContentPage(
                VStack(
                        Label("Primary colors"),
                        BorderComponent(Colors.Red, "Red"),
                        BorderComponent(Colors.Yellow, "Yellow"),
                        BorderComponent(Colors.Blue, "Blue"),
                        Label("Secondary colors"),
                        BorderComponent(Colors.Green, "Green"),
                        BorderComponent(Colors.Orange, "Orange"),
                        BorderComponent(Colors.Purple, "Purple")
                    )
                    .Margin(20)
            )
            .Title("Combined StackLayouts demo");

    private static Border BorderComponent(Color color, string colorstring)
        => Border(
                HStack(
                    BoxView()
                        .Color(color)
                        .WidthRequest(40),
                    Label(colorstring)
                        .FontSize(20)
                        .VCenter()
                ).Spacing(15)
            )
            .Padding(5)
            .Stroke(Colors.Black);
}