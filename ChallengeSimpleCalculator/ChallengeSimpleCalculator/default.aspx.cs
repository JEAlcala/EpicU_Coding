using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
       
           int Addition = int.Parse(firstNumberTextBox.Text) + int.Parse(secondNumberTextBox.Text);
           resultLabel.Text = Addition.ToString();


        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            int Subtraction = int.Parse(firstNumberTextBox.Text) - int.Parse(secondNumberTextBox.Text);
            resultLabel.Text = Subtraction.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int Multiplication = int.Parse(firstNumberTextBox.Text) * int.Parse(secondNumberTextBox.Text);
            resultLabel.Text = Multiplication.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double Division = double.Parse(firstNumberTextBox.Text) / double.Parse(secondNumberTextBox.Text);
            resultLabel.Text = Division.ToString();
        }

        protected void firstNumber_TextBox(object sender, EventArgs e)
        {

        }

        protected void secondNumber_TextBox(object sender, EventArgs e)
        {

        }
    }
}
