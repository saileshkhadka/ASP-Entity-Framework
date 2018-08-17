namespace StudentInformation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "ContactNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "ContactNumber", c => c.Int(nullable: false));
        }
    }
}
