using System.Data.Entity;
using Webappcf.Entities;

namespace Webappcf.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
    }
}
