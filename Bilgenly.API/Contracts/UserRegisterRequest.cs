using Bilgenly.Domain.Entities;

namespace Bilgenly.API.Contracts;

public record UserRegisterRequest {
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRoleEnum Role { get; set; }
}