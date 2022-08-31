using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Pages;

public partial class MyCharacterPage : ContentPage
{
    public MyCharacterPage()
    {
        InitializeComponent();

        BindingContext = DependencyService.Get<MyCharacterPageViewModel>();
    }
}