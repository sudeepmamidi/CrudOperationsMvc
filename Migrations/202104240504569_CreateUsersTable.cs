namespace CrudOperationsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        first_name = c.String(nullable: false),
                        last_name = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        gender = c.String(nullable: false),
                        mobile = c.Int(nullable: false),
                        email = c.String(nullable: false),
                        pswd = c.String(nullable: false),
                        category = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
