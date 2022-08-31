using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = DependencyService.Get<MainPageViewModel>();
    }
}