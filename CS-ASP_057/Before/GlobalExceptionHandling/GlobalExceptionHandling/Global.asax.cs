using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalExceptionHandling
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        void Application_Error(object sender, EventArgs e)
        {
            //What just happened
            Exception ex = Server.GetLastError();

            //ex will always be of the HttpUnhandledException.
            //to get to the exception that CAUSED that to happen
            // you'll need to look at the ex.InnerException
            var innerException = ex.InnerException;

            //Handle a specific type of error differently
            if (innerException.GetType()
                == typeof(ArgumentOutOfRangeException))
            {
                Server.Transfer("Error.aspx");            
            }

            Response.Write("<h2> Something Bad Happened...</h2>");
            Response.Write("<p>" + innerException.Message + "</p>");

            //TO DO; you might choose to implement logging here.
            
            //you must do this if you wan tto hide the
            //yellow page of death..any existing exception
            //after this point wil send the end user the
            //exception page.
            Server.ClearError();
        }
    }
}