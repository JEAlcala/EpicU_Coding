using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CommonPart
{
    public class BalloonService
    {
        public Balloon GetBalloon(string filePath)
        {
            string fullName = Path.Combine(filePath, "OurBalloon.json");

            if (!File.Exists(fullName))
                return null;

            string balloonContents = File.ReadAllText(fullName);

            return JsonConvert.DeserializeObject<Balloon>(balloonContents);
        }

        public void SaveBalloon(Balloon balloon, string filePath)
        {
            string fullName = Path.Combine(filePath, "OurBalloon.json");

            string balloonContents = JsonConvert.SerializeObject(balloon);

            File.WriteAllText(fullName, balloonContents);
        }

        public object GetBalloon()
        {
            throw new NotImplementedException();
        }
    }
}

