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
    class Staff
    {
        DatabaseConnection database = new DatabaseConnection();

        private int StaffID;
        private string Username;
        private string Password;
        private string Gender;



        public int UserID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }

        public String userUsername
        {
            get { return Username; }
            set { Username = value; }
        }

        public String userPassword
        {
            get { return Password; }
            set { Password = value; }
        }

        public string userGender
        {
            get { return Gender; }
            set { Gender = value; }
        }



        public void AddStaff()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select count(*) from Staff where Username ='" + Username + "'", database.Con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("That Username is available. Please Enter Another Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string query = "insert into Staff Values('" + Username + "', '" + Password + "','" + Gender + "')";
                database.Manipulate(query);
                MessageBox.Show("New Staff Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void updateStaff()
        {

            {
                string query = "update Staff set UserName='" + Username + "', Password='" + Password + "', Gender='" + Gender + "' where StaffID='" + StaffID + "'";
                database.Manipulate(query);
                MessageBox.Show("Staff Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void deleteStaff()
        {
            string query = "delete from Staff where StaffID='" + StaffID + "'";
            database.Manipulate(query);
            MessageBox.Show("Staff Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void StaffLogin()
        {
            string query = "Select * from Staff where Username='" + Username + "' And Password='" + Password + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Welcome", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("This User Does Not Exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable ReadStaff()
        {
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = " select * from Staff";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }
    }
}
