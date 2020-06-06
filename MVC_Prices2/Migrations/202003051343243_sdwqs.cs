namespace MVC_Prices2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdwqs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ledges", "PicValue", c => c.String());
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ledges", "Value", c => c.Int(nullable: false));
           
        }
    }
}
