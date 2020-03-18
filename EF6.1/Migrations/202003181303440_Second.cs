namespace EF6._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            // add a non-nullable decimal column
            // this will be automatically be created with a default constraint
            AddColumn("dbo.MyEntities", "MySecondDecimal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyEntities", "MySecondDecimal");
        }
    }
}
