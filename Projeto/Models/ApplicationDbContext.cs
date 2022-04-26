using Microsoft.EntityFrameworkCore;

namespace Projeto.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {}
        public DbSet<Colaboradores> Colaboradores { get; set; }

        public DbSet<Setores> Setores { get; set; }
    }
}
