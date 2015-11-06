using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkWithSql
{
    public partial class SearchFromProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string item = DropDownList1.SelectedItem.ToString();
            string operat = DropDownList2.SelectedItem.ToString();
            string val = TextBox1.Text;

            DataAccessClass dac = new DataAccessClass();
            DataTable dt1 = dac.SearchProducts(item,operat,val);
            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }
}