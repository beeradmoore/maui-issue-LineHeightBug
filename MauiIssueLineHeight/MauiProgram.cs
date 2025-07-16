﻿using Microsoft.Extensions.Logging;

namespace MauiIssueLineHeight;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if ANDROID
        /*
        Microsoft.Maui.Handlers.LabelHandler.Mapper.AppendToMapping("AndroidRemoveFontPadding", (handler, view) =>
        {
            handler.PlatformView.SetIncludeFontPadding(false);
        });
        */
#endif

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}