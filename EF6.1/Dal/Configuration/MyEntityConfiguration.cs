using System.Data.Entity.ModelConfiguration;
using Ef6._1.Model;

namespace EF6._1.Dal.Configuration
{
    public class MyEntityConfiguration:EntityTypeConfiguration<MyEntity>
    {
        public MyEntityConfiguration()
        {
            this.HasKey(e => e.Id);

            // this was added after the second migration
            this.Property(e => e.MySecondDecimal).HasPrecision(18, 5);
        }
    }
}
