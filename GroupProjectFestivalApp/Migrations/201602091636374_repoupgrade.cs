namespace GroupProjectFestivalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repoupgrade : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AttractionTags", newName: "TagAttractions");
            DropPrimaryKey("dbo.TagAttractions");
            CreateTable(
                "dbo.AttractionEvents",
                c => new
                    {
                        Attraction_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Attraction_Id, t.Event_Id })
                .ForeignKey("dbo.Attractions", t => t.Attraction_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Attraction_Id)
                .Index(t => t.Event_Id);
            
            AddColumn("dbo.Pushpins", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tags", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Hosts", "Active", c => c.Boolean(nullable: false));
            AddPrimaryKey("dbo.TagAttractions", new[] { "Tag_Id", "Attraction_Id" });
            DropColumn("dbo.Events", "Attraction");
            DropColumn("dbo.Attractions", "Event");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attractions", "Event", c => c.String());
            AddColumn("dbo.Events", "Attraction", c => c.String());
            DropForeignKey("dbo.AttractionEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.AttractionEvents", "Attraction_Id", "dbo.Attractions");
            DropIndex("dbo.AttractionEvents", new[] { "Event_Id" });
            DropIndex("dbo.AttractionEvents", new[] { "Attraction_Id" });
            DropPrimaryKey("dbo.TagAttractions");
            DropColumn("dbo.Hosts", "Active");
            DropColumn("dbo.Tags", "Active");
            DropColumn("dbo.Pushpins", "Active");
            DropTable("dbo.AttractionEvents");
            AddPrimaryKey("dbo.TagAttractions", new[] { "Attraction_Id", "Tag_Id" });
            RenameTable(name: "dbo.TagAttractions", newName: "AttractionTags");
        }
    }
}
