using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TheRedFourm.DB
{
    class SQLHelper
    {
        public SqlConnection connect()//数据库连接
        {
            string rode = @"Data Source=LAPTOP-BGD94J6F\MY_SQL;Initial Catalog=red_forum;Integrated Security=True";
            SqlConnection con = new SqlConnection(rode);
            con.Open();
            return con;
        }

        public SqlCommand command(string sql)   
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)   //增 删 改
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)   //查询
        {
            return command(sql).ExecuteReader();
        }

        public DataSet GetDataSet(string strQuery)  //将查询结果转换为表
        {
            DataSet ds = new DataSet();
            try {
                SqlConnection sqlconn = connect();
                SqlDataAdapter adapter = new SqlDataAdapter(strQuery, sqlconn);
                adapter.Fill(ds);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }


        public int OperateTb(string strCommandText)
        {
            int intResult = 0;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = connect();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = conn;
                cmm.CommandText = strCommandText;

                
                intResult = cmm.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return intResult;
        }
    }
}
