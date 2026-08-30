using Microsoft.EntityFrameworkCore;
using WebApp6ByJayson.Models;

namespace WebApp6ByJayson.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}