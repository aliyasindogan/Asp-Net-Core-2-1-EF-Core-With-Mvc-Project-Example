using AspDotNetCoreMvcProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCoreMvcProject.DataAccess
{
    public class AspDotNetCoreMvcProjectDBContext : DbContext
    {
        public AspDotNetCoreMvcProjectDBContext(DbContextOptions<AspDotNetCoreMvcProjectDBContext> options):base(options)
        {

        }
        protected AspDotNetCoreMvcProjectDBContext()
        {

        }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
