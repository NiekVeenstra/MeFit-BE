namespace MeFitAPI.Models.Domain
{
    public class Goal
    {
        public int Id { get; set; }
        public DateOnly EndDate { get; set; }
        public bool IsAchieved { get; set; }
        public int ProgramId { get; set; }

    }
}
