using Projeto.Dominio.Contracts.Repositories;
using Projeto.Infra.Repositorio.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Projeto.Aplicacao
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Configuração do WebAPI
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Configuração do simpleInjector
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register<IRepositoryEstoque, RepositoryEstoque>(Lifestyle.Scoped);
            container.Register<IRepositoryProduto, RepositoryProduto>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
