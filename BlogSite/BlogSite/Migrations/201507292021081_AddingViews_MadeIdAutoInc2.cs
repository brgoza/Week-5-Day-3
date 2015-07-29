namespace BlogSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingViews_MadeIdAutoInc2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(maxLength: 255));
            AlterColumn("dbo.BlogPosts", "Body", c => c.String(maxLength: 1028));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Body", c => c.String(maxLength: 1028, fixedLength: true));
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(maxLength: 255, fixedLength: true));
        }
    }
}
