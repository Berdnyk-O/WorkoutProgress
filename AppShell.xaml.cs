using WorkoutProgress.View;

namespace WorkoutProgress
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TrainingProgramPage), typeof(TrainingProgramPage));
        }
    }
}
