namespace GroupProjectFestivalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hosts", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hosts", "Name");
        }
    }
}
