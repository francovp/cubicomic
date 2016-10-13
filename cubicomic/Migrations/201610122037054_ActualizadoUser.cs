namespace cubicomic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ActualizadoUser : DbMigration
    {

        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }
    }
}
