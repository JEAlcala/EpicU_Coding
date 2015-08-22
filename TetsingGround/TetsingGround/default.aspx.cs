using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TetsingGround
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //double myCar = 1.50;
            //int myIntCar = (int)myCar;

            //resultLabel.Text = myIntCar.ToString();
            /*
            double[] myArray = { 1, 2, 3, 4 };
            for (int i = 0; i < myArray.Length; i ++)
            {
                resultLabel.Text += myArray[i].ToString() + "<br />";
            }
             */

           






        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            
            double myFirstValue;
            double mySecondValue;
            
            Double.TryParse(myTextBox.Text, out myFirstValue);
            Double.TryParse(mySecondTextBox.Text, out mySecondValue);

            Calculation(myFirstValue, mySecondValue);
        }

        private void Calculation(double myFirstValue, double mySecondValue)
        {
            resultLabel.Text = (myFirstValue + mySecondValue).ToString();
        }
    }
}