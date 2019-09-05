namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c3dc3c1-86bb-44ba-bada-54482970bc16', N'admin@yahoo.com', 0, N'AM0Q9bE6QSKcOmPqZK9I4CavjyNbbG7cDUSRua0q++uFUx6UUwsgbKVnHOKv+akjug==', N'c1aea910-8dd4-4d96-93dd-11d4743aa7ce', NULL, 0, 0, NULL, 1, 0, N'admin@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dceee715-8343-41b0-997a-a46057a91af3', N'tu_jm@yahoo.com', 0, N'ANDKkKHDwj+SYZxjzp9nIn8zhel4v7wYrtaqNl6Ig2BPT5qmEdif8Zz5UqQTy+E15A==', N'60d778d9-a311-4c2c-950b-22f40bbd7e07', NULL, 0, 0, NULL, 1, 0, N'tu_jm@yahoo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9ae8ead-8837-4140-ba4e-682b0978ae81', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c3dc3c1-86bb-44ba-bada-54482970bc16', N'd9ae8ead-8837-4140-ba4e-682b0978ae81')



            ");
        }

    public override void Down()
        {
        }
    }
}
