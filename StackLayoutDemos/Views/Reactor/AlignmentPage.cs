using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class AlignmentPage : Component
{
    public override VisualNode Render()
        => ContentPage(
            VStack(
                Label("Start")
                    .BackgroundColor(Colors.Gray)
                    .HorizontalOptions(LayoutOptions.Start),
                Label("Center")
                    .BackgroundColor(Colors.Gray)
                    .HorizontalOptions(LayoutOptions.Center),
                Label("End")
                    .BackgroundColor(Colors.Gray)
                    .HorizontalOptions(LayoutOptions.End),
                Label("Fill")
                    .BackgroundColor(Colors.Gray)
                    .HorizontalOptions(LayoutOptions.Fill)
            )
            .Margin(20)
            .Spacing(6)
        );
}