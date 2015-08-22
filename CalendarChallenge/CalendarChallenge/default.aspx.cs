using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            
            resultLabel.Text = myCalendar2.SelectedDate.Subtract(myCalendar1.SelectedDate).TotalDays.ToString();
            resultLabel.Text = Math.Abs(
                myCalendar2.SelectedDate.Subtract(
                myCalendar1.SelectedDate).TotalDays
                ).ToString();


        }
    }
}