namespace MeFitAPI.Models.Domain
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Complete { get; set; }
        public int SetId { get; set; }

    }
}
