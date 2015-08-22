using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DateDeciderDatingApp
{
    public partial class _default : System.Web.UI.Page
    {
        string[] arrayUserGender;
        double[] arrayUserAge;
        string[] seeking;
        DateTime[] arrayMyStartDate;
        DateTime[] arrayMyEndDate;
        string[] arrayPotentialDateGender;
        double[] arrayPotentialDateMinAge;
        double[] arrayPotentialDateMaxAge;






        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                seeking = new string[0];
                ViewState.Add("Seeking", seeking);

                
                arrayUserGender = new string[0];
                ViewState.Add("arrayUserGender", arrayUserGender);

                arrayUserAge = new double[0];
                ViewState.Add("arrayUserAge", arrayUserAge);

                arrayMyStartDate = new DateTime[0];
                ViewState.Add("arrayMyStartDate", arrayMyStartDate);

                arrayMyEndDate = new DateTime[0];
                ViewState.Add("arrayMyEndDate", arrayMyEndDate);

                arrayPotentialDateGender = new string[0];
                ViewState.Add("arrayPotentialDateGender", arrayPotentialDateGender);

                arrayPotentialDateMinAge = new double[0];
                ViewState.Add("arrayPotentialDateMinAge", arrayPotentialDateMinAge);

                arrayPotentialDateMaxAge = new double[0];
                ViewState.Add("arrayPotentialDateMaxAge", arrayPotentialDateMaxAge);


            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            string userGender = "";
            if (manCheckBox.Checked) userGender = "male";
            else if (womanCheckBox.Checked) userGender = "female";

            double userAge = 0.0;
            if (!Double.TryParse(ageTextBox.Text, out userAge))
                return;

            DateTime myStartDate = startCalendar.SelectedDate;
            DateTime myEndDate = endCalendar.SelectedDate;

            string potentialDateGender = "";
            if (seekingManCheckBox.Checked) potentialDateGender = "male";
            else if (seekingWomenCheckBox.Checked) potentialDateGender = "female";

            double potentialDateMinAge = 0.0;
            if (!Double.TryParse(dateMinTextBox.Text, out potentialDateMinAge))
                return;
            double potentialDateMaxAge = 0.0;
            if (!Double.TryParse(dateMaxTextBox.Text, out potentialDateMaxAge))
                return;

            arrayUserGender = (string[])ViewState["arrayUserGender"];
            Array.Resize(ref arrayUserGender, arrayUserGender.Length + 1);
            int newestGender = arrayUserGender.GetUpperBound(0);
            arrayUserGender[newestGender] = userGender;
            ViewState["arrayUserGender"] = arrayUserGender;

            arrayUserAge = (Double[])ViewState["arrayUserAge"];
            Array.Resize(ref arrayUserAge, arrayUserAge.Length + 1);
            int newestAge = arrayUserAge.GetUpperBound(0);
            arrayUserAge[newestAge] = userAge;
            ViewState["arrayUserAge"] = arrayUserAge;

            arrayMyStartDate = (DateTime[])ViewState["arrayMyStartDate"];
            Array.Resize(ref arrayMyStartDate, arrayMyStartDate.Length + 1);
            int newestMyStartDate = arrayMyStartDate.GetUpperBound(0);
            arrayMyStartDate[newestMyStartDate] = myStartDate;
            ViewState["arrayMyStartDate"] = arrayMyStartDate;

            arrayMyEndDate = (DateTime[])ViewState["arrayMyEndDate"];
            Array.Resize(ref arrayMyEndDate, arrayMyEndDate.Length + 1);
            int newestMyEndDate = arrayMyEndDate.GetUpperBound(0);
            arrayMyEndDate[newestMyEndDate] = myEndDate;
            ViewState["arrayMyEndDate"] = arrayMyEndDate;

            arrayPotentialDateGender = (string[])ViewState["arrayPotentialDateGender"];
            Array.Resize(ref arrayPotentialDateGender, arrayPotentialDateGender.Length + 1);
            int newestPotentialDateGender = arrayPotentialDateGender.GetUpperBound(0);
            arrayPotentialDateGender[newestPotentialDateGender] = potentialDateGender;
            ViewState["arrayPotentialDateGender"] = arrayPotentialDateGender;

            arrayPotentialDateMinAge = (Double[])ViewState["arrayPotentialDateMinAge"];
            Array.Resize(ref arrayPotentialDateMinAge, arrayPotentialDateMinAge.Length + 1);
            int newestPotentialDateMinAge = arrayPotentialDateMinAge.GetUpperBound(0);
            arrayPotentialDateMinAge[newestPotentialDateMinAge] = potentialDateMinAge;
            ViewState["arrayPotentialDateMinAge"] = arrayPotentialDateMinAge;

            arrayPotentialDateMaxAge = (Double[])ViewState["arrayPotentialDateMaxAge"];
            Array.Resize(ref arrayPotentialDateMaxAge, arrayPotentialDateMaxAge.Length + 1);
            int newestPotentialDateMaxAge = arrayPotentialDateMaxAge.GetUpperBound(0);
            arrayPotentialDateMaxAge[newestPotentialDateMaxAge] = potentialDateMaxAge;
            ViewState["arrayPotentialDateMaxAge"] = arrayPotentialDateMaxAge;

             if (newestGender == 0) resultLabel.Text = "No Matches. You are our first entry";
            else
            {
                for (int i = newestGender-1; i >= 0; i--)
                {
                    if (seeking[newestGender] == arrayUserGender[i]
                        && arrayUserAge[i] <= arrayPotentialDateMinAge[newestGender]
                        && arrayUserAge[i] >= arrayPotentialDateMaxAge[newestGender]
                        && (arrayMyStartDate[newestMyStartDate] >= arrayMyStartDate[i] || arrayMyStartDate[newestMyStartDate] < arrayMyStartDate[i]))
                    {
                        resultLabel.Text = String.Format("WE FOUND YOU A MATCH!!! <br />Age: {0}<br />Gender: {1}<br />Available Between: {2} and {3}"
                            , arrayUserGender[i]
                            , arrayUserAge[i]
                            , arrayMyStartDate[i].ToShortDateString()
                            , arrayMyEndDate[i].ToShortDateString());

                        return;
                    }
                    else
                    {
                        resultLabel.Text = "We Could Not Find you a Match in our Database.";
                    }
                    private void processProfile()
            {
            if (manCheckBox.Checked) arrayUserGender = "male";
            else arrayUserGender = "female";

            if (seekingManCheckBox.Checked) arrayPotentialDateGender = "male";
            else arrayPotentialDateGender = "female";

            if (!Double.TryParse(ageTextBox.Text, out userAge))
                return;

            if (!Double.TryParse(dateMinTextBox.Text, out potentialDateMinAge))
                return;

            if (!Double.TryParse(dateMaxTextBox.Text, out potentialDateMaxAge))
                return;      
            }
    }
}
