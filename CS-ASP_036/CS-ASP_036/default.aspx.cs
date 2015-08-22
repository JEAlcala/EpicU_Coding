using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Color = "Silver";
            myNewCar.Year = 1986;
            
            
            //double MarketValueOfCar = determineMarketValue(myNewCar);
            double MarketValueOfCar = myNewCar.determineMarketValue();

            resultLabel.Text = String.Format("{0} - {1} - {2} -{3}", myNewCar.Model, myNewCar.Make, myNewCar.Color, myNewCar.Year.ToString(), marketValueOfCar);


        }
        /*
        private double determineMarketValue(Car car)
        {
            
            double carValue = 100.00;
            if (car.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            return carValue;
        }
         */
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public double determineMarketValue()
        {
            double carValue = 100.00;
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            return carValue;
        }
    
    
    }
}