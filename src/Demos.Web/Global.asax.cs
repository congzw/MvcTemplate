using System;
using System.Web;

namespace Demos.Web
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            MainEntry.Init();
        }
        protected void Application_PostAuthorizeRequest()
        {
            ////Force a Session for WebApi use
            //HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }
        
        protected void Session_Start(object sender, EventArgs e)
        {
            //Force Use Session For A Static SessionId 
            //Session["init"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}