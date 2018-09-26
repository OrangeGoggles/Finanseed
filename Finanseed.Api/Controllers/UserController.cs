using System;
using Finanseed.Application.Interfaces;
using Finanseed.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Sentry;

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
            try
            {
                return _service.RegisterUser(command);
            }
            catch (Exception e)
            {
                SentrySdk.CaptureException(e);
                throw;
            }
        }

        /// <summary>
        /// Return User's information
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>The requested User's View Model</returns>
        [HttpGet]
        [Produces("application/json")]
        public UserViewModel Get(Guid userID){
            try
            {
                return _service.GetUser(userID);
            }
            catch (Exception e)
            {
                SentrySdk.CaptureException(e);
                throw;
            }
        }
    }
}