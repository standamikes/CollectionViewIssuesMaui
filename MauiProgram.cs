﻿using Microsoft.Extensions.Logging;

namespace CollectionViewIssues
{
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

#if DEBUG
      builder.Logging.AddDebug();
#endif

      builder.Services.AddSingleton<MainViewModel>();

      Routing.RegisterRoute("DetailPage", typeof(DetailPage));

      return builder.Build();
    }
  }
}
