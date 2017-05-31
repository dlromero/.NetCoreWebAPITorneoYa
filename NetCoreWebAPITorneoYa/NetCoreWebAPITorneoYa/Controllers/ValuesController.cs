﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebAPITorneoYa.Models;
using Microsoft.AspNetCore.Authorization;


namespace NetCoreWebAPITorneoYa.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            DBConnect dbConnect = new DBConnect();
            return new string[] { dbConnect.TestConnection().ToString() };
        }

        // GET api/values/5
        [Authorize("read:messages")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
