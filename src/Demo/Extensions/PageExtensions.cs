﻿using CloudBandwagonDemo.Pages;

namespace CloudBandwagonDemo.Extensions
{
    public static class PageExtensions
    {
        /// <summary>
        /// Register Pages.
        /// </summary>
        /// <param name="builder">App builder.</param>
        /// <returns>App builder.</returns>
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // Desktop Pages.
            builder.Services.AddSingleton<DesktopAppShell>();

            // Mobile Pages
            builder.Services.AddSingleton<MobileAppShell>();

            // Common Pages.
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<DeviceInfoPage>();
            builder.Services.AddSingleton<MyCharacterPage>();

            return builder;
        }
    }
}