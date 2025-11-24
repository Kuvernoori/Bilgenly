namespace BilgenlyD.Application.DTOs.Answer;

public class CreateAnswerDto
{
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
}