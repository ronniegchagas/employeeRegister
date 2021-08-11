namespace employeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDBCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        BirthDate = c.String(),
                        Salary = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employee");
        }
    }
}
