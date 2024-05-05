using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChuongTrinhQLKS
{
    internal class funcion
    {
        private string sqlrequery = @"Data Source=DESKTOP-MLLK3NM\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True;";

        private SqlConnection mysql;

        public funcion()
        {
            this.mysql = new SqlConnection(sqlrequery);
        }

        public void runQuery(string sql)
        {
            try
            {
                mysql.Open();
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.ExecuteReader();
                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public bool CheckLogin(string username, string password)
        {
            string sql = string.Format("SELECT COUNT(*) FROM STAFF WHERE UserName = '{0}' AND PassWord = '{1}'", username, password);

            using (SqlConnection mysql = new SqlConnection(sqlrequery))
            {
                try
                {
                    mysql.Open();
                    SqlCommand sqlCommand = new SqlCommand(sql, mysql);

                    int count = (int)sqlCommand.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}
