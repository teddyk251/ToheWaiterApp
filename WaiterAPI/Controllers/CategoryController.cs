using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaiterAPI.Repository;
using WaiterAPI.Models;
using System.Net.Http;
using WaiterAPI.DBContext;
namespace WaiterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ISelectCategory _selectCategory;
        public WaiterContext db = new WaiterContext();
        public CategoryController()
        {
            _selectCategory = new SelectCategory(db);
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<string> GetCategory()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult Get(string id)
        {
            var x = _selectCategory.selectCatagory(id.ToString());
            if (x == null)
                return BadRequest();
            return Ok(x);
        }

        // POST: api/Category
        [HttpPost]
        public void PostCategory([FromBody] string value)
        {
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void PutCategory(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
        }
    }
}
