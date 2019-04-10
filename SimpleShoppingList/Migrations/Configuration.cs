namespace SimpleShoppingList.Migrations
{
    using SimpleShoppingList.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleShoppingList.Models.SimpleShoppingListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleShoppingList.Models.SimpleShoppingListContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.ShoppingLists.AddOrUpdate(
                new ShoppingList
                {
                    Name = "Groceries",
                    Items = {
                    new Item { Id = 0, Name = "Milk", ShoppingListId = 0 },
                    new Item { Id = 1, Name = "Bred", ShoppingListId = 0 },
                    new Item { Id = 2, Name = "Butter", ShoppingListId = 0 }
                    }
                },
                new ShoppingList()
                {
                    Name = "Hardware",
                    Items = {
                        new Item { Id = 0, Name = "Hammer", ShoppingListId = 1},
                        new Item { Id = 1, Name = "Screwdriver", ShoppingListId = 1},
                        new Item { Id = 2, Name = "Forcaps", ShoppingListId = 1}
                    }
                },
                new ShoppingList()
                {
                    Name = "Clothes",
                    Items = {
                        new Item { Id = 0, Name = "Shirt", ShoppingListId = 2},
                        new Item { Id = 1, Name = "Pants", ShoppingListId = 2},
                        new Item { Id = 2, Name = "Jacket", ShoppingListId = 2}
                    }
                }
            );
        }
    }
}
