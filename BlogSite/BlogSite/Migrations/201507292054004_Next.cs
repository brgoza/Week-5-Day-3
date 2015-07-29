namespace BlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Next : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.BlogPosts", "Body", c => c.String(nullable: false, maxLength: 1028));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Body", c => c.String(maxLength: 1028));
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(maxLength: 255));
            DropColumn("dbo.BlogPosts", "DateCreated");
        }
    }
}
