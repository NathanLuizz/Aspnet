using Microsoft.EntityFrameworkCore;

namespace Aspnet.Models
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
