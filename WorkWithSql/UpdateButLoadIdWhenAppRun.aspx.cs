using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql
{
    public partial class UpdateButLoadIdWhenAppRun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(DropDownList1.SelectedValue);
            DataAccessClass dac = new DataAccessClass();
            SqlDataReader reader = dac.SearchProductForEdit(pid);

            while (reader.Read())
            {
                txtPname.Text = reader.GetString(1);
                txtPprice.Text = reader.GetValue(2).ToString();
                txtPqty.Text = reader.GetInt32(3).ToString();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(DropDownList1.SelectedValue);
            string name = txtPname.Text;
            decimal price = Convert.ToDecimal(txtPprice.Text);
            int qty = Convert.ToInt32(txtPqty.Text);

            DataAccessClass dac = new DataAccessClass();
            if (dac.UpdateProduct(pid, name, price, qty))
                lblMsg.Text = "Data Update Successfully";
            else
                lblMsg.Text = "Not Updated,, Mising Sometihng,.";        
        }
    }
}