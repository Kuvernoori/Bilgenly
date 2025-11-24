namespace BilgenlyD.Models.DTOs.Enrollment;

public class EntrollmentDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CourseId { get; set; }
    public DateTime EnrolledAt { get; set; }
}