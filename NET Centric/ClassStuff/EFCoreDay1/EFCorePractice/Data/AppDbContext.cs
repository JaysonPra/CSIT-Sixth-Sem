using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; }
}