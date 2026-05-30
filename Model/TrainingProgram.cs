namespace WorkoutProgress.Models
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<TrainingDay> Days { get; set; } = null!;

        public TrainingProgram()
        {
        }

        public TrainingProgram(int id, string name, List<TrainingDay> days)
        {
            Id = id;
            Name = name;
            Days = days;
        }
    }
}
