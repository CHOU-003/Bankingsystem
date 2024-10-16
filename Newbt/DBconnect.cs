using System;
using System.Data.SqlClient; 

namespace DBconnect
{
    public class SqlConnectionManager
    {
        private string connectionString;

        public SqlConnectionManager()
        {
            connectionString = "Data Source=LAPTOP-3O5S38SK\\DINHCHAU;User ID=Bankuser;Password=bank025!;Initial Catalog=BANKSYSTEM;";

        }

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open(); 
                Console.WriteLine("Kết nối thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại" + ex.Message);
            }


            return connection;
        }

    }
}
