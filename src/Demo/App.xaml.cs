using CloudBandwagonDemo.Pages;

namespace CloudBandwagonDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = IsDesktopMode()
            ? new DesktopAppShell()
            : new MobileAppShell();
    }

    private static bool IsDesktopMode()
    {
#if WINDOWS || MACCATALYST
            return true;
#else
        return false;
#endif
    }
}