using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostContext _context;
    public ICategoryRepository Category { get; private set; }

    // Inyección de dependencias
    public UnitOfWork(PostContext context)
    {
        _context = context;
        Category = new CategoryRepository(_context); // Implementado la unit of work
    }

    // Liberar memoria
    public void Dispose()
    {
        _context.Dispose();
    }

    // Guardar cambios
    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    // Guardar cambios de forma asincrona
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}

// imcorporando tanto de patron de repositorio generico