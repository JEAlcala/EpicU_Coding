﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string result = "";

            /*
            for (int i = 0; i < 10 ; i ++)
            {
                result += "<br />" + i.ToString();
            }
             */
            /*for (int i  = 5; i < =  15; i++)
            {

            }
            */
            
            /*
            for (int i = 15; i >= 5; i--)
            {
                result += "br />" + i.ToString();
            }
            
            string[] names = new string[] { "wolverine", "cyclops", "professor x", "phoenix" };

            /*
            Array.Sort(names);

            {
                
            }
            for (int i = 0; i < names.Length; i++)
            {
                result += "br />" + names[1];
            }
             resultLabel.Text = result;
             */
            string[] names = new string[] { "wolverine", "cyclops", "professor x", "phoenix" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Professor X")
                {
                    result = String.Format("{0} is at index {1} in the list.", names[i], i);
                }
                resultLabel.Text = result;

            }
                
        }
    }
}