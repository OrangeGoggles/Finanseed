using System;
using System.Collections.Generic;
using Finanseed.Application.Interfaces;
using Finanseed.Application.ViewModels;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Entities;
using Finanseed.Domain.Handlers;
using Finanseed.Domain.Results;
using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    [Route("user")]
    public class UserController : Controller
    {
        private readonly IUserAppService _service;
        /// <summary>
        /// UserController constructor method
        /// </summary>
        /// <param name="service">UserService Depenpendy Injection</param>
        public UserController(IUserAppService service)
        {
            _service = service;
        }
        /// <summary>
        ///     Register a new User
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Returns the newly-created User</returns>
        [HttpPost]
        [Produces("application/json")]
        public UserViewModel Post(UserViewModel command)
        {
            return _service.RegisterUser(command);
        }

        /// <summary>
        /// Return User's information
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>The requested User's View Model</returns>
        [HttpGet]
        [Produces("application/json")]
        public UserViewModel Get(Guid userID){
            return _service.GetUser(userID);
        }
    }
}