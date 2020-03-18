using System.Data.Entity;
using Ef6._1.Model;

namespace EF6._1.Dal
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
