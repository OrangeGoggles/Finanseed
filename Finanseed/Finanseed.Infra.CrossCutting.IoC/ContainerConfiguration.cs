using Finanseed.Application;
using Finanseed.Domain.Repositories;
using Finanseed.Domain.Services;
using Finanseed.Infra.Data.Context;
using Finanseed.Infra.Data.Repositories;
using SimpleInjector;

namespace Finanseed.Infra.CrossCutting.IoC
{
    public static class ContainerConfiguration
    {
        public static Container Register(Container container)
        {
            container.Register(() => {    
                return new FinanseedContextFactory().CreateDbContext();
            },Lifestyle.Singleton);
            container.RegisterSingleton<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();

            return container;
        }
    }
}
