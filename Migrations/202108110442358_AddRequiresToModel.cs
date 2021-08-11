namespace employeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiresToModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employee", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.employee", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.employee", "Address", c => c.String());
            AlterColumn("dbo.employee", "Name", c => c.String());
        }
    }
}
