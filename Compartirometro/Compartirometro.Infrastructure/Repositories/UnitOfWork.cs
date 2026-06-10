using Compartirometro.Application.Common.Interfaces;

namespace Compartirometro.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IApplicationDbContext _context;

    public UnitOfWork(IApplicationDbContext context)
    {
        _context = context;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}
