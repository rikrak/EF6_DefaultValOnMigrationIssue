using System.Data.Entity;
using Ef6._4.Model;

namespace EF6._4.Dal
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DefaultConnection")
        {
            
        }
        public DbSet<MyEntity> MyEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // see namespace: SchemeTrack8.Dal.ModelConfiguration
            modelBuilder.Configurations.AddFromAssembly(typeof(MyContext).Assembly);
        }

    }
}
