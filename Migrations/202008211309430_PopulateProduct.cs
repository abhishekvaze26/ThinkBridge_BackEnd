namespace ProductsApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProduct : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Products(ProductName,ProductPrice,ProductDescription) values ('Poco F1',20000,'MI Phone')");
            Sql("insert into Products(ProductName,ProductPrice,ProductDescription) values ('Epiphone AJ210',25000,'Accoustic Guitar')");
            Sql("insert into Products(ProductName,ProductPrice,ProductDescription) values ('Samsung M21',16000,'Samsung Phone')");

        }

        public override void Down()
        {
        }
    }
}
