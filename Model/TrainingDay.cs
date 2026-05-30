namespace WorkoutProgress.Models
{
    public class TrainingDay
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<TrainingDayExercise> Exercises { get; set; } = null!;

        public TrainingDay()
        {
        }

        public TrainingDay(int id, string name, List<TrainingDayExercise> exercises)
        {
            Id  = id;
            Name = name;
            Exercises = exercises;
        }
    }
}
