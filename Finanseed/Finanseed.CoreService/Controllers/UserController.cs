using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Finanseed.CoreService.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService UserService { get; set; }
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return UserService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            UserService.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(User id, [FromBody]User value)
        {
            UserService.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            UserService.Remove(id);
        }
    }
}
