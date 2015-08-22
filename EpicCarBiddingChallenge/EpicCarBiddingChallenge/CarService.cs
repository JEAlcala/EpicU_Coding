using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicCarBiddingChallenge
{
    public class CarService
    {
        //Note: To get this application working, simply replace below with the actual path
        //of your web project. You can do this by running Open File Location on the poject itself.

        //private string _filePath = @"C:\Users\2015A319\Documents\visual studio 2013\Projects\WebPart\WebPart";
        private string _filePath = @"C:\Users\2015A319\Documents";

        public Car GetCar()
        {
            string fullName = Path.Combine(_filePath, "OurCar.json");

            if (!File.Exists(fullName))
                return null;

            string carContents = File.ReadAllText(fullName);

            return JsonConvert.DeserializeObject<Car>(carContents);
        }

        public void SaveCar(Car car)
        {
            string fullName = Path.Combine(_filePath, "OurCar.json");

            string carContents = JsonConvert.SerializeObject(car);

            File.WriteAllText(fullName, carContents);

        }
    }
}
