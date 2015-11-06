using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql
{
    public partial class InsertProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid =Convert.ToInt32(txtPid.Text);
            string name = txtPname.Text;
            decimal price = Convert.ToDecimal(txtPprice.Text);
            int qty = Convert.ToInt32(txtPqty.Text);

            DataAccessClass dac = new DataAccessClass();
            if (dac.InsertDataIntoProduct(pid, name, price, qty))
                lblMsg.Text = "Data Inserted Successfully";
            else
                lblMsg.Text = "Try again Please,.";
        }
    }
}