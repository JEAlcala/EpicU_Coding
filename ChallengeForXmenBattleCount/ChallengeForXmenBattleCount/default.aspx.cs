using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Wolverine fewset battles
            //Pheonix most battles

            string[] names = new string [] {"Professor X", "Iceman", "Angel","Beast",
                "Pheonix", "Cyclops", "Wolverine","NightCrawler", "Storm", "Colossus",};
            int[] numbers = new int [] {7,9,12,15,17,13,2,6,8,13};

            double highest = numbers[0];
            double lowest = numbers[0];
            int highindex = 0; 
            int lowindex = 0; 
            
            
            string result = "";

            for (int index = 0; index < numbers.Length; index ++)
            {
                if (numbers[index] > highest)
                    highest = numbers[index];
                {
                    if (numbers[index] < lowest)
                        lowest = numbers[index];
                }
            }
                resultLabel.Text = result;

        }

        }
    }
