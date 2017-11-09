using Finanseed.Domain.Entities;
using Finanseed.Domain.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Finanseed.Services.Controllers
{
    public class UserController : ApiController
    {
        private IUserService UserService;
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        // GET: api/User
        public IEnumerable<User> Get()
        {
            return UserService.GetAll();
        }

        // GET: api/User/5
        public User Get(Guid id)
        {
            return UserService.Get(id);
        }

        // POST: api/User
        public void Post([FromBody]User value)
        {
            UserService.Add(value);
        }

        // PUT: api/User/5
        public void Put(Guid id, [FromBody]User value)
        {
            UserService.Update(value);
        }

        // DELETE: api/User/5
        public void Delete(Guid id)
        {
            UserService.Remove(id);
        }
    }
}
