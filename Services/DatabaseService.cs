using System;
using System.Collections.Generic;
using System.Text;
using WorkoutProgress.Models;

namespace WorkoutProgress.Services
{
    public class DatabaseService
    {
        private List<Measurement> measurements;

        public DatabaseService()
        {
            measurements = new List<Measurement>()
            {
                new Measurement(0,DateOnly.FromDateTime(DateTime.Now), 70, 170, 40, 20, 35,35, 40)
            };
        }

        public Measurement GetLastMeasurement()
        {
            return measurements.MaxBy(x => x.Date)!;
        }

    }
}
