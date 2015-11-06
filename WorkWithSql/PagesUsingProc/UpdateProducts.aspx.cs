using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql.PagesUsingProc
{
    public partial class UpdateProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtPid.Text);            

            DataAccessUsingProc dac = new DataAccessUsingProc();
            SqlDataReader reader= dac.EditProductForUpdate(pid);

            while (reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtPrice.Text = reader.GetValue(2).ToString();
                txtQty.Text = reader.GetInt32(3).ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtPid.Text);
            string nam = txtName.Text;
            decimal pric = Convert.ToDecimal(txtPrice.Text);
            int qt = Convert.ToInt32(txtQty.Text);

            DataAccessUsingProc dac = new DataAccessUsingProc();
            if (dac.UpdateProducts(pid, nam, pric, qt))
            { 
                lblMsg.Text="Data Update Successfully..";
            }
            else
            {
                lblMsg.Text = "Fail.!!!,,,,, Not Updated..";
            }
        }
    }
}