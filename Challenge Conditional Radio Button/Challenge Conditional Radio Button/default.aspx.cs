using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Conditional_Radio_Button
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "you selected a pencil";
                resultImage.ImageUrl = "images/pencil.JPG";
            }
            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "you selected a pen";
                resultImage.ImageUrl = "images/pen.jpg";
            }
            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "you selected a phone";
                resultImage.ImageUrl = "images/phone.jpg";

            }
            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "you selected a tablet";
                resultImage.ImageUrl = "images/tablet.jpg";
            }
            else
            {
                resultLabel.Text = "you must select an option";

            }
              

        }

        protected void tabletRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
             