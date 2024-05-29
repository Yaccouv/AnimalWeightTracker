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
    class Meal
    {
        DatabaseConnection database = new DatabaseConnection();

        private int ID;
        private double calorieV;
        private string mealN;
        int mealId;
        

        public int MealID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string MealName
        {
            get { return mealN; }
            set { mealN = value; }
        }

        public double CalorieValue
        {
            get { return calorieV; }
            set { calorieV = value; }
        }

        public int retrieveMealID()
        {
            string query = "select MealID from Meals where MealName='" + mealN + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    mealId = int.Parse(dr.ItemArray.GetValue(0).ToString());
                }
            }
            return mealId;
        }

        public void AddMeal()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select count(*) from Meals where MealName ='" + mealN + "'", database.Con);
            DataTable table = new DataTable();
            adapt.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("That Meal is already available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string query = "insert into Meals Values('" + mealN + "','" + calorieV + "')";
                database.Manipulate(query);
                MessageBox.Show("New Meal Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        public void updateMeal()
        {
            string query = "update Meals set MealName='" + mealN + "', CalorieValue='" + calorieV + "' where MealID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Meal Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void deleteMeal()
        {
            string query = "delete from Meals where MealID='" + ID + "'";
            database.Manipulate(query);
            MessageBox.Show("Meal Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }



        public DataTable ReadMeal()
        {
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = " select * from Meals";
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

        public void retrieveMeal(ComboBox meal)
        {
           
            string query = "select * from Meals";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    meal.Items.Add(dr.ItemArray.GetValue(1));
                }

            }
        }

      

    }
}
