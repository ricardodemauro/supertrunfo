using System.Web.Http;
using System.Web.Routing;

namespace SuperTrunfo.Servico.AMS
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}