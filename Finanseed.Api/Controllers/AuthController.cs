using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using Finanseed.Api.ViewModels;
using Finanseed.Domain.Base;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Handlers;
using Finanseed.Domain.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Finanseed.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly LoginHandler _loginHandler;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginHandler"></param>
        public AuthController(LoginHandler loginHandler)
        {
            _loginHandler = loginHandler;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginCommand"></param>
        /// <param name="signingConfigurations"></param>
        /// <param name="tokenConfigurations"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public object Post(
            [FromBody] LoginCommand loginCommand, [FromServices] SigningConfigurations signingConfigurations, [FromServices] TokenConfigurations tokenConfigurations
        )
        {
            LoginResult authentication = null;
            if (loginCommand != null)
            {
                authentication = (LoginResult)_loginHandler.Handle(loginCommand);
            }

            if (authentication.Success)
            {
                ClaimsIdentity identity = new ClaimsIdentity(new GenericIdentity(authentication.User.Id.ToString(), "Login"),
                    new[] {
                        new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ("N")),
                            new Claim (JwtRegisteredClaimNames.UniqueName, authentication.User.Id.ToString ())
                    });

                DateTime creationDate = DateTime.Now;
                DateTime expireDate = creationDate + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = creationDate,
                    Expires = expireDate
                });
                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = creationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = expireDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK"
                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Falha ao autenticar"
                };
            }
        }
    }
}