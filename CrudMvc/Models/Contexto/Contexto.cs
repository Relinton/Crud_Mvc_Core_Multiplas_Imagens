using CrudMvc.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CrudMvc.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Foto> Foto { get; set; }
    }
}
