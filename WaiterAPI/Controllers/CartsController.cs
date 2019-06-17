using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaiterAPI.Models;
using WaiterAPI.ViewModels;
using WaiterAPI.Repository;
using WaiterAPI.DBContext;
using System.Net.Http;
using System.Net;

namespace WaiterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {

        private IAddToCart addToCart;
        private WaiterContext db = new WaiterContext();
        public CartsController()
        {
            addToCart = new AddToCart(db);
        }
        // 


        // GET: api/Carts
        [HttpGet]
        public IEnumerable<string> GetCart()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Carts/5
        [HttpGet("{id}", Name = "GetCart")]
        public ActionResult GetCart(string cartid)
        {
            var x = addToCart.Getcart(cartid);
            if (x == null)
                return NotFound();
            return Ok(x);
        }

        // POST: api/Carts
        [HttpPost]
        public ActionResult PostCart([FromBody] CartVM cartVM)
        {
            addToCart.addToCart(cartVM);
            return CreatedAtAction(nameof(GetCart), new { id = cartVM.cartID }, cartVM);

        }

        // PUT: api/Carts/5
        [HttpPut("{id}")]
        public void PutCart(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteCart(int id)
        {
        }
    }
}
