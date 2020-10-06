namespace ImageUploadToDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAddedDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblProduct", "AddedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblProduct", "AddedDate", c => c.DateTime(nullable: false));
        }
    }
}
