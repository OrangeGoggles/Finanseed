using System.Collections.Generic;
using System.Linq;
using Flunt.Notifications;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        protected List<Notification> Notifications;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected bool IsValidOperation()
        {
            return (!Notifications.Any());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        protected new IActionResult Response(object result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = Notifications.ToList().Select(n => n.Message)
            });
        }
        /// <summary>
        /// 
        /// </summary>
        protected void NotifyModelStateErrors()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotifyError(string.Empty, erroMsg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        protected void NotifyError(string code, string message)
        {
            Notifications.Add(new Notification(code, message));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        protected void AddIdentityErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotifyError(result.ToString(), error.Description);
            }
        }
    }
}