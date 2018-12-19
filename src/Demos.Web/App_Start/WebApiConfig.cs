using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demos.Web
{
    public static class WebApiConfig
    {
        public static void Init(HttpConfiguration config)
        {
            RegisterWebApiRoute(config);
            RegisterWebApiFilters(config);
            SetFormatters(config);
            SetCors(config);
            config.EnsureInitialized();
        }

        private static void RegisterWebApiRoute(HttpConfiguration config)
        {
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }

        private static void RegisterWebApiFilters(HttpConfiguration config)
        {
            //var filters = GlobalConfiguration.Configuration.Filters;
            //filters.Add(new WebApiTxActionFilter());
        }

        public static void SetFormatters(HttpConfiguration config)
        {
            //JsonSerializerSettings serializerSetting = new JsonSerializerSettings
            //{
            //    ContractResolver = new NHibernateContractResolver(),
            //    //循环问题
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //};
            //config.Formatters.JsonFormatter.SerializerSettings = serializerSetting;

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());

            //jsonp 支持
            config.AddJsonpFormatter();
        }

        public static void SetCors(HttpConfiguration config)
        {
            //https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
            //config.EnableCors();
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }

    #region todo

    //[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    //public class WebApiTxActionFilter : ActionFilterAttribute, IExceptionFilter
    //{
    //    public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
    //    {
    //        base.OnActionExecuted(actionExecutedContext);
    //        //todo
    //    }

    //    public override Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
    //    {
    //        return base.OnActionExecutedAsync(actionExecutedContext, cancellationToken);
    //        //todo
    //    }

    //    public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
    //    {
    //        var exception = actionExecutedContext.Exception;
    //        //todo
    //        throw new System.NotImplementedException();
    //    }
    //}

    #endregion
}