using CommonPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPart
{
    public partial class defaultDos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                PopulateFormWithBalloon();
        }

        string GetBalloonFilePath()
        {
            return Server.MapPath("~/");
        }

        public void PopulateFormWithBalloon()
        {
            var svc = new BalloonService();

            var balloon = svc.GetBalloon(GetBalloonFilePath());

            if (balloon == null)
                return;


        }
    }
}