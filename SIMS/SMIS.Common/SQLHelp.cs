using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Common
{
    public class SQLHelp
    {
        private static string ConStr = "initial catalog = SMIS; Server = stu32; user id=sa; password=123456;";

        /// <summary>
        /// 执行SQl命令并以Arraylist类型返回
        /// </summary>
        /// <param name="CommandText">SQL命令</param>
        /// <returns>执行完SQL命令返回的数据</returns>
        public static ArrayList ExecuteReArrList(String CommandText)
        {
            ArrayList arr = new ArrayList();
            SqlConnection coon = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(CommandText, coon);
            coon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    arr.Add(reader[i]);
                }
            }
            coon.Close();
            return arr;
        }

        /// <summary>
        /// 执行SQL并返回受影响的条数
        /// </summary>
        /// <param name="CommandText">SQL命令</param>
        /// <returns>受影响的条数</returns>
        public static int Execute(String CommandText)
        {
            int c = -1;
            SqlConnection coon = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(CommandText, coon);
            coon.Open();
            c = cmd.ExecuteNonQuery();
            coon.Close();
            return c;
        }


        /// <summary>
        /// 执行存储过程并返回受影响的条数
        /// </summary>
        /// <param name="Proc">存储过程条数</param>
        /// <param name="paras">存储过程需要的参数</param>
        /// <returns></returns>
        public static int ExecuteProc(String Proc, SqlParameter[] paras)
        {
            int c = -1;
            SqlConnection coon = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(Proc, coon);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter para in paras)
            {
                cmd.Parameters.Add(para);
            }
            coon.Open();
            c = cmd.ExecuteNonQuery();
            return c;
        }

        /// <summary>
        /// 执行SQL命令并以DataTable返回
        /// </summary>
        /// <param name="CommandText">SQl命令</param>
        /// <returns>执行完SQL返回的数据表</returns>
        public static DataTable ExecuteReTable(String CommandText)
        {
            SqlConnection coon = new SqlConnection(ConStr);
            coon.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, coon);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            coon.Close();
            return ds.Tables[0].Copy();
        }
    }
}
