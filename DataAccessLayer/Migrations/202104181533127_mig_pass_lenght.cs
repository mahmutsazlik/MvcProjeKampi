namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_pass_lenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
        }
    }
}
