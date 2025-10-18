using Microsoft.EntityFrameworkCore;
using rest_controllers.Models;

namespace rest_controllers.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Insurance> Insurances => Set<Insurance>();
    }
}
