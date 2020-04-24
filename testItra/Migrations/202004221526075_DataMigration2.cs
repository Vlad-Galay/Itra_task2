namespace testItra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsMarked", c => c.Boolean(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "IsMarked");
        }
    }
}
