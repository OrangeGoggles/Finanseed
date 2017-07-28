using Finanseed.Presentation.Prototype.DAL.Interfaces;
using Finanseed.Presentation.Prototype.DAL.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finanseed.Presentation.Prototype.IoC
{
    public class DependencyInjector
    {
        private static Container RegisterRepositories()
        {
            var container = new Container();

            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            return container;
        }
    }
}