namespace eUseControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBrand1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Brands (Name, Year)" +
               "VALUES ('Adidas', 1924)");

            Sql("INSERT INTO Brands (Name, Year)" +
               "VALUES ('Nike', 1964)");

            Sql("INSERT INTO Brands (Name, Year)" +
               "VALUES ('Puma', 1948)");

            Sql("INSERT INTO Brands (Name, Year)" +
               "VALUES ('Under Armour', 1996)");

            Sql("INSERT INTO Brands (Name, Year)" +
               "VALUES ('Jako', 1989)");

        }

        public override void Down()
        {
        }
    }
}
