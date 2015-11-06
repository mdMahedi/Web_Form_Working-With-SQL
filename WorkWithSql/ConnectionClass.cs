using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WorkWithSql
{
    public class ConnectionClass
    {
        public static SqlConnection GetSqlConnection()
        { 
            //string connectionStirng= @"Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=TestDB;Data Source=NHIDB\SQLEXPRESS";
            //SqlConnection conn=new SqlConnection(connectionStirng);
            //conn.Open();
            //return conn;

            string connectionStirng = ConfigurationManager.ConnectionStrings["Sql_conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionStirng);
            conn.Open();
            return conn;
        }

        public static SqlConnection GetSqlConnectionPracticeDB() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Sql_PracticeDB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}