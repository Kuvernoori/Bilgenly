using Bilgenly.Domain.Entities;
namespace Bilgenly.Application.Interfaces;

public interface IAttemptRepository
{
    Task<Attempt?> GetByIdAsync(Guid id);
    Task<IEnumerable<Attempt>> GetByUserIdAsync(Guid userId);
    Task AddAsync(Attempt attempt);
    Task SaveChangesAsync();
}