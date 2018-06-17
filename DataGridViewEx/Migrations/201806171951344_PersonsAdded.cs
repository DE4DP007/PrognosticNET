namespace DataGridViewEx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonsAdded : DbMigration
    {
        public override void Up()
        {   
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
