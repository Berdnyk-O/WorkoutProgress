namespace WorkoutProgress.Models
{
    public class ExerciseTraining
    {
        public int Id { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public List<ExerciseSet> Sets { get; set; } = null!;

        public ExerciseTraining()
        {
        }

        public ExerciseTraining(int id, Exercise exercise, List<ExerciseSet> sets)
        {
            Id = id;
            Exercise = exercise;
            Sets = sets;
        }
    }
}
