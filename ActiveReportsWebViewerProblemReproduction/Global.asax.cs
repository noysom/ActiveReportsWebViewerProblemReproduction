using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ActiveReportsWebViewerProblemReproduction
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            this.UseReporting(settings =>
            {
                settings.UseFileStore(new System.IO.DirectoryInfo(Server.MapPath("~")));
                settings.UseCompression = false;
                settings.UseCustomStore(GetReport);
            });
        }

        private object GetReport(string reportName)
        {
            return new SectionReport();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

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