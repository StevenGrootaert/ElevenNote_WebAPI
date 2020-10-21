namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Content");
        }
    }
}
