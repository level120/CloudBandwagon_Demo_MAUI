using CloudBandwagonDemo.ViewModels;

namespace CloudBandwagonDemo.Extensions;

public static class ViewModelExtensions
{
    /// <summary>
    /// Register ViewModels.
    /// </summary>
    /// <param name="builder">App builder.</param>
    /// <returns>App builder.</returns>
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<ShellViewModel>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<DeviceInfoPageViewModel>();
        builder.Services.AddSingleton<MyCharacterPageViewModel>();

        return builder;
    }
}