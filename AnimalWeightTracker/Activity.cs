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
    class Activity
    {
        DatabaseConnection database = new DatabaseConnection();
        Animal animal = new Animal();
        private int ActivityID;
        private string ActivityLevel;
        private int aAnimalID;


        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm:ss tt");
        }
        string date;


        public int aActivityID
        {
            get { return ActivityID; }
            set { ActivityID = value; }
        }


        public String aActivityLevel
        {
            get { return ActivityLevel; }
            set { ActivityLevel = value; }
        }

     
        public void AddActivity(string name)
        {
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            aAnimalID = animal.retrieveAnimalID(name);
            string query = "insert into Activity Values('" + ActivityLevel + "','" + aAnimalID + "','" + date + "')";
            database.Manipulate(query);
            MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        public DataTable ReadAnimalActivitylevel(string animalname)
        {
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            aAnimalID = animal.retrieveAnimalID(animalname);
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "select ActivityLevel from Activity where AnimalID ='" + aAnimalID + "' and Date='"+date+"'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

    }
}
