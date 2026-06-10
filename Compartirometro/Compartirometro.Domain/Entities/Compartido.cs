namespace Compartirometro.Domain.Entities;

public class Compartido : AuditableEntity
{
    public required string Titulo { get; set; }

    public string? Descripcion { get; set; }
}
