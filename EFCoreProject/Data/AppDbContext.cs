using JobPortalApp.Data;
using Microsoft.EntityFrameworkCore;
namespace EFCoreProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<WatchList> WatchList { get; set; }
    }
}
