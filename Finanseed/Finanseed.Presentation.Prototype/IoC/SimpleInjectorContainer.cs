using Finanseed.Presentation.Prototype.DAL.Interfaces;
using Finanseed.Presentation.Prototype.DAL.Repositories;
using Finanseed.Presentation.Prototype.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;

namespace Finanseed.Presentation.Prototype.IoC
{
    public class SimpleInjectorContainer
    {
        public static void RegisterRepositories(Container container)
        {
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            container.Register<IWalletRepository, WalletRepository>();
            //container.Register<IAuthenticationManager, AuthenticationManager>();
            container.RegisterSingleton<IUserStore<ApplicationUser>>(new UserStore<ApplicationUser>(new IdentityDbContext("name=FinanseedDB")));
            container.Register(typeof(ApplicationUserManager));
            container.Register(typeof(ApplicationSignInManager));
            
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
        }
    }
}