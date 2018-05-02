using System;
using Finanseed.Application.Interfaces;
using Finanseed.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Finanseed.Api.Controllers
{
    /// <summary>
    /// Wallet's Controller
    /// </summary>
    [Route("wallet")]
    public class WalletController : ApiController
    {
        private readonly IWalletAppService _service;
        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="service"></param>
        public WalletController(IWalletAppService service)
        {
            _service = service;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="walletId"></param>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        public WalletViewModel Get(Guid walletId)
        {
            return _service.GetByID(walletId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        [HttpPost]
        [Produces("application/json")]
        public IActionResult Post([FromBody]WalletViewModel model){

            if (!ModelState.IsValid)
            {
                NotifyModelStateErrors();
                return Response(model);
            }

            _service.Register(model);

            return Response(model);
        }
    }
}