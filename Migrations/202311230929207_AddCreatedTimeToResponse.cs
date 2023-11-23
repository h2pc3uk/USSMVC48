namespace USSMVC48.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedTimeToResponse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Responses", "CreatedTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Responses", "CreatedTime");
        }
    }
}
