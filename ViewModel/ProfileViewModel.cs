using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WorkoutProgress.ViewModel
{
    public partial class ProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial float Weight { get; set; }

        [RelayCommand]
        private void Increase()
        {
            Weight = 100;
        }

    }
}
