using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Pages;

public partial class DesktopAppShell : Shell
{
    public DesktopAppShell()
    {
        InitializeComponent();

        BindingContext = new ShellViewModel();
    }
}