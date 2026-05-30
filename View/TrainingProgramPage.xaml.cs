using WorkoutProgress.ViewModel;

namespace WorkoutProgress.View;

public partial class TrainingProgramPage : ContentPage
{
	public TrainingProgramPage(TrainingProgramViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}