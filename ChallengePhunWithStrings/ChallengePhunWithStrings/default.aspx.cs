using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string myName = "Joe Alcala";
            char[] charArray = myName.ToCharArray();
            Array.Reverse(charArray);
            string reversedName = new string(charArray);
            resultLabel.Text = string.Format("{0}<br/><br/>", reversedName);


            //2. Reverse this sequence - "Luke,Leia,Han,Chewbacca"
            string starwarsChars = "Luke,Leia,Han,Chewbacca";
            string[] starwarArray = starwarsChars.Split(',');
            foreach (var item in starwarArray.Reverse())
            {
            resultLabel1.Text += item + ' ';
            }

            resultLabel.Text += "<br/><br/>";
            //3. Create ASCII art by appending *s at the beginning and end of names
            foreach (string swName in starwarArray)
            {
                swName.PadLeft(8, '*');

            resultLabel2.Text += swName + "<br/>";
            }

            resultLabel.Text += "<br/>";
            //4. Solve this puzzle:
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
            string puzzleLowered = puzzle.ToLower();
            puzzleLowered = puzzleLowered.Remove(1).ToUpper() + puzzleLowered.Substring(1);
            resultLabel3.Text = puzzleLowered;
        }
    }
}