using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataSQLChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void stateSearchButton_Click(object sender, EventArgs e)
        {
            var svc = new OrderService();
            var sb = new StringBuilder();

            var list = svc.GetCustomersByState(stateSearchTextBox.Text);

            sb.Append(@"
            <table>
            <tr>
                <th>Customer ID</th>
                <th>First Name</th>
                <th>STate</th>
            </tr>
                ");

            foreach (var c in list)
            {
                sb.Append("<tr>");
                sb.AppendFormat("<td>{0}</td>", c.CustomerID);
                sb.AppendFormat("<td>{0}</td>", c.FirstName);
                sb.AppendFormat("<td>{0}</td>", c.State);

                sb.Append("</tr>");
            }

            sb.Append(@"
            </table>
            ");

            stateSearchResultLabel.Text = sb.ToString();
        }
    }
}