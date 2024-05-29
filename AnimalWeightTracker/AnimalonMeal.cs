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
    class AnimalonMeal
    {
        DatabaseConnection database = new DatabaseConnection();
        Animal animal = new Animal();

        private int ID;
        private int MealD;
        private int AnimalID;
        private string time;
        private double grams;


        public int AnimalonMealID
        {
            get { return ID; }
            set { ID = value; }
        }

        public int aMealID
        {
            get { return MealD; }
            set { MealD = value; }
        }

        public int aAnimalID
        {
            get { return AnimalID; }
            set { AnimalID = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public double Grams
        {
            get { return grams; }
            set { grams = value; }
        }

        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm:ss tt");
        }
        string date;

        public void AddAnimalMeal()
        {
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            string query = "insert into AnimalonMeal Values('" + grams + "','" + MealD + "','" + AnimalID + "','" + time + "','" + date + "')";
                database.Manipulate(query);
                MessageBox.Show("Record has been Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void updateAnimalMeal()
        {
            string query = "update AnimalonMeal set Time='" + time + "', Grams='" + grams + "', MealID='" + MealD + "', AnimalID='" + AnimalID + "' where AnimalonMealID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record has been Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void deleteAnimalMeal()
        {
            string query = "delete from AnimalonMeal where AnimalonMealID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record has been  Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        
        public DataTable ReadAnimalMeal(string animalname)
        {
            aAnimalID = animal.retrieveAnimalID(animalname);
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "select AoM.AnimalonMealID, M.MealName, M.calorieValue, AoM.Grams, AoM.Time, AoM.Date from Meals M INNER JOIN AnimalonMeal AoM on M.MealID = AoM.MealID and AnimalID ='" + aAnimalID+"'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }


        public DataTable ReadAnimalMealForDeficit(string animalname)
        {
            aAnimalID = animal.retrieveAnimalID(animalname);
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "select AoM.AnimalonMealID, M.MealName, M.calorieValue, AoM.Grams, AoM.Time, AoM.Date from Meals M INNER JOIN AnimalonMeal AoM on M.MealID = AoM.MealID and AnimalID ='" + aAnimalID + "' and AoM.Date='"+date+"'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

    }
}
