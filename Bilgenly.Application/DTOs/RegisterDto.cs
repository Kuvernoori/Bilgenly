using Bilgenly.Domain.Entities;

namespace Bilgenly.Application.DTOs;

public class RegisterDto
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public UserRoleEnum Role { get; set; } = UserRoleEnum.Student;
}