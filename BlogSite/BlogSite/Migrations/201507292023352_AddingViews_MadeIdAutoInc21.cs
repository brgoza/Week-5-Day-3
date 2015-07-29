namespace BlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingViews_MadeIdAutoInc21 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BlogPosts");
            AddColumn("dbo.BlogPosts", "BlogPostId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BlogPosts", "BlogPostId");
            DropColumn("dbo.BlogPosts", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogPosts", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.BlogPosts");
            DropColumn("dbo.BlogPosts", "BlogPostId");
            AddPrimaryKey("dbo.BlogPosts", "Id");
        }
    }
}
