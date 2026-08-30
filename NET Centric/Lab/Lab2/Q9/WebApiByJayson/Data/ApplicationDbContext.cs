using Microsoft.EntityFrameworkCore;
using WebApiByJayson.Models;

namespace WebApiByJayson.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}