using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConnectedDropDowns_MVC5.Models
{
    public class DropDownDbContext : DbContext
    {
        public DropDownDbContext() : base("DropDownConnection")
        {
        }
        public static DropDownDbContext Create()
        {
            return new DropDownDbContext();
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}