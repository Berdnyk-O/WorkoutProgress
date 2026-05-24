namespace WorkoutProgress.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool OneArm { get; set; }

        public Exercise()
        {
        }

        public Exercise(int id, string name, bool oneArm)
        {
            Id = id;
            Name = name;
            OneArm = oneArm;
        }
    }
}
