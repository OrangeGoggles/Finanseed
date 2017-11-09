using Finanseed.Application;
using Finanseed.Domain.Repositories;
using Finanseed.Domain.Services;
using Finanseed.Infra.Data.Context;
using Finanseed.Infra.Data.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanseed.Infra.CrossCutting.IoC
{
    public static class ContainerConfiguration
    {
        public static Container Register(Container container)
        {
            container.Register<FinanseedContext>(Lifestyle.Singleton);
            container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            container.Register<IUserService, UserService>(Lifestyle.Transient);
            
            return container;
        }
    }
}
