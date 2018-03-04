namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "GPA", c => c.Double(nullable: false));
            AlterColumn("dbo.Person", "Credit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "Credit", c => c.String(maxLength: 100));
            DropColumn("dbo.Person", "GPA");
        }
    }
}
