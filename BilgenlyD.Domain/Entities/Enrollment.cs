namespace BilgenlyD.Domain.Entities;
public class Enrollment
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int UserId { get; set; }
    public DateTime EnrolledAt { get; set; }
}