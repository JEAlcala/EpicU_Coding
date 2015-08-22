using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {
                previousAssignmentDateCalendar.SelectedDate = DateTime.Now.Date;
                startDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                projectedEndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);

            }

        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            TimeSpan x = startDateCalendar.SelectedDate.Subtract(previousAssignmentDateCalendar.SelectedDate);
            TimeSpan z = projectedEndCalendar.SelectedDate.Subtract(startDateCalendar.SelectedDate);
           
             if (x.TotalDays <= 14)
            {
                resultLabel.Text = "Error Message; Spy must be given 14 days of paid leave before being assigned a new project!";
                startDateCalendar.SelectedDate = previousAssignmentDateCalendar.SelectedDate.AddDays(14);
            }
            else
            {
                double budgetTotal = (z.TotalDays*500);
                
                if (z.TotalDays > 21)
                {
                    budgetTotal = budgetTotal + 1000;
                }

                resultLabel.Text = String.Format("Hi {0} to Project {1} with budget total {2:C}", spyCodeTextBox.Text, newAssignmentTextBox.Text, budgetTotal);
            }
            
        }
    }
}