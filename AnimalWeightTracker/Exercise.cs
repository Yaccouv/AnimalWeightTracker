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
    class Exercise
    {
        DatabaseConnection database = new DatabaseConnection();

        private int ID;
        private double calorieV;
        private string exerciseT;
        int exerciseid;


        public int ExerciseID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string ExerciseType
        {
            get { return exerciseT; }
            set { exerciseT = value; }
        }


        public double CalorieValue
        {
            get { return calorieV; }
            set { calorieV = value; }
        }

        public int retrieveExerciseID()
        {
            string query = "select ExerciseID from Exercise where ExerciseType='" + exerciseT + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    exerciseid = int.Parse(dr.ItemArray.GetValue(0).ToString());
                }
            }
            return exerciseid;
        }


        public void AddExercise()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select count(*) from Exercise where ExerciseType ='" + exerciseT + "'", database.Con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("That Exercise is already available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string query = "insert into Exercise Values('" + exerciseT + "','" + calorieV + "')";
                database.Manipulate(query);
                MessageBox.Show("New Exersice Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        public void updateExercise()
        {

            {
                string query = "update Exercise set ExerciseType='" + exerciseT + "', CalorieValue='" + calorieV + "'  where ExerciseID='" + ID + "'";
                database.Manipulate(query);
                MessageBox.Show("Exercise Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void deleteExercise()
        {
            string query = "delete from Exercise where ExerciseID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Exercise Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }



        public DataTable ReadExercise()
        {
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = " select * from Exercise";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

        public void retrieveExercise(ComboBox exercise)
        {

            string query = "select * from Exercise";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    exercise.Items.Add(dr.ItemArray.GetValue(1));
                }

            }
        }

        
    }
}
