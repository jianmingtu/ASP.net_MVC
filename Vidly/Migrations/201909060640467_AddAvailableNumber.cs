namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddAvailableNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AailableNumber", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET AailableNumber = StockNumber");
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "AailableNumber");
        }
    }
}
