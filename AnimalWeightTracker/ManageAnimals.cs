using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWeightTracker
{
    public partial class ManageAnimals : Form
    {
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
        }
        string date;

        Activity activity = new Activity();
        Animal animal = new Animal();
        Meal meal = new Meal();
        Exercise exercise = new Exercise();
        AnimalonMeal animalMeal = new AnimalonMeal();
        AnimalonExercise animalonExercise = new AnimalonExercise();
        Measurement measurement = null;
        Weight weight = new Weight();
        Waist waist = new Waist();
        int mealId;
        int animalId;
        int exerciseid;
        double CalorieValue;
        double GramsFed;
        double time;

        public ManageAnimals()
        {
            InitializeComponent();
        }


        private void ManageAnimals_Load(object sender, EventArgs e)
        {
            dgvAnimalMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimalMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimalExercise.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimalExercise.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animal.retrieveAnimal(cmbSelectAnimal);
            meal.retrieveMeal(cmbAnimalMeal);
            exercise.retrieveExercise(cmbAnimalonExerciseType);
            animal.retrieveAnimal(cmbSelectAnimalonExercise);
            animal.retrieveAnimal(cmbSelectAnimalonMeasuerement);
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
        }

        private void Filldatagrids(string animalname)
        {
            var getAnimalMeal = new AnimalonMeal();
            dgvAnimalMeal.DataSource = getAnimalMeal.ReadAnimalMeal(animalname);

            var getAnimalExercise = new AnimalonExercise();
            dgvAnimalExercise.DataSource = getAnimalExercise.ReadAnimalExercise(animalname);
        }

        private void CmbSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal.aAnimalName = cmbSelectAnimal.SelectedItem.ToString();
            animalId = animal.retrieveAnimalID(cmbSelectAnimal.Text);
        }

        private void BtnSaveAnimalMeal_Click(object sender, EventArgs e)
        {
            if (txtAnmalMealInG.Text != "" && cmbSelectAnimal.Text != "" && cmbAnimalMealTime.Text != "" && cmbAnimalMeal.Text != "")
            {
                animalMeal.Grams = Convert.ToDouble(txtAnmalMealInG.Text);
                animalMeal.aMealID = mealId;
                animalMeal.aAnimalID = animalId;
                animalMeal.Time = cmbAnimalMealTime.SelectedItem.ToString();
                animalMeal.AddAnimalMeal();
                txtAnmalMealInG.Clear();
                Filldatagrids(cmbSelectAnimal.Text);
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CmbAnimalMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            meal.MealName = cmbAnimalMeal.SelectedItem.ToString();
            mealId = meal.retrieveMealID();

        }

        private void BtnDisplayAnimalMealData_Click(object sender, EventArgs e)
        {
            if (dgvAnimalMeal.SelectedRows.Count > 0)
            {
                cmbAnimalMeal.Text = dgvAnimalMeal.SelectedRows[0].Cells[2].Value + string.Empty;
                cmbAnimalMealTime.Text = dgvAnimalMeal.SelectedRows[0].Cells[5].Value + string.Empty;
                txtAnmalMealInG.Text = dgvAnimalMeal.SelectedRows[0].Cells[4].Value + string.Empty;
                animalMeal.AnimalonMealID = Convert.ToInt32(dgvAnimalMeal.SelectedRows[0].Cells[1].Value);
            }

            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateAnimalMeal_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteAnimalMeal_Click(object sender, EventArgs e)
        {
            if (dgvAnimalMeal.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Delete This Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    animalMeal.deleteAnimalMeal();
                    Filldatagrids(cmbSelectAnimal.Text);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnShowFromCombobox_Click(object sender, EventArgs e)
        {
            animalMeal.aAnimalID = animalId;
            Filldatagrids(cmbSelectAnimal.Text);
            for (int i = 0; i < dgvAnimalMeal.Rows.Count - 1; i++)
            {
                CalorieValue = Convert.ToDouble(dgvAnimalMeal.Rows[i].Cells[3].Value.ToString());
                GramsFed = Convert.ToDouble(dgvAnimalMeal.Rows[i].Cells[4].Value.ToString());
                dgvAnimalMeal.Rows[i].Cells["TotalCalories"].Value = Convert.ToDouble(CalorieValue * GramsFed);
                dgvAnimalMeal.Columns[1].Visible = false;
            }
        }


        private void BtnUpdateAnimalMeal_Click_1(object sender, EventArgs e)
        {
            if (txtAnmalMealInG.Text != "" && cmbSelectAnimal.Text != "" && cmbAnimalMealTime.Text != "" && cmbAnimalMeal.Text != "")
            {
                animalMeal.Grams = Convert.ToDouble(txtAnmalMealInG.Text);
                animalMeal.aMealID = mealId;
                animalMeal.aAnimalID = animalId;
                animalMeal.Time = cmbAnimalMealTime.SelectedItem.ToString();
                animalMeal.updateAnimalMeal();
                txtAnmalMealInG.Clear();
                Filldatagrids(cmbSelectAnimal.Text);
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveAnimalExercise_Click(object sender, EventArgs e)
        {
            if (txtExerciseTime.Text != "" && cmbSelectAnimalonExercise.Text != "" && cmbAnimalonExerciseType.Text != "")
            {
                animalonExercise.aExerciseID = exerciseid;
                animalonExercise.aAnimalID = animalId;
                animalonExercise.Time = Convert.ToDouble(txtExerciseTime.Text);
                animalonExercise.AddAnimalExercise();
                txtExerciseTime.Clear();
                cmbSelectAnimalonExercise.Text = "";
                cmbAnimalonExerciseType.Text = "";
                Filldatagrids(cmbSelectAnimal.Text);
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CmbAnimalonExerciseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            exercise.ExerciseType = cmbAnimalonExerciseType.SelectedItem.ToString();
            exerciseid = exercise.retrieveExerciseID();
        }

        private void CmbSelectAnimalonExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            animal.aAnimalName = cmbSelectAnimalonExercise.SelectedItem.ToString();
            animalId = animal.retrieveAnimalID(cmbSelectAnimalonExercise.Text);
        }

        private void BtnShowAnimalonExercise_Click(object sender, EventArgs e)
        {
            Filldatagrids(cmbSelectAnimalonExercise.Text);
            for (int i = 0; i < dgvAnimalExercise.Rows.Count - 1; i++)
            {
                CalorieValue = Convert.ToDouble(dgvAnimalExercise.Rows[i].Cells[3].Value.ToString());
                time = Convert.ToDouble(dgvAnimalExercise.Rows[i].Cells[4].Value.ToString());
                dgvAnimalExercise.Rows[i].Cells["TotalCaloriesLost"].Value = Convert.ToDouble(CalorieValue * time);
                dgvAnimalExercise.Columns[1].Visible = false;
            }
        }

        private void BtnUpdateAnimalExercise_Click(object sender, EventArgs e)
        {
            if (txtExerciseTime.Text != "" && cmbSelectAnimalonExercise.Text != "" && cmbAnimalonExerciseType.Text != "")
            {
                animalonExercise.aExerciseID = exerciseid;
                animalonExercise.aAnimalID = animalId;
                animalonExercise.Time = Convert.ToDouble(txtExerciseTime.Text);
                animalonExercise.updateAnimalExercise();
                txtExerciseTime.Clear();
                cmbAnimalonExerciseType.Text = "";
                Filldatagrids(cmbSelectAnimalonExercise.Text);
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteAnimalExercise_Click(object sender, EventArgs e)
        {
            if (dgvAnimalExercise.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Delete This Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    animalonExercise.deleteAnimalExercise();
                    Filldatagrids(cmbSelectAnimalonExercise.Text);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDisplayAnimalExercise_Click(object sender, EventArgs e)
        {
            if (dgvAnimalExercise.SelectedRows.Count > 0)
            {
                cmbAnimalonExerciseType.Text = dgvAnimalExercise.SelectedRows[0].Cells[2].Value + string.Empty;
                txtExerciseTime.Text = dgvAnimalExercise.SelectedRows[0].Cells[4].Value + string.Empty;
                animalonExercise.AnimalonExerciseID = Convert.ToInt32(dgvAnimalExercise.SelectedRows[0].Cells[1].Value);
            }

            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbAnimalMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtAnmalMealInG_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaveMeasurement_Click(object sender, EventArgs e)
        {
            if (cmbSelectAnimalonMeasuerement.Text != "" && cmbMeasureType.Text != "" && cmbMeasureTime.Text != "" && txtmeasurement.Text != "" && date!="")
            {
                weight.AddweightORwaist(cmbSelectAnimalonMeasuerement.Text, cmbMeasureType, txtmeasurement.Text, cmbMeasureTime, Convert.ToDateTime(date));
            }
        }


        private void CmbMeasureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMeasureType.Text == "Weight")
            {
                measurement = new Weight();
            }
            else if (cmbMeasureType.Text == "Waist")
            {
                measurement = new Waist();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateMeasurement_Click(object sender, EventArgs e)
        {
            if (cmbSelectAnimalonMeasuerement.Text != "" && cmbMeasureType.Text != "" && cmbMeasureTime.Text != "" && txtmeasurement.Text != "" )
            {
                weight.UpdateweightORwaist(cmbSelectAnimalonMeasuerement.Text, cmbMeasureType, txtmeasurement.Text, cmbMeasureTime);
                waist.UpdateweightORwaist(cmbSelectAnimalonMeasuerement.Text, cmbMeasureType, txtmeasurement.Text, cmbMeasureTime);
            }
        }

        private void BtnDisplayMeasurement_Click(object sender, EventArgs e)
        {
            show();
        }

        public void show()
        {
            if (dgvMeasurement.SelectedRows.Count > 0)
            {
                txtmeasurement.Text = dgvMeasurement.SelectedRows[0].Cells[1].Value + string.Empty;
                cmbMeasureType.Text = dgvMeasurement.SelectedRows[0].Cells[2].Value + string.Empty;
                cmbMeasureTime.Text = dgvMeasurement.SelectedRows[0].Cells[4].Value + string.Empty;
                if (dgvMeasurement.SelectedRows[0].Cells[2].Value.Equals("Weight"))
                {
                    weight.MeasurementID = Convert.ToInt32(dgvMeasurement.SelectedRows[0].Cells[0].Value);

                }
                else
                {
                    waist.MeasurementID = Convert.ToInt32(dgvMeasurement.SelectedRows[0].Cells[0].Value);
                }
            }

            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var getAnimalWeightMeasurement = new Weight();
            dgvMeasurement.DataSource = getAnimalWeightMeasurement.ReadMeasurement(cmbSelectAnimalonMeasuerement.Text);
            dgvMeasurement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasurement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeasurement.Columns[0].Visible = false;
            weight.AverageWeight(cmbSelectAnimalonMeasuerement.Text, date);
        }

        private void BtnShowwaist_Click(object sender, EventArgs e)
        {
            var getAnimalWaistMeasurement = new Waist();
            dgvMeasurement.DataSource = getAnimalWaistMeasurement.ReadMeasurement(cmbSelectAnimalonMeasuerement.Text);
            dgvMeasurement.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasurement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeasurement.Columns[0].Visible = false;
            waist.AverageWaist(cmbSelectAnimalonMeasuerement.Text, date);
        }

        private void CmbMeasureTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void CmbSelectAnimalonMeasuerement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void BtnDeleteMeasurement_Click(object sender, EventArgs e)
        {
            if (dgvMeasurement.SelectedRows.Count > 0)
            {
                weight.DeleteweightORwaist();
                waist.DeleteweightORwaist();
            }

            else
            {
                MessageBox.Show("Please Select A Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnActivity_Click(object sender, EventArgs e)
        {
            activity.aActivityLevel = cmbActivity.Text;
            activity.AddActivity(cmbSelectAnimalonMeasuerement.Text);
        }
    }
}
