using WorkoutProgress.ViewModel;

namespace WorkoutProgress.View;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
}