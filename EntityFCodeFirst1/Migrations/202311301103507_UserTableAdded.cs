namespace EntityFCodeFirst1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Products", "Quantity", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
    }
}
