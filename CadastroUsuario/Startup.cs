using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(CadastroUsuario.Startup))]

namespace CadastroUsuario
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //pacotes a baixar para uso do JSON Web Token


            /*Install-Package Microsoft.AspNet.WebApi.Owin
            Install-Package Microsoft.Owin.Host.Systemweb
            Install-Package Microsoft.Owin.Cors */


                var config = new HttpConfiguration();

                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }               
                    );

                app.UseCors(CorsOptions.AllowAll);
                app.UseWebApi(config);


}
}
}
