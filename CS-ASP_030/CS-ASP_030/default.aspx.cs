using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_030
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int heroHealth = 100;
            int monsterHealth = 100;

            displayBattleHeader();
            
            monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                

            }
        }
        private void displayBattleHeader()
       
        {
            resultLabel.Text += "<h3> Battle between you and monster begins </h3>";
        }
        private int performAttack(
            int defenderHealth,
            int attackerDamageMax,
            string defenderName,
            string attackerName,
            double criticalHitChance =.1)
        {
            Random random = new Random();
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);
            return defenderHealth;

        }
        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += String.Format("br /> {0} attacks {1} and vanquishes the {2}.", attackerName, defenderName, defenderName);
            else
                resultLabel.Text += String.Format("<br /> {0} attacks {1}, leaving {2} with {3}.", attackerName, defenderName, defenderName, defenderHealth);
        }
        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3> Monster wins!</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3> Hero Wins!</h3>";
            else
                resultLabel.Text += "<h3> They are both losers!</h3>";
        }

        //----------------------------------------------------------------------------------------

         public void displayMonsterStats(
             string monsterName,
             int health,
             int damageMaximum,
             double criticalHitChance)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats< /br> Health:{1} <br /> Damage Max: {2} <br /> Critical Hit: {3} < /p>",
                monsterName, health, damageMaximum, criticalHitChance);
        }

             public void displayMonsterStats(
             string monsterName,
             int health,
             int damageMaximum)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats <br /> Health: {1} <br />Damage Max: {2} <br /> Critical Hit: {3} </p>",
                monsterName,
                health,
                damageMaximum);
        }
            public void displayMonsterStats(
             string monsterName,
             int health)
        {
            resultLabel.Text += String.Format("<p>{0} Current Stats <br /> Health: {1} </p>",
                monsterName, health);
        }
    }
}