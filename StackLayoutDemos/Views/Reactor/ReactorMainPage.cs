using MauiReactor;
using static Microsoft.Maui.Controls.Shell;
using Component = MauiReactor.Component;

namespace StackLayoutDemos.Views.Reactor;

public class ReactorMainPage : Component
{
    private readonly List<(string Title, string Subtitle, string Route)> pages =
    [
        ("Default StackLayout", "Vertical", "vertical"),
        ("Horizontal StackLayout", "Orientation Property", "horizontal"),
        ("Child Spacing", "Spacing Property", "spacing"),
        ("Combined StackLayouts", "Vertical and Horizontal", "combined"),
        ("Alignment in a vertical StackLayout", "HorizontalOptions property", "alignment")
    ];

    public override VisualNode Render()
        => VStack(
            Label("MauiReactor components")
                .FontSize(12)
                .TextColor(Colors.Gray),
            VStack(
                pages.Select(page
                    => VStack(
                            Label(page.Title)
                                .FontSize(18),
                            Label(page.Subtitle)
                                .FontSize(12)
                                .TextColor(Colors.Gray)
                        ).OnTapped(async () => await Current.GoToAsync(page.Route))
                )
            ).Spacing(10)
        ).Spacing(10);
}