using Microsoft.EntityFrameworkCore;
using MyAppWeb.Models;

namespace MyAppWeb.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
    }
}
