using Microsoft.EntityFrameworkCore;
using ServidorAPI.Models;

namespace ServidorAPI.Contenido
{
    public class AppDbContext : DbContext
    {
        public DbSet<Plato> Platos => Set<Plato>();//sera nombre de la tabla
        public AppDbContext(DbContextOptions<AppDbContext> opciones) : base(opciones)
        {
            
        }
    }
}
