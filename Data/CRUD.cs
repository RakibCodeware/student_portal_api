using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace EduPortalAPI.Data
{
    public static class CRUD
    {
        private static SqlCommand cmd;
        private static SqlDataAdapter adp;
        private static DataTable dt;

        //method query execution code
        public static Boolean ExecuteQuery(string sql, SqlConnection conn)
        {
            bool result = true;
            try
            {
                conn.Close();
                conn.Open();

                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                

                return result;
            }
            catch (Exception ex)
            {
                return result = false;
            }
            finally
            {
                conn.Close();
            }
        }


        //Method for Return DataTable 
        public static DataTable ReturnTableNull(string sql, SqlConnection conn)
        {
            try
            {
               
                    conn.Close();
                    conn.Open();
                        
                
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                adp = new SqlDataAdapter(cmd);
                cmd.CommandTimeout = 0;
                dt = new DataTable();
                adp.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                return  null;
                conn.Close();
            }
            finally
            {

                conn.Close();
            }
        }
    }
}
