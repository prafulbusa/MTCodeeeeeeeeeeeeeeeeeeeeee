namespace ContosoUniversity.Migrations 
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "CreditsEarned", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "CreditsEarned");
        }
    }
}
