namespace BilgenlyD.Domain.Entities;

public class Question
{
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public int QuizId { get; set; }
}