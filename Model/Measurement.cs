namespace WorkoutProgress.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Bust { get; set; }
        public float Waist { get; set; }
        public float BicepsLeft { get; set; }
        public float BicepsRight { get; set; }
        public float Thighs { get; set; }

        public Measurement()
        {
        }

        public Measurement(
            int id,
            DateOnly date,
            float weight,
            float height,
            float bust,
            float waist,
            float bicepsLeft,
            float bicepsRight,
            float thighs)
        {
            Id = id;
            Date = date;
            Weight = weight;
            Height = height;
            Bust = bust; 
            Waist = waist;
            BicepsLeft = bicepsLeft;
            BicepsRight = bicepsRight;
            Thighs = thighs;
        }
    }
}
