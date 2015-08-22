using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePizzaPOS
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged2(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged3(object sender, EventArgs e)
        {

        }

        protected void ricottaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged2(object sender, EventArgs e)
        {

        }

        protected void spinachCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged3(object sender, EventArgs e)
        {
            /*
            string myCustomerName = customerNameTextBox.Text;
            string myNumberPizzas = numberTextBox.Text;
            string myRicotta = ricottaCheckBox.Text;
            string myPepperoni = pepperoniCheckBox.Text;
            string mySpinach = spinachCheckBox.Text;
            string myExtra = extraCheckBox.Text;
            string myResult = "Hello" + myCustomerName + "you owe";

            double a;
            a = 9.99;
            double b;
            b = 1.50;
            double c;
            c = 2.04;
            double d;
            d = 1.00;
            double e;
            e = 1.05;
            double myResult = a + b;
            double myResult = a + c;
            double myResult = a + d;
            double myResult = a + e;
            
            int Addition = int.Parse(CustomerNameTextBox.Text) + int.Parse(ricottaCheckBox.Text);
            resultLabel.Text = Addition.ToString();
            */





        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            string myNumberPizzas = numberTextBox.Text;
            int myNumberPizza = int.Parse(myNumberPizzas);

            double onePizzaPrice = 9.99;
            double totalPrice = onePizzaPrice * myNumberPizza;
            double ricottaCheese = 0;
            double pepperoni = 0;
            double spinach = 0;
            double extraCheese = 0;

            if (extraCheckBox.Checked)
            {
                extraCheese = 1.05 * myNumberPizza;

            }
            if (spinachCheckBox.Checked)
            {
                spinach = 1.00 * myNumberPizza;
            }
            if (pepperoniCheckBox.Checked)
            {
                pepperoni = 2.04 * myNumberPizza;
            }
            if (ricottaCheckBox.Checked)
            {
                ricottaCheese = 1.50 * myNumberPizza;
            }
            totalPrice = totalPrice + extraCheese + spinach + pepperoni + ricottaCheese;
            totalLabel.Text = totalPrice.ToString();
        }

 
    }
}