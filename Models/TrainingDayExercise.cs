namespace WorkoutProgress.Models
{
    public class TrainingDayExercise
    {
        public int Id { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public int SetsCount { get; set; }

        public TrainingDayExercise()
        {
        }

        public TrainingDayExercise(int id, Exercise exercise, int setsCount)
        {
            Id = id;
            Exercise = exercise;
            SetsCount = setsCount;
        }
    }
}
