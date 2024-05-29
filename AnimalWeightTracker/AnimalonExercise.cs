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
    class AnimalonExercise
    {
        DatabaseConnection database = new DatabaseConnection();
        Animal animal = new Animal();


        private int ID;
        private int ExerciseID;
        private int AnimalID;
        private double time;


        public int AnimalonExerciseID
        {
            get { return ID; }
            set { ID = value; }
        }

        public int aExerciseID
        {
            get { return ExerciseID; }
            set { ExerciseID = value; }
        }

        public int aAnimalID
        {
            get { return AnimalID; }
            set { AnimalID = value; }
        }
        public double Time
        {
            get { return time; }
            set { time = value; }
        }

        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm:ss tt");
        }
        string date;

        public void AddAnimalExercise()
        {
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            string query = "insert into AnimalonExercise Values('" + ExerciseID + "','" + AnimalID + "','" + time + "','" + date + "')";
            database.Manipulate(query);
            MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void updateAnimalExercise()
        {
            string query = "update AnimalonExercise set Time='" + time + "',ExerciseID='" + ExerciseID + "', AnimalID='" + AnimalID + "' where AnimalonExerciseID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void deleteAnimalExercise()
        {
            string query = "delete from AnimalonExercise where AnimalonExerciseID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        public DataTable ReadAnimalExercise(string animalname)
        {
            aAnimalID = animal.retrieveAnimalID(animalname);
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "select AoE.AnimalonExerciseID, E.ExerciseType, E.calorieValue, AoE.Time, AoE.Date from Exercise E INNER JOIN AnimalonExercise AoE on E.ExerciseID = AoE.ExerciseID and AnimalID ='" + aAnimalID + "'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

        public DataTable ReadAnimalExerciseForDeficit(string animalname)
        {
            aAnimalID = animal.retrieveAnimalID(animalname);
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "select AoE.AnimalonExerciseID, E.ExerciseType, E.calorieValue, AoE.Time, AoE.Date from Exercise E INNER JOIN AnimalonExercise AoE on E.ExerciseID = AoE.ExerciseID and AnimalID ='" + aAnimalID + "'";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }
    }
}
