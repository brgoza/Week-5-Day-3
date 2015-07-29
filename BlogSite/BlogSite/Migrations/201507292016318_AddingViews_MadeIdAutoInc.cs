namespace BlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingViews_MadeIdAutoInc : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BlogPosts");
            AlterColumn("dbo.BlogPosts", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BlogPosts", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.BlogPosts");
            AlterColumn("dbo.BlogPosts", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.BlogPosts", "Id");
        }
    }
}
