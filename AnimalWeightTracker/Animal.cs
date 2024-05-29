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
    class Animal
    {
        DatabaseConnection database = new DatabaseConnection();

        private int AnimalID;
        private string Species;
        private int Age;
        private string Gender;
        private string Name;
        int animalid;

        public int aAnimalID
        {
            get { return AnimalID; }
            set { AnimalID = value; }
        }


        public String aAnimalSpecies
        {
            get { return Species; }
            set { Species = value; }
        }

        public String aAnimalGender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public String aAnimalName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int aAnimalAge
        {
            get { return Age; }
            set { Age = value; }
        }

        public int retrieveAnimalID(string name)
        {
            string query = "select AnimalID from Animal where Name='" + name + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    animalid = int.Parse(dr.ItemArray.GetValue(0).ToString());
                }
            }
            return animalid;
        }

        public void AddAnimal()
        {
                string query = "insert into Animal Values('" + Species + "', '" + Name + "', '" + Age + "','" + Gender + "')";
                database.Manipulate(query);
                MessageBox.Show("New Animal Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void updateAnimal()
        {
            string query = "update Animal set Specie='" + Species + "', Gender='" + Gender + "', Name='" + Name + "', Age='" + Age + "' where AnimalID='" + AnimalID + "'";
            database.Manipulate(query);
            MessageBox.Show("Animal Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void deleteAnimal()
        {
            string query = "delete from Animal where AnimalID='" + AnimalID + "'";
            database.Manipulate(query);
            MessageBox.Show("Animal Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        public DataTable ReadAnimal()
        {
            var dt = new DataTable();
            using (var cnn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cnn })
                {
                    cmd.CommandText = " select * from Animal";
                    cnn.Open();
                    dt.Load(cmd.ExecuteReader());
                }
            }
            return dt;
        }


        public void retrieveAnimal(ComboBox animal)
        {
            string query = "select * from Animal";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    animal.Items.Add(dr.ItemArray.GetValue(2));
                }

            }
        }

        public DataTable differenceinCaloricIntake(string animalname)
        {
            aAnimalID = retrieveAnimalID(animalname);
            var dt = new DataTable();
            using (var cn = database.Con)
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    string q = "SELECT Meals.MealName, Meals.CalorieValue, Exercise.ExerciseType, Exercise.CalorieValue, AnimalonMeal.Grams, AnimalonExercise.Time " +
                                "FROM (Meals INNER JOIN AnimalonMeal ON Meals.MealID = AnimalonMeal.MealID) INNER JOIN(Exercise INNER JOIN AnimalonExercise ON AnimalonExercise.ExerciseID = Exercise.ExerciseID) ON AnimalonMeal.AnimalID = AnimalonExercise.ANimalID " +
                                "WHERE (((AnimalonMeal.AnimalID) = " + AnimalID + ") AND ((AnimalonExercise.ANimalID) = " + AnimalID + "));";
                    cmd.CommandText = q;
                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                }

            }
            return dt;
        }

    }
}
