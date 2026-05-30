using WorkoutProgress.ViewModel;

namespace WorkoutProgress.View;

public partial class AddEntryPage : ContentPage
{
	public AddEntryPage(AddEntryViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}