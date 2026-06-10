using Compartirometro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Compartirometro.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Compartido> Compartidos { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
