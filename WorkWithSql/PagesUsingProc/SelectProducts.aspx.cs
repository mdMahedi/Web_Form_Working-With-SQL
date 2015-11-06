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
    public partial class SelectProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccessUsingProc dac = new DataAccessUsingProc();
            DataTable dt1 = dac.selectProducts();
            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }
}