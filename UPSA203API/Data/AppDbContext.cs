using Microsoft.EntityFrameworkCore;
using UPSA203API.Models;

namespace UPSA203API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Workout> Workouts { get; set; }
    }
}