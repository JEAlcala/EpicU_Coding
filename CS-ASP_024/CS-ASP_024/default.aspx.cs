﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_024
{
    public partial class _default : System.Web.UI.Page
    {

        string z == "";
        protected void Page_Load(object sender, EventArgs e)
        {

            string z = "Hello";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int x = 1;

            z + = "Bob";

            if (x == 1)
            {
                x = 2;
                z += "Tabor";

            }
            
            string result = x.ToString();


        }
    }
}