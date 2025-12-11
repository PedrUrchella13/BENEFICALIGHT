using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BENEFICALIGHT.Models;

namespace BENEFICALIGHT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BENEFICALIGHT.Models.Especializacao> Especializacao { get; set; } = default!;
        public DbSet<BENEFICALIGHT.Models.Medico> Medico { get; set; } = default!;
        public DbSet<BENEFICALIGHT.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<BENEFICALIGHT.Models.Tratamento> Tratamento { get; set; } = default!;
    }
}
