using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_047
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Car car1 = new Car ("BMW", "528i",2010, "Black");
            Car car2 = new Car ("BMW", "745Li", 2005,"Black");
            Car car3 = new Car ("Ford","Escape",2008, "White");

           List<Car> cars = new List<Car>()
        {
            cars.Add("V1", new Car { Make = "BMW", Model = "528i", Year = 2010, Color = "Black" });
            cars.Add("V2", new Car { Make = "BMW", Model = "745Li", Year = 2005, Color = "Black" });
            cars.Add("V3", new Car { Make = "Ford", Model = "Escape", Year = 2008, Color = "White" });
        };

            //var heroName = "Baltek";
            //var  myName = "Bob";
            //myName = 34.50;
            
            for (int i = 0; i < cars.Count; i ++)
            {
                result += "<h2>" + cars.ElementAt(i).Key + "</h2>"
                    + cars.ElementAt(i).Value.FormatDetailsForDisplay();

            }
            */


            /*
            Car v2;
            if (cars.TryGetValue("V2", out v2))
                result += v2.FormatDetailsForDisplay();
            */
            foreach (Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }
            
            resultLabel.Text = result;
            
            
            
            
            /*
            List<Car> cars = new List<Car>()
            {
                new Car{Make = "BMW", Model = "528i", Color = "Black", Year = 2010},
                new Car{Make = "BMW", Model = "745Li", Color = "Black", Year = 2005},
                new Car{Make = "Ford", Model = "Escape", Color = "White", Year = 2008},

            };

            /*
            for (int i  = 0 ; i < cars.Count; i ++)
            {
                result+= cars.ElementAt(i).FormatDetailsForDisplay();
            }
             */

            /*
            foreach (Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }
           
                resultLabel.Text = result;
            */
        }
    }
}