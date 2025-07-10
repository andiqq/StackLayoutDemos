using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class CombinedStackLayoutPage : Component
{
    public override VisualNode Render()
        => ContentPage(
            VStack(
                    Label("Primary colors"),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Red)
                                        .WidthRequest(40),
                                    Label("Red")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Yellow)
                                        .WidthRequest(40),
                                    Label("Yellow")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Blue)
                                        .WidthRequest(40),
                                    Label("Blue")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5),
                    Label("Secondary colors"),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Green)
                                        .WidthRequest(40),
                                    Label("Green")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Orange)
                                        .WidthRequest(40),
                                    Label("Orange")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5),
                    Border(
                            HStack(
                                    BoxView()
                                        .Color(Colors.Purple)
                                        .WidthRequest(40),
                                    Label("Purple")
                                        .FontSize(20)
                                        .VCenter()
                                )
                                .Spacing(15)
                        )
                        .Stroke(Colors.Black)
                        .Padding(5)
                )
                .Margin(20)
        )
        .Title("Combined StackLayouts demo");
}