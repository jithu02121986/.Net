using System.Web.Providers.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountDetailsWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
    
}

