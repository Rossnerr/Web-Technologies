namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduct1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Picture, Price, BrandId)" +
                "VALUES ('Brazuca', '~/Content/Images/brazuca.jpg', '20', 1)");

            Sql("INSERT INTO Products (Name, Picture, Price, BrandId)" +
                "VALUES ('Jabulani', '~/Content/Images/jabulani.jpg', '10', 1)");

        }

        public override void Down()
        {
        }
    }
}
