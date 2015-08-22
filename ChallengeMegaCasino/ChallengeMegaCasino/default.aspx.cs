using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeMegaCasino
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showImages();
                dispImgInTxt();
                moneyLabel.Text = 100.ToString();
                ViewState.Add("playerBankroll", moneyLabel.Text);}
            else
            {
                showImages();
            }
        }

        protected void leverButton_Click(object sender, EventArgs e)
        {
            showImages();
            displayPlayerBetAndWinnings();
            checkLossWin();
            dispImgInTxt();
            displayWinnings();
            

        }
        Random random = new Random();
        
        private string spinReel()
        {
            string[] images = new string[] { "images/Strawberry.png", "images/Bar.png", "images/Lemon.png", "images/Bell.png", "images/Clover.png", "images/Cherry.png", "images/Diamond.png", "images/Orange.png", "images/Seven.png", "images/HorseShoe.png", "images/Plum.png", "images/Watermelon.png" };
            return images[random.Next(11)];
        }

        private void showImages()
        {
            Image1.ImageUrl = spinReel();
            Image2.ImageUrl = spinReel();
            Image3.ImageUrl = spinReel();

        }
        private string[] getRandomArray()
        {
            string[] randomArray = new string[] { Image1.ImageUrl, Image2.ImageUrl, Image3.ImageUrl };

            return randomArray;
        }

        private bool readBar()
        {
            int bars = 0;
            foreach (string item in getRandomArray())
            {if (item == "images/Bar.png"){ bars += 1; }}
            if (bars > 0) { return true; }
            else { return false; }
        }
        private int readCherry()
        {
            int cherry = 0;
            foreach (string item in getRandomArray())
            {if (item == "images/Cherry.png") { cherry += 1; }}

            return cherry;
        }
        private bool readSevens()
        {
            int sevens = 0;
            foreach (string item in getRandomArray())
            {if (item == "images/Seven.png") { sevens += 1; }}
            if (sevens == 3) return true;
            else return false;

        }

        private double playerBankroll()
        {
            double playerBankroll = 100.00;
            ViewState.Add("playerBankroll", playerBankroll);
            return playerBankroll;
        }
        private double bet()
        {
            return double.Parse(yourBetTextBox.Text);

        }
        private double win()
        {
            double win = 0;
            if (cherryWinner(readCherry()) > 0) { win = cherryWinner(readCherry()); }
            if (sevenWinner() == 3) { win = sevenWinner(); }
            return win;

        }
        private string displayPlayerBetAndWinnings()
        {
            return resultLabel.Text += String.Format("You wagered {0:C} and your winnings are {1}", bet(), win());
        }

        private string displayWinnings()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", double.Parse(ViewState["playerBankroll"].ToString()));
            string winningsDisplay = moneyLabel.Text;
            return winningsDisplay;
        }
        private string loserIndicationBar()
        {
            return resultLabel.Text = String.Format("You bet {0:C} and did not win because of the bars player.", bet());
        }
        /*
        private double calculateLosingBet()
        {
            double loser = 0;
            if (cherryWinner() == 0 && sevenWinner() == 0)
            {
                loser = playerBankroll() - bet();
                ViewState.Add("playerBankroll", loser);
            }
            displayLoser();
            return loser;
        }
        private double calculateWinningBet()
        {
            double winner = 0;
            if (cherryWinner() == 0 && sevenWinner() == 0)
            {
                winner = playerBankroll() - bet();
                ViewState.Add("playerBankroll", winner);
            }
            displayWinner();
            return winner;
            
        }
        */
        private string displayWinner()
        {
            return resultLabel.Text = String.Format("You won {0:C}. Congrats, now play again and win more!", bet());
        }
        private string displayCherryWin()
        {
            return resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet(), win());
        }
        private string displayLoser()
        {
            return resultLabel.Text = String.Format("You lost {0:C}. Try again, you're bound to win.", bet());
        }
        private string dispImgInTxt()
        {
            return imgLabel.Text = String.Format("{0} {1} {2}", getRandomArray()[0], getRandomArray()[1], getRandomArray()[2]);
        }
        private double cherryWinner(int cherry)
        {
            double newWinnings = 0;
            if (readCherry() > 1) { newWinnings = bet() * 2; }
            if (readCherry() == 2) { newWinnings = bet() * 3; }
            if (readCherry() == 3) { newWinnings = bet() * 4; }
            return newWinnings;

        }
        private void loserViewState()
        {
            double loser = double.Parse(ViewState["playerBankroll"].ToString()) - bet();
            ViewState.Add("playerBankroll", loser);
        }
        
        private void cherryViewState()
        {
            double cherryWin = cherryWinner(readCherry());
            double thePot = double.Parse(ViewState["playerBankroll"].ToString());
            double newWinnings = cherryWin + thePot;
            ViewState.Add("playerBankroll", newWinnings);
        }
        private double sevenWinner()
        {
            double jackpotPot = 0;
            jackpotPot = bet() * 100; 
            return jackpotPot;
        }
        private void sevenViewState()
        {
            double sevenWin = sevenWinner();
            double thePot = double.Parse(ViewState["playerBankroll"].ToString());
            double newWinnings = sevenWin + thePot;
            ViewState.Add("PlayerBankroll", newWinnings);
        }
        private void checkLossWin()
        {
            if (readBar()) { loserIndicationBar(); return; }
            if (readSevens()){ sevenWinner(); sevenViewState(); return; }
            if (readCherry() > 0) { cherryWinner(readCherry()); displayCherryWin(); cherryViewState(); return; }
            else { displayLoser(); loserViewState(); }
        }
        

    }
}
