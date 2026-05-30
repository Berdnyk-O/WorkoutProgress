namespace WorkoutProgress.Models
{
    public class ExerciseSet
    {
        public int Id { get; set; }
        public float WeightKilograms { get; set; }
        public int RepetitionsRight { get; set; }
        public int RepetitionsLeft { get; set; }
        public bool MuscleFailure { get; set; }
        public string? Comment { get; set; }

        public ExerciseSet()
        {
        }

        public ExerciseSet(int id, float weightKilograms, int repetitionsRight, int repetitionsLeft, bool muscleFailure, string comment)
        {
            Id = id;
            WeightKilograms = weightKilograms;
            RepetitionsRight = repetitionsRight;
            RepetitionsLeft = repetitionsLeft;
            MuscleFailure = muscleFailure;
            Comment = comment;
        }
    }
}
