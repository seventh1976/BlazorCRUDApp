using Microsoft.EntityFrameworkCore;
using MyFirstBlazorApp.Shared.Models;

namespace MyFirstBlazorApp.Server.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Developer> Developers { get; set; }
    }
}
