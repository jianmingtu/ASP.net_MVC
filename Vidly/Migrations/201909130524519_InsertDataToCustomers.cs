namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Customers] ON");
            Sql("INSERT INTO[dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES(1006, N'jimmy tu', 0, 3, N'2000-09-01 00:00:00')");
            Sql("INSERT INTO[dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES(1007, N'Mary William', 0, 2, N'2000-09-01 00:00:00') ");
            Sql("INSERT INTO[dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES(1008, N'Brian Murry', 0, 2, N'2000-09-01 00:00:00')");
            Sql("INSERT INTO[dbo].[Customers] ([Id], [Name], [IsSubscribedToNewsletter], [MembershipTypeId], [Birthdate]) VALUES(1009, N'Dan Stormwich', 0, 2, N'2000-09-01 00:00:00')");
            Sql("SET IDENTITY_INSERT [dbo].[Movies] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
