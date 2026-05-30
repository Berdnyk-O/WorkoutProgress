using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkoutProgress.Models
{
    public class Training
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public List<ExerciseTraining> Exercises { get; set; } = null!;

        public Training()
        {
        }

        public Training(int id , DateOnly date, List<ExerciseTraining> exercises)
        {
            Id = id;
            Date = date;
            Exercises = exercises;
        }
    }
}
