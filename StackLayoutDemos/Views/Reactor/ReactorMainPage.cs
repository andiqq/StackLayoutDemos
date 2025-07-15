using MauiReactor;

namespace StackLayoutDemos.Views.Reactor;

public class ReactorMainPage : Component
{
    public override VisualNode Render()
        => VStack(
            Label("MauiReactor component"),
            VStack(
                Label("Default StackLayout").FontSize(18),
                Label("Vertical").FontSize(12)
            ).OnTapped(async () => { await Navigation.PushAsync<VerticalStackLayoutPage>(); }),
            VStack(
                Label("Horizontal StackLayout").FontSize(18),
                Label("Orientation Property").FontSize(12)
            ).OnTapped(async () => { await Navigation.PushAsync<HorizontalStackLayoutPage>(); }),
            VStack(
                Label("Child Spacing").FontSize(18),
                Label("Spacing Property").FontSize(12)
            ).OnTapped(async () => { await Navigation.PushAsync<StackLayoutSpacingPage>(); }),
            VStack(
                Label("Combined StackLayouts").FontSize(18),
                Label("Vertical and Horizontal").FontSize(12)
            ).OnTapped(async () => { await Navigation.PushAsync<CombinedStackLayoutPage>(); }),
            VStack(
                Label("Alignment in a vertical StackLayout").FontSize(18),
                Label("HorizontalOptions property").FontSize(12)
            ).OnTapped(async () => { await Navigation.PushAsync<AlignmentPage>(); })
        );
}