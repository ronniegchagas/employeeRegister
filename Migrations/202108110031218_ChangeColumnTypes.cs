namespace employeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.employee", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.employee", "Salary", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.employee", "Salary", c => c.String());
            AlterColumn("dbo.employee", "BirthDate", c => c.String());
        }
    }
}
