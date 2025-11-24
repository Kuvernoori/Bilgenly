using BilgenlyD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilgenlyD.Infrastructure.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }   
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<QuizCategory> QuizCategories { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Achievement> Achievements { get; set; }
    
}