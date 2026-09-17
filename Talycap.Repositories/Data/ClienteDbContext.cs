using Microsoft.EntityFrameworkCore;
using Talycap.Repositories.Entities;

namespace Talycap.Repositories.Data
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(
            DbContextOptions<ClienteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}