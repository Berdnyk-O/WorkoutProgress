using WorkoutProgress.ViewModels;

namespace WorkoutProgress.Views;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
		BindingContext = new ProfileViewModel();
	}
}