namespace BilgenlyD.Models.DTOs.Lesson;

public class CreateLessonDto
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int CourseId { get; set; }
}