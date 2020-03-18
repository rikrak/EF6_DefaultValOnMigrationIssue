namespace EF6._4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MyEntities", "MySecondDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyEntities", "MySecondDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
