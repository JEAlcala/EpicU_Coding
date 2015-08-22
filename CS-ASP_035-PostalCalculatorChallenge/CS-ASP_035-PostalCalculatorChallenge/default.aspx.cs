using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035_PostalCalculatorChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
         if (groundRadioButton.Checked)calculatePostage(.15);
            else if (airRadioButton.Checked)calculatePostage(.25);
            else if (nextDayRadioButton.Checked)calculatePostage(.45);
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
         if (groundRadioButton.Checked)calculatePostage(.15);
            else if (airRadioButton.Checked)calculatePostage(.25);
            else if (nextDayRadioButton.Checked)calculatePostage(.45);
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
         if (groundRadioButton.Checked)calculatePostage(.15);
            else if (airRadioButton.Checked)calculatePostage(.25);
            else if (nextDayRadioButton.Checked)calculatePostage(.45);
        }
        
    
       
        private void calculatePostage(double multiplier)
        {
         if (widthTextBox.Text.Trim().Length ==0 || heightTextBox.Text.Trim().Length == 0)
             return;

         double width, height, length, cost, volume;
         cost = 0.0;

         if (!Double.TryParse(widthTextBox.Text, out width))
            return;

         if (!Double.TryParse(heightTextBox.Text, out height))
            return;

         if (!Double.TryParse(lengthTextBox.Text, out length)) length = 1;

         volume = width * height * length; 

         if (groundRadioButton.Checked) cost = volume * multiplier;
         else if (airRadioButton.Checked) cost = volume * multiplier;
         else if (nextDayRadioButton.Checked) cost = volume * multiplier;

         resultLabel.Text = String.Format(" Your Parcel Will Cost $ {0} to ship",cost.ToString());
            
        }
        
        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage(.15);
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage(.25);
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage(.45); 
        }
    }

      
        }
    
