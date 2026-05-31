using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WorkoutProgress.Models;
using WorkoutProgress.Services;

namespace WorkoutProgress.ViewModel
{
    public partial class ProfileViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial Measurement Measurement { get; set; }

        private readonly DatabaseService _databaseService;

        public ProfileViewModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
            Measurement = _databaseService.GetLastMeasurement();
        }


        [RelayCommand]
        private void Increase()
        {
            
        }

    }
}
