namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        PackageID = c.String(nullable: false, maxLength: 128),
                        Location = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        GroupSize = c.Int(nullable: false),
                        Inclusion_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PackageID)
                .ForeignKey("dbo.Package_Inclusion", t => t.Inclusion_Id)
                .Index(t => t.Inclusion_Id);
            
            CreateTable(
                "dbo.Package_Inclusion",
                c => new
                    {
                        Inclusion_Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Inclusion_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        PaymentMethod = c.String(nullable: false),
                        PaymentAmount = c.String(nullable: false),
                        TId = c.String(maxLength: 128),
                        Inclusion_Id = c.String(maxLength: 128),
                        ReservationID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Package_Inclusion", t => t.Inclusion_Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationID)
                .ForeignKey("dbo.Travellers", t => t.TId)
                .Index(t => t.TId)
                .Index(t => t.Inclusion_Id)
                .Index(t => t.ReservationID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.String(nullable: false, maxLength: 128),
                        CheckInDateTime = c.String(nullable: false, maxLength: 100),
                        CheckOutDateTime = c.String(nullable: false, maxLength: 100),
                        TId = c.String(maxLength: 128),
                        PackageID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Packages", t => t.PackageID)
                .ForeignKey("dbo.Travellers", t => t.TId)
                .Index(t => t.TId)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.Travellers",
                c => new
                    {
                        TId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.String(nullable: false, maxLength: 128),
                        Rating = c.String(nullable: false),
                        Comment = c.String(nullable: false),
                        TId = c.String(maxLength: 128),
                        Inclusion_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Package_Inclusion", t => t.Inclusion_Id)
                .ForeignKey("dbo.Travellers", t => t.TId)
                .Index(t => t.TId)
                .Index(t => t.Inclusion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Packages", "Inclusion_Id", "dbo.Package_Inclusion");
            DropForeignKey("dbo.Payments", "TId", "dbo.Travellers");
            DropForeignKey("dbo.Payments", "ReservationID", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "TId", "dbo.Travellers");
            DropForeignKey("dbo.Reviews", "TId", "dbo.Travellers");
            DropForeignKey("dbo.Reviews", "Inclusion_Id", "dbo.Package_Inclusion");
            DropForeignKey("dbo.Reservations", "PackageID", "dbo.Packages");
            DropForeignKey("dbo.Payments", "Inclusion_Id", "dbo.Package_Inclusion");
            DropIndex("dbo.Reviews", new[] { "Inclusion_Id" });
            DropIndex("dbo.Reviews", new[] { "TId" });
            DropIndex("dbo.Reservations", new[] { "PackageID" });
            DropIndex("dbo.Reservations", new[] { "TId" });
            DropIndex("dbo.Payments", new[] { "ReservationID" });
            DropIndex("dbo.Payments", new[] { "Inclusion_Id" });
            DropIndex("dbo.Payments", new[] { "TId" });
            DropIndex("dbo.Packages", new[] { "Inclusion_Id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Travellers");
            DropTable("dbo.Reservations");
            DropTable("dbo.Payments");
            DropTable("dbo.Package_Inclusion");
            DropTable("dbo.Packages");
            DropTable("dbo.Admins");
        }
    }
}
