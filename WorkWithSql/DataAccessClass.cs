using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkWithSql
{
    public class DataAccessClass
    {
        public DataTable SelectDataFromProduct()
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "select * from [dbo].[Products]";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchProducts(string colName, string operat, string val)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "select * from dbo.Products where " + colName + operat +  "'"+val+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dta = new DataTable();
            da.Fill(dta);
            return dta;
        }

        public bool InsertDataIntoProduct(int id, string name, decimal price, int qty)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "insert into [dbo].[Product] values('" + id + "','" + name + "','" + price + "','" + qty + "')";
            SqlCommand comnd = new SqlCommand(query,conn);
            if (comnd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public SqlDataReader SearchProductForEdit(int pid) 
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "select * from [dbo].[Product] where [pid]=" + pid;
            SqlCommand comnd = new SqlCommand(query, conn);
            SqlDataReader reader = comnd.ExecuteReader();
            return reader;
        }

        public bool UpdateProduct(int id, string name, decimal price, int qty)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnection();
            string query = "update [dbo].[Product] set [pname]='"+name+"',[pprice]='"+price+"',[pqty]='"+qty+"' where [pid]=" + id;
            SqlCommand comnd = new SqlCommand(query, conn);
            if (comnd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}