using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AnimalWeightTracker
{
    class DatabaseConnection
    {

        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jcov\source\repos\AnimalWeightTracker\AnimalWeightTracker\AnimalWeightTracker.mdf;Integrated Security=True;");

        public SqlConnection Con
        {
            get
            {
                return conn;
            }
        }

       

        public void Manipulate(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet select(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
