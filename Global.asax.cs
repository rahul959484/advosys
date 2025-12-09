using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SAIWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            HttpException httpException = exception as HttpException;

            // Clear the server error
            Server.ClearError();


            // Handle different types of errors (e.g., 404 and others)
            if (httpException != null)
            {
                var httpCode = httpException.GetHttpCode();

                if (httpCode == 404)
                {
                    // Redirect to 404 page
                    Response.Redirect("/Home/notfound"); /*page - not - found*/
                }
                else
                {
                    // Redirect to generic error page for all other errors
                    Response.Redirect("/Home/Error_Index");
                }
            }
            else
            {
                if (exception != null)
                {
                    // Redirect to generic error page for all other errors
                    Response.Redirect("/Home/Error_Index");
                }
            }
        }
    }
}
