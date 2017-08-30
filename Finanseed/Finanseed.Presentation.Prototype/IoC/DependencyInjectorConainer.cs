using Finanseed.Presentation.Prototype.DAL.Interfaces;
using Finanseed.Presentation.Prototype.DAL.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanseed.Presentation.Prototype.IoC
{
    public class DependencyInjectorConainer
    {
        public static Container RegisterRepositories(Container container)
        {
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register<IWalletRepository, WalletRepository>();
            container.Verify();
            return container;
        }
    }
}