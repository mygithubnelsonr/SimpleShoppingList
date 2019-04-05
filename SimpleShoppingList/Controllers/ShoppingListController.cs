using SimpleShoppingList.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleShoppingList.Controllers
{
    public class ShoppingListController : ApiController
    {
        //currentList.name = "Mock Shopping List";
        //currentList.items = [
        //    { name: "Milk" },
        //    { name: "Bred" },
        //    { name: "Butter"}
        //];

        public static List<ShoppingList> shoppingLists = new List<ShoppingList>
        {
            new ShoppingList() { Id = 0, Name = "Groceries", Items = {
                    new Item { Name = "Milk" },
                    new Item { Name = "Bred" },
                    new Item { Name = "Butter" }
                    }
                },
            new ShoppingList() { Id = 1, Name = "Hardware", Items =
                {
                    new Item { Name = "Hammer"},
                    new Item { Name = "Screwdriver"},
                    new Item { Name = "Forcaps"}
                }
            },
            new ShoppingList() { Id = 2, Name = "Clothes", Items =
                {
                    new Item {Name = "Shirt"},
                    new Item {Name = "Pants"},
                    new Item {Name = "Jacket"}
                }
            }
        };

        // GET: api/ShoppingList
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShoppingList/5
        public IHttpActionResult Get(int id)
        {
            ShoppingList result = shoppingLists.FirstOrDefault(s => s.Id == id);

            if (result == null)
            {
                // return NotFound();
            }

            return Ok(result);

        }

        // POST: api/ShoppingList
        public IEnumerable Post([FromBody] ShoppingList newList)
        {
            newList.Id = shoppingLists.Count;
            shoppingLists.Add(newList);

            return shoppingLists;
        }

        // PUT: api/ShoppingList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShoppingList/5
        public void Delete(int id)
        {
        }
    }
}
