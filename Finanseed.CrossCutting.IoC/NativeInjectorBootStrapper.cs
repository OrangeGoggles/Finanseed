using AutoMapper;
using Finanseed.Application.Interfaces;
using Finanseed.Application.Services;
using Finanseed.Domain.Repositories;
using Finanseed.Infra.Context;
using Finanseed.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Finanseed.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IUserAppService, UserAppService>();
            services.AddScoped<IWalletAppService, WalletAppService>();

            //Domain - Commands
            // services.AddSingleton<ICommand, >();

            //Domain - Handlers

            //Infra - Repositories
            services.AddScoped<ITransactionCategoryRepository, TransactionCategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddDbContext<FinanseedDataContext>();
        }
    }
}