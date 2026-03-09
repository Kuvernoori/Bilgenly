using Bilgenly.Application.Interfaces;
using Bilgenly.Domain.Entities;
using Bilgenly.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bilgenly.Infrastructure.Repositories;

public class AttemptRepository : IAttemptRepository
{
    private readonly AppDbContext _context;

    public AttemptRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Attempt?> GetByIdAsync(Guid id)
        => await _context.Attempts
            .Include(a => a.Quiz)
            .ThenInclude(q => q.Questions)
            .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(a => a.Id == id);

    public async Task<IEnumerable<Attempt>> GetByUserIdAsync(Guid userId)
        => await _context.Attempts
            .Where(a => a.UserId == userId)
            .Include(a => a.Quiz)
            .ToListAsync();

    public async Task AddAsync(Attempt attempt)
        => await _context.Attempts.AddAsync(attempt);

    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}