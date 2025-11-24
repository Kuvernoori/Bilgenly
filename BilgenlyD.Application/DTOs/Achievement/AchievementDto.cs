namespace BilgenlyD.Application.DTOs.Achievement;

public class AchievementDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public DateTime AchievedAt { get; set; }
}