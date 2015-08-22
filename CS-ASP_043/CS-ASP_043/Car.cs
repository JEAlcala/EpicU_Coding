using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_043
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double 

        public   Car(string optionsPackage, string color) : this ()
        {
            this.Make = "undefined";
            this.Model = "undefined";
            this.Year = 1955;
            this.Color = "undefined";

        }
        //overloaded constructer
        public Car(string Make, string Model, int Year, string Color)
        public string FomratDetailsForDisplay(
        {
            return String.Format ("Make:{0} - Model: {1} - Year:{2} - Color {3} ");        
        }
    }
}