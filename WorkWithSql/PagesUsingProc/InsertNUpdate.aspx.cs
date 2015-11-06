using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql.PagesUsingProc
{
    public partial class InsertNUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int sd = Convert.ToInt32(txtSupl.Text);
            string nam = txtName.Text;
            int qt = Convert.ToInt32(txtQty.Text);
            decimal pric = Convert.ToDecimal(txtPrice.Text);

            DataAccessUsingProc dac = new DataAccessUsingProc();
            if (dac.InsertProducts(nam, pric, qt, sd))
                lblMsg.Text = "New Product Inserted into Inventory..";
            else
                lblMsg.Text = "Product Not Inserted..";
        }
    }
}