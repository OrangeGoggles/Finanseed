using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("/")]
        [HttpGet]
        public object Get()
        {
            return new { version =  "Version 0.0.1 "};
        }
    }
}