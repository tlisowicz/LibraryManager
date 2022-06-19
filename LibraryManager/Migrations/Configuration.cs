namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Database;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryManager.Database.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryManager.Database.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Category category1 = new Category() { CategoryID = 1, Name = "History" };
            Category category2 = new Category() { CategoryID = 2, Name = "Novel" };
            context.Categories.AddOrUpdate(category1);
            context.Categories.AddOrUpdate(category2);
            context.Books.AddOrUpdate(new Book { BookID = 1, Pages = 350, Title = "Encounters at the Heart of the World: A History of the Mandan People", CategoryID = category1.CategoryID, Author = "Someone", Price = 14.50, Currency = "PLN" });
            context.Books.AddOrUpdate(new Book { BookID = 2, Pages = 350, Title = "To Kill a Mockingbird", CategoryID = category2.CategoryID, Author = "Someone1", Price = 8.00, Currency = "USD" });
            context.Users.AddOrUpdate(new User { UserID = 1, role = User.Role.ADMIN, Name = "admin", Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" });
        }
    }
}
