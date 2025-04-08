namespace EventEaseDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBookingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        CustomerName = c.String(nullable: false, maxLength: 100),
                        CustomerEmail = c.String(nullable: false, maxLength: 100),
                        EventName = c.String(nullable: false, maxLength: 100),
                        NumberOfGuests = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false, maxLength: 100),
                        VenueID = c.Int(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Venue",
                c => new
                    {
                        VenueID = c.Int(nullable: false, identity: true),
                        VenueName = c.String(nullable: false, maxLength: 100),
                        Location = c.String(nullable: false, maxLength: 200),
                        Capacity = c.Int(nullable: false),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.VenueID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Venue");
            DropTable("dbo.Event");
            DropTable("dbo.Bookings");
        }
    }
}
