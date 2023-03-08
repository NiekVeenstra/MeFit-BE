namespace MeFitAPI.Models.Domain
{
    public class Profile
    {
        public int Id { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string MedicalConditions { get; set; }
        public string Disabilities { get; set; }
        public int UserId { get; set; }
        public int GoalId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; } // Navigation property
        public int ProgramId { get; set; }
        public int WorkoutId { get; set; }
    }
}
