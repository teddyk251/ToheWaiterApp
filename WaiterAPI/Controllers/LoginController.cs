﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WaiterAPI.Repository;
using WaiterAPI.Models;
using Microsoft.AspNetCore.Authorization;
using WaiterAPI.DBContext;
namespace WaiterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public WaiterContext db;
        public LoginController()
        {
            _loginService = new LoginService(db);
        }


        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id) { 
        return "value";
        }

        // POST: api/Logi
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User usr)
        {
            var user = await _loginService.Login(usr.username, usr.password);
            if (user == null)
                return BadRequest();
            return
                Ok(user);
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
