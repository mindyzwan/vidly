namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (5, 'Thriller')");
            Sql("INSERT INTO Genres (Id, DisplayName) VALUES (6, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
