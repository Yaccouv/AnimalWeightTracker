using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnimalWeightTracker
{
    public partial class AnimalProgressAnalysis : Form
    {
        Animal animal = new Animal();
        AnimalonMeal animalonMeal = new AnimalonMeal();
        DatabaseConnection database = new DatabaseConnection();
        private double meal_dif;
        private double exe_dif;

        string type = "Weight";
        double morning = 0;
        double evening = 0;
        string time1 = "Morning";
        string time2 = "Evening";
        string activity = "";
        string gender = "";
        int aAnimalID = 0;
   
        double average = 0;
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("MM/dd/yyyy hh:mm:ss tt");
        }
        string date;


        int id;
        public AnimalProgressAnalysis()
        {
            InitializeComponent();
        }

        private void AnimalProgressAnalysis_Load(object sender, EventArgs e)
        {
        
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            dgvweights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvweights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllmeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalysis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animal.retrieveAnimal(cmbSelectAnimal);
            
        }
        public void ChartAnimalAnalysis()
        {
            AnimalWeight.Series[0] = new Series();
            AnimalWeight.Series[0].XValueMember = dgvweights.Columns[5].DataPropertyName;
            AnimalWeight.Series[0].YValueMembers = dgvweights.Columns[1].DataPropertyName;
            AnimalWeight.DataSource = dgvweights.DataSource;
            AnimalWeight.Series[0].IsValueShownAsLabel = true;
            this.AnimalWeight.Titles["Weight"].Text = "Weight(Kg)";
            this.AnimalWeight.Titles["Date"].Text = "Date";
            AnimalWeight.Series[0].ChartType = SeriesChartType.Line;
            AnimalWeight.Series[0].BorderWidth = 3;
            AnimalWeight.Series[0].Color=Color.Red;
        }

        public void RetrieveAllWeights()
        {
           
            var getAnimalWeightMeasurement = new Weight();
            dgvweights.DataSource = getAnimalWeightMeasurement.ReadMeasurement(cmbSelectAnimal.Text);

            RetrieveAllMealDetails();
                dgvweights.Columns[0].Visible = false;
                ChartAnimalAnalysis();
            
        }

        private void BtnShowResults_Click(object sender, EventArgs e)
        {
            RetrieveAllWeights();
            calculateWeightChange();
            calorificDefference();
            EstimateCaloricIntake();
            CalculationofAverageWeightLossORGain();
        }

        public void calculateWeightChange()
        {
            int i= dgvweights.Rows.Count-2;
            double firstWeight = Convert.ToDouble(dgvweights.Rows[0].Cells[1].Value);
            double lastweight = Convert.ToDouble(dgvweights.Rows[i].Cells[1].Value);
            lblweightchange.Text = (firstWeight - lastweight).ToString();
        }

        private void CmbSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = animal.retrieveAnimalID(cmbSelectAnimal.Text);
            animalonMeal.aAnimalID = id;
        }

        public void RetrieveAllMealDetails()
        {
            double calorieValueFormeal=0;
            double calorieValueForExercise=0;
            double grams=0;
            double time=0;

            var getAnimalMeal = new AnimalonMeal();
            dgvAllmeal.DataSource = getAnimalMeal.ReadAnimalMealForDeficit(cmbSelectAnimal.Text);
            for (int meal = 0; meal < dgvAllmeal.Rows.Count - 1; meal++)
            {
                calorieValueFormeal = Convert.ToDouble(dgvAllmeal.Rows[meal].Cells[3].Value.ToString());
                grams = Convert.ToDouble(dgvAllmeal.Rows[meal].Cells[4].Value.ToString());
                dgvAllmeal.Rows[meal].Cells["TotalCalories"].Value = Convert.ToDouble(grams * calorieValueFormeal);
                dgvAllmeal.Columns[1].Visible = false;
               
            }
            var getAnimalExercise = new AnimalonExercise();
            dgvAllExercise.DataSource = getAnimalExercise.ReadAnimalExerciseForDeficit(cmbSelectAnimal.Text);
            for (int i = 0; i < dgvAllExercise.Rows.Count - 1; i++)
            {
                calorieValueForExercise = Convert.ToDouble(dgvAllExercise.Rows[i].Cells[3].Value.ToString());
                time = Convert.ToDouble(dgvAllExercise.Rows[i].Cells[4].Value.ToString());
                dgvAllExercise.Rows[i].Cells["TotalCaloriesLost"].Value = Convert.ToDouble(calorieValueForExercise * time);
                dgvAllExercise.Columns[1].Visible = false;
            }



           

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnX_Click(object sender, EventArgs e)
        {

      
        }
      

        public void calorificDefference()
        {
           
            for (int meal1 = 0; meal1 < dgvAllmeal.Rows.Count - 1; meal1++)
            {
                if (date == dgvAllmeal.Rows[meal1].Cells[6].Value.ToString())
                {
                    for (int meal = 0; meal < 2; meal++)
                    {
                        meal_dif = meal_dif + Convert.ToDouble(dgvAllmeal.Rows[meal].Cells["TotalCalories"].Value);
                    }
                }
            }


            for (int i1 = 0; i1 < dgvAllExercise.Rows.Count - 1; i1++)
            {
                if (date == dgvAllExercise.Rows[i1].Cells[5].Value.ToString())
                {
                    for (int i = 0; i <  2; i++)
                    {
                        exe_dif = exe_dif + Convert.ToDouble(dgvAllExercise.Rows[i].Cells["TotalCaloriesLost"].Value);
                    }
                }
            }
            dgvAnalysis.Refresh();
            var getActivitylevel = new Activity();
            dgvAnalysis.DataSource = getActivitylevel.ReadAnimalActivitylevel(cmbSelectAnimal.Text);
            dgvAnalysis.Rows[0].Cells["Difference"].Value = Convert.ToString((meal_dif / 2) - (exe_dif / 2));
        }

        public void EstimateCaloricIntake()
        {
            double Estamation = 0;

            aAnimalID = animal.retrieveAnimalID(cmbSelectAnimal.Text);
            string query = "select * from Measurement where AnimalID ='" + aAnimalID + "'and Date='" + date + "' and MeasurementType='" + type + "' and Time='" + time1 + "'";
            DataSet ds = database.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    morning = double.Parse(dr.ItemArray.GetValue(1).ToString());
                }
            }

            string query1 = "select * from Measurement where AnimalID ='" + aAnimalID + "'and Date='" + date + "' and MeasurementType='" + type + "' and Time='" + time2 + "'";
            DataSet ds1 = database.select(query1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr1 in ds1.Tables[0].Rows)
                {
                    evening = double.Parse(dr1.ItemArray.GetValue(1).ToString());
                }
            }
            average = ((Convert.ToDouble(morning) + Convert.ToDouble(evening)) / 2);

            string querygen = "select Gender from Animal where AnimalID ='" + aAnimalID + "'";
            DataSet dsgen = database.select(querygen);
            if (dsgen.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow drgen in dsgen.Tables[0].Rows)
                {
                    gender = (drgen.ItemArray.GetValue(0).ToString());
                }
            }

            string queryact = "select * from Activity where AnimalID ='" + aAnimalID + "'and Date='" + date + "'";
            DataSet dsact = database.select(queryact);
            if (dsact.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dract in dsact.Tables[0].Rows)
                {
                    activity = (dract.ItemArray.GetValue(1).ToString());
                }
            }

            if(Convert.ToBoolean(activity=="Active"))
            {
                if(Convert.ToBoolean(gender == "Male"))
                {
                    Estamation = 12 * average;
                }
                else
                {
                    Estamation = 10 * average;
                }
            }
            else if(Convert.ToBoolean(activity == "Moderate Active"))
            {
                if (Convert.ToBoolean(gender == "Male"))
                {
                    Estamation = 10 * average;
                }
                else
                {
                    Estamation = 8 * average;
                }
            }
            else
            {
                if (Convert.ToBoolean(gender == "Male"))
                {
                    Estamation = 8 * average;
                }
                else
                {
                    Estamation = 6 * average;
                }
            }
            dgvAnalysis.Rows[0].Cells["Estamation"].Value = Estamation;
        }

        public void CalculationofAverageWeightLossORGain()
        {
            Label averageweightLossorGain = Application.OpenForms["AnimalProgressAnalysis"].Controls["lblGainLoss"] as Label;
            double yesteraverage = 0;
            int i = dgvweights.Rows.Count - 4;
            double ystermon = Convert.ToDouble(dgvweights.Rows[i].Cells[1].Value);
            int y = dgvweights.Rows.Count - 5;
            double ysterevnweight = Convert.ToDouble(dgvweights.Rows[i].Cells[1].Value);

            yesteraverage = (ystermon + ysterevnweight) / 2;

            averageweightLossorGain.Text = Convert.ToDouble(average + yesteraverage).ToString();
        }
    }
    
}
