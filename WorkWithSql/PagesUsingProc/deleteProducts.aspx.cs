using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql.PagesUsingProc
{
    public partial class deleteProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtID.Text);
            DataAccessUsingProc dac = new DataAccessUsingProc();
            if (dac.DeleteProducts(pid))
            {
                lblMsg.Text="Product Removed for list..";
            }
            else
            {
                lblMsg.Text = "Product Not Removed,,, check your connection.!!!";
            }
        }
    }
}