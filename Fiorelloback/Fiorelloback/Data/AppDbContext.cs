using Fiorelloback.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorelloback.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) 
        {
        
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Expert> Experts { get; set; }

    }
} 
