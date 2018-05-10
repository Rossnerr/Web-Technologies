namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Picture, Price, BrandId)" +
                "VALUES ('evoPower 1.3', '~/Content/Images/evoPower1.3.jpg', '15', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
