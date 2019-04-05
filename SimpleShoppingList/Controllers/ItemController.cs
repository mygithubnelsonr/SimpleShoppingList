using SimpleShoppingList.Controllers;
using SimpleShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleShoppingListt.Controllers
{
    public class ItemController : ApiController
    {
        //// GET: api/Item
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Item/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Item
        public IHttpActionResult Post([FromBody] Item item)
        {
            ShoppingList shoppingList =
                ShoppingListController.shoppingLists
                    .Where(s => s.Id == item.ShoppingListID)
                    .FirstOrDefault();

            if(shoppingList == null)
            {
                return NotFound();
            }

            shoppingList.Items.Add(item);
            return Ok(shoppingList);

        }

        // PUT: api/Item/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
        }
    }
}
