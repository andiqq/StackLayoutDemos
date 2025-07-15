using MauiReactor;
using StackLayoutDemos.Views.Reactor;
using Routing = MauiReactor.Routing;

namespace StackLayoutDemos;

public partial class AppShell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute<VerticalStackLayoutPage>("vertical");
		Routing.RegisterRoute<HorizontalStackLayoutPage>("horizontal");
		Routing.RegisterRoute<StackLayoutSpacingPage>("spacing");
		Routing.RegisterRoute<CombinedStackLayoutPage>("combined");
		Routing.RegisterRoute<AlignmentPage>("alignment");
		
	}
}
