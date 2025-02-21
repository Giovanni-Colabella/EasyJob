using Microsoft.EntityFrameworkCore;
using MyCourse_Custom.Models.Entities;

namespace MyCourse_Custom.Models.Services.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobDetail> JobDetails {get; set;} 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}