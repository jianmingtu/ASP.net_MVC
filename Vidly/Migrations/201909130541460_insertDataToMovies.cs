namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class insertDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Movies] ON");
            Sql("INSERT INTO[dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [stockNumber], [GenreId], [AailableNumber]) VALUES(2, N'Once Upon a Time In Hollywoo', N'2001-10-01 00:00:00', N'2001-12-01 00:00:00', 3, 4, 1)");
            Sql("INSERT INTO[dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [stockNumber], [GenreId], [AailableNumber]) VALUES(3, N'Die Hard1', N'2000-01-01 00:00:00', N'2009-10-02 00:00:00', 4, 2, 4)");
            Sql("INSERT INTO[dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [stockNumber], [GenreId], [AailableNumber]) VALUES(4, N'Handover+', N'2019-07-26 00:00:00', N'2019-09-05 20:32:44', 4, 5, 4)");
            Sql("INSERT INTO[dbo].[Movies] ([Id], [Name], [ReleaseDate], [DateAdded], [stockNumber], [GenreId], [AailableNumber]) VALUES(5, N'Rush Hour', N'1998-01-01 00:00:00', N'2019-09-05 20:36:21', 3, 1, 3)");
            Sql("SET IDENTITY_INSERT [dbo].[Movies] OFF");
        }
        public override void Down()
        {
        }
    }
}
