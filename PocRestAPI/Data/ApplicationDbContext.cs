using System.Reflection;
using PocRestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PocRestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        // removed this model but leaving this in for future ref
        // public DbSet<LoggerData> LoggerData { get; set; }
    }
}