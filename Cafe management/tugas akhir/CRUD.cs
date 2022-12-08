using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace tugas_akhir
{
    internal class CRUD
    { 
        private static string getConnectionString()
        {
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=PBO;";
            string user = "Username=postgres;";
            string pass = "Password=12345;";

            string constring = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return constring;

        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Perform CRUD operations Failed : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;

            }

            return dt;
        }
    }
}
