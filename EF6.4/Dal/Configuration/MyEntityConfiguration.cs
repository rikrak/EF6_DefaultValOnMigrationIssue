using System.Data.Entity.ModelConfiguration;
using Ef6._4.Model;

namespace EF6._4.Dal.Configuration
{
    public class MyEntityConfiguration:EntityTypeConfiguration<MyEntity>
    {
        public MyEntityConfiguration()
        {
            this.HasKey(e => e.Id);

            // added after the second migration
            this.Property(e => e.MySecondDecimal).HasPrecision(18, 5);
        }
    }
}
