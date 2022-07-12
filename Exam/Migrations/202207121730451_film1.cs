namespace Exam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class film1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                        Length = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        film_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.film_Id)
                .Index(t => t.film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "film_Id", "dbo.Films");
            DropIndex("dbo.Sessions", new[] { "film_Id" });
            DropTable("dbo.Sessions");
            DropTable("dbo.Films");
        }
    }
}
