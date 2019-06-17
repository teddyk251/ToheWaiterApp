using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaiterAPI.Repository;
using WaiterAPI.Models;
using WaiterAPI.DBContext;
namespace WaiterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private ISelectItem _selectItem;
        private WaiterContext db = new WaiterContext();
        public ItemController()
        {
            _selectItem = new SelectItem(db);
        }
        // GET: api/Item
        [HttpGet]
        public IEnumerable<string> GetItem()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Item/5
        [HttpGet("{id}", Name = "GetItem")]
        public IActionResult GetItem(string id)
        {
            var x = _selectItem.selectItem(id.ToString());
            if (x == null)
                return BadRequest();
            return Ok(x);
        }

        // POST: api/Item
        [HttpPost]
        public void PostItem([FromBody] string value)
        {
        }

        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void PutItem(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
        }
    }
}
