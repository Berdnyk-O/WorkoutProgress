using WorkoutProgress.ViewModel;

namespace WorkoutProgress.View;

public partial class StatisticsPage : ContentPage
{
	public StatisticsPage(StatisticsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}