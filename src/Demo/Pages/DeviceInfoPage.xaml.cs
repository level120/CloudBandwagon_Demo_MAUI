using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Pages;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();

        BindingContext = DependencyService.Get<DeviceInfoPageViewModel>();
    }
}