using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Pages;

public partial class MobileAppShell : Shell
{
    public MobileAppShell()
    {
        InitializeComponent();

        BindingContext = DependencyService.Get<ShellViewModel>();
    }
}