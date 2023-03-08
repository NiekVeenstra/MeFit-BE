namespace MeFitAPI.Models.Domain
{
    public class GoalWorkout
    {
        public int Id { get; set; }
        public DateOnly EndDate { get; set; }
        public int WorkoutId { get; set; }
        public int GoalId { get; set; }
    }
}
