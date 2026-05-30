using Microsoft.Extensions.Logging;
using WorkoutProgress.View;
using WorkoutProgress.ViewModel;

namespace WorkoutProgress
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

            builder.Services.AddSingleton<ProfilePage>();
            builder.Services.AddSingleton<ProfileViewModel>();

            builder.Services.AddSingleton<TrainingProgramPage>();
            builder.Services.AddSingleton<TrainingProgramViewModel>();

            builder.Services.AddSingleton<AddEntryPage>();
            builder.Services.AddSingleton<AddEntryViewModel>();

            builder.Services.AddSingleton<HistoryPage>();
            builder.Services.AddSingleton<HistoryViewModel>();

            builder.Services.AddSingleton<StatisticsPage>();
            builder.Services.AddSingleton<StatisticsViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
