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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataAccessClass dac = new DataAccessClass();
            DataTable dt1 = dac.SelectDataFromProduct();
            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }

    }
}