﻿using Owin;
using System.Web.Http;
using System.Web;

namespace DB3Server
{
    class Startup
    {
        //  Hack from http://stackoverflow.com/a/17227764/19020 to load controllers in 
        //  another assembly.  Another way to do this is to create a custom assembly resolver
        //Type valuesControllerType = typeof(SelfhostWebAPI.Controllers.ProductsController);		

        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // HTTPS and Windows authentication
            // http://frendsrnd.wordpress.com/2014/02/03/httpselfhostserver-hosted-web-api-with-https-and-windows-authentication-enabled/
            //HttpListener listener = (HttpListener)appBuilder.Properties["System.Net.HttpListener"];
            //listener.AuthenticationSchemes = AuthenticationSchemes.IntegratedWindowsAuthentication;			

            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();

            // SelfHosted AspNet WebAPI With Controller Classes In Different Project
            // http://stackoverflow.com/questions/17226671/selfhosted-aspnet-webapi-with-controller-classes-in-different-project/
            //CustomAssembliesResolver assemblyResolver = new CustomAssembliesResolver();
            //config.Services.Replace(typeof(IAssembliesResolver), assemblyResolver);
            //config.SuppressDefaultHostAuthentication();

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            //  Attribute - Enable attribute based routing
            //  http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
            config.MapHttpAttributeRoutes();

            // Formatters
            //config.Formatters.Add(new BinaryMediaTypeFormatter());

            // Filters
          //  config.Filters.Add(new ExceptionFilter());
            //config.Filters.Add(new BasicAuthorizationFilter());

            // Handlers
          //  config.MessageHandlers.Add(new BasicAuthenticationHandler());

            // Json Serializer to ignore the [Serializable] attribute 'k__BackingField'
            //var serializerSettings = config.Formatters.JsonFormatter.SerializerSettings;
            //var contractResolver =  (DefaultContractResolver)serializerSettings.ContractResolver;
            //contractResolver.IgnoreSerializableAttribute = true;

            // Routes
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "ActionNameApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            appBuilder.UseWebApi(config);
        }
    }

    //public class CustomAssembliesResolver : DefaultAssembliesResolver
    //{
    //	public override ICollection<Assembly> GetAssemblies()
    //	{
    //		ICollection<Assembly> baseAssemblies = base.GetAssemblies();

    //		List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

    //		// Controllers from Server
    //		baseAssemblies.Add(Assembly.GetAssembly(typeof(CASServer.Controllers.ProductsController)));
    //		baseAssemblies.Add(Assembly.GetAssembly(typeof(CASServer.Controllers.CulturesController)));
    //		baseAssemblies.Add(Assembly.GetAssembly(typeof(CASServer.Controllers.UsersController)));

    //		return assemblies;
    //	}
    //}
}

