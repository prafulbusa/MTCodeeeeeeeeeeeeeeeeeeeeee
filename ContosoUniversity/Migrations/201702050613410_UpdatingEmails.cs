namespace ContosoUniversity.Migrations
{ 
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingEmails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Email");
        }
    }
}
