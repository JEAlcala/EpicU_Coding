using EpicCarBiddingChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateFormWithCar();
        }

        void PopulateFormWithCar()
        {
            var service = new CarService();
            var car = service.GetCar();
            if (car == null)
                return;
            colorLabel.Text = car.Color;
            makeLabel.Text = car.Make;
            modelLabel.Text = car.Model;
            yearLabel.Text = car.Year.ToString();
        }

        protected void bidTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            int bid = int.Parse(bidTextBox.Text);
        }
    }
}