using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if (!Page.IsPostBack)
          {
              string[] assets = new string[0];
              ViewState.Add("Assets", assets);

              double[] elections = new double[0];
              ViewState.Add("Elections", elections);

              double[] subterfuge = new double[0];
              ViewState.Add("Subterfuge", subterfuge);
          }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            //Asset Name Array
            string[] assetNames = (string[])ViewState["Assets"];
            Array.Resize(ref assetNames, assetNames.Length + 1);
            int newestName = assetNames.GetUpperBound(0);
            assetNames[newestName] = assetNameTextBox.Text;
            ViewState["Assets"] = assetNames;

            // Election Rigged Array
            double[] electionsRigged = (double[])ViewState["Elections"];
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newestElection = electionsRigged.GetUpperBound(0);
            electionsRigged[newestElection] = double.Parse(electionsRiggedTextBox.Text);
            ViewState["Elections"] = electionsRigged;

            //Acts of Subterfuge
            double[] subterfuge = (double[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int newestSubterfuge = subterfuge.GetUpperBound(0);
            subterfuge[newestSubterfuge] = double.Parse(actsTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            resultLabel.Text = String.Format("Total Elections Rigged:{0}<br />Average acts of Subterfuge per Asset: {1:N2} <br />: (Last Asset you added:{2})"
                , electionsRigged.Sum()
                , subterfuge.Average()
                , assetNames[newestName]);





            

            

            
        }
    }
}