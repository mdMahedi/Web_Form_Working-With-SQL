using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkWithSql
{
    public class DataAccessUsingProc
    {
        public DataTable selectProducts()
        {
            SqlConnection conn = ConnectionClass.GetSqlConnectionPracticeDB();
            SqlDataAdapter ad = new SqlDataAdapter("[Sales].[selectproducts]", conn);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertProducts(string name, decimal price, int qty, int sid)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnectionPracticeDB();
            SqlCommand comd = new SqlCommand("[Sales].[insertproducts]", conn);
            comd.CommandType = CommandType.StoredProcedure;

            comd.Parameters.Add("@product", SqlDbType.NVarChar, 60).Value = name;
            comd.Parameters.Add("@price", SqlDbType.Money).Value = price;
            comd.Parameters.Add("@Qty", SqlDbType.Int).Value = qty;
            comd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;

            if (comd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public SqlDataReader EditProductForUpdate(int id)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnectionPracticeDB();
            SqlCommand comd = new SqlCommand("[Sales].[searchProductsById]", conn);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader readr = comd.ExecuteReader();
            return readr;
        }

        public bool UpdateProducts(int id,string name, decimal price, int qty)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnectionPracticeDB();
            SqlCommand comd = new SqlCommand("[Sales].[updateproducts]", conn);
            comd.CommandType = CommandType.StoredProcedure;

            comd.Parameters.Add("@pid", SqlDbType.Int).Value = id;
            comd.Parameters.Add("@product", SqlDbType.NVarChar, 60).Value = name;
            comd.Parameters.Add("@price", SqlDbType.Money).Value = price;
            comd.Parameters.Add("@Qty", SqlDbType.Int).Value = qty;            

            if (comd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool DeleteProducts(int id)
        {
            SqlConnection conn = ConnectionClass.GetSqlConnectionPracticeDB();
            SqlCommand comd = new SqlCommand("[Sales].[delateproducts]", conn);
            comd.CommandType = CommandType.StoredProcedure;

            comd.Parameters.Add("@values", SqlDbType.Int).Value = id;
            if (comd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}