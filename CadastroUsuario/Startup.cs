using System;
using System.Threading.Tasks;
using System.Web.Http;
using CadastroUsuario.Service;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
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
            //instalar o pacote do OAuth

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

        private void AtivarToken(IAppBuilder app)
        {
            var configToken = new OAuthAuthorizationServerOptions()

            {
                AllowInsecureHttp = true,
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(20),
                TokenEndpointPath = new PathString("token"),
                Provider = new ProviderTokenAcesso()

            };



            app.UseOAuthAuthorizationServer(configToken);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
    
         }


    }


}
