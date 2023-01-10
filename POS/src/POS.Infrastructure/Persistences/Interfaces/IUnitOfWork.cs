namespace POS.Infrastructure.Persistences.Interfaces;

// Patron de diseño Unit of Work
// Majera transaction durante la manipulación de datos
public interface IUnitOfWork : IDisposable // Mecanismo para liberar objectos en memoria
{
    // Declaracion o matricula de  nuestra interfaces a ninvel de repositorio

    // Las interfaces tiene que declararse en el UnitOfWork ↓
    ICategoryRepository Category { get; }
    void SaveChanges();
    Task SaveChangesAsync();
}
