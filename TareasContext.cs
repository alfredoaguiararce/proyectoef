namespace proyectoef;
using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

// Con esta clase entity framework puede leer los modelos como tablas.
public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> Tareas {get;set;}
    public TareasContext(DbContextOptions<TareasContext> options) :base(options) {}

}