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
    public partial class Main : Form
    {
        Staff staff = new Staff();
        Animal animal = new Animal();
        Meal meal = new Meal();
        Exercise exercise = new Exercise();
        public Main()
        {
            InitializeComponent();
        }

        private void ChbPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRegPassword.PasswordChar = this.chbPassword.Checked ? char.MinValue : '*';
        }

        private void TxtRegPassword_TextChanged(object sender, EventArgs e)
        {
            txtRegPassword.PasswordChar = '*';
        }

        private void TxtConfirmpassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmpassword.PasswordChar = '*';
        }

        private void BtnDisplayStaffData_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {

                txtRegPassword.Text = dgvStaff.SelectedRows[0].Cells[2].Value + string.Empty;
                txtregUsername.Text = dgvStaff.SelectedRows[0].Cells[1].Value + string.Empty;
                if (dgvStaff.SelectedRows[0].Cells[3].Value.Equals("Male"))
                {
                    rbtnMale.Checked = true;
                }
                else
                {
                    rbtnFemale.Checked = true;
                }
                staff.UserID = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
            }

            else
            {
                MessageBox.Show("Please Select A staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Filldatagrids();
            dgvAnimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExercise.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExercise.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.Columns[0].Visible = false;
            dgvAnimal.Columns[0].Visible = false;
            dgvExercise.Columns[0].Visible = false;
            dgvMeals.Columns[0].Visible = false;
        }

        private void Filldatagrids()
        {
            var getStaff = new Staff();
            dgvStaff.DataSource = getStaff.ReadStaff();

            var getAnimal = new Animal();
            dgvAnimal.DataSource = getAnimal.ReadAnimal();

            var getMeal = new Meal();
            dgvMeals.DataSource = getMeal.ReadMeal();

            var getExercise = new Exercise();
            dgvExercise.DataSource = getExercise.ReadExercise();
        }

        private void BtnClearStaffData_Click(object sender, EventArgs e)
        {
            txtregUsername.Clear();
            txtRegPassword.Clear();
            txtConfirmpassword.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
        }

        private void BtnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Do you want To Update This Staff", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (txtRegPassword.Text == txtConfirmpassword.Text)
                    {
                        if (rbtnMale.Checked == true)
                        {
                            staff.userGender = rbtnMale.Text;
                        }
                        else
                        {
                            staff.userGender = rbtnFemale.Text;
                        }
                       
                        staff.userUsername = txtregUsername.Text;
                        staff.userPassword = txtRegPassword.Text;
                        staff.updateStaff();
                        txtregUsername.Clear();
                        txtRegPassword.Clear();
                        txtConfirmpassword.Clear();
                        rbtnMale.Checked = false;
                        rbtnFemale.Checked = false;
                        Filldatagrids();
                    }
                    else
                    {
                        MessageBox.Show("Password Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select A staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Delete'" + txtregUsername.Text + "'", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    staff.deleteStaff();
                    txtregUsername.Clear();
                    txtRegPassword.Clear();
                    txtConfirmpassword.Clear();
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                    Filldatagrids();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select A staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveAnimal_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbtMaleAnimal.Checked == true)
            {
                gender = rbtMaleAnimal.Text;
            }
            else
            {
                gender = rbtFemaleAnimal.Text;
            }
            if (txtSpecies.Text != "" && txtName.Text != "" && txtAge.Text != "" && gender != "")
            {
                animal.aAnimalGender = gender;
                animal.aAnimalSpecies = txtSpecies.Text;
                animal.aAnimalAge = Convert.ToInt32(txtAge.Text);
                animal.aAnimalName = txtName.Text;
                animal.AddAnimal();
                txtSpecies.Clear();
                txtAge.Clear();
                txtName.Clear();
                rbtFemaleAnimal.Checked= false;
                rbtMaleAnimal.Checked = false;
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Fill In All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDisplayAnimalData_Click(object sender, EventArgs e)
        {
            if (dgvAnimal.SelectedRows.Count > 0)
            {
                txtAge.Text = dgvAnimal.SelectedRows[0].Cells[3].Value + string.Empty;
                txtName.Text = dgvAnimal.SelectedRows[0].Cells[2].Value + string.Empty;
                txtSpecies.Text = dgvAnimal.SelectedRows[0].Cells[1].Value + string.Empty;
                if (dgvAnimal.SelectedRows[0].Cells[4].Value.Equals("Male"))
                {
                    rbtMaleAnimal.Checked = true;
                }
                else
                {
                    rbtFemaleAnimal.Checked = true;
                }
                animal.aAnimalID = Convert.ToInt32(dgvAnimal.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Please Select An Animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimal.SelectedRows.Count > 0)
            {
                animal.deleteAnimal();
                txtSpecies.Clear();
                txtAge.Clear();
                txtName.Clear();
                rbtFemaleAnimal.Checked = false;
                rbtMaleAnimal.Checked = false;
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Select an Animal to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateAnimal_Click(object sender, EventArgs e)
        {
            if (dgvAnimal.SelectedRows.Count > 0)
            {
                if (txtName.Text != "" && txtSpecies.Text != "" && txtAge.Text != "")
                {
                    if (rbtMaleAnimal.Checked == true)
                    {
                        animal.aAnimalGender = rbtMaleAnimal.Text;
                    }
                    else
                    {
                        animal.aAnimalGender = rbtFemaleAnimal.Text;
                    }

                    animal.aAnimalSpecies = txtSpecies.Text;
                    animal.aAnimalAge = Convert.ToInt32(txtAge.Text);
                    animal.aAnimalName = txtName.Text;
                    animal.updateAnimal();
                    txtSpecies.Clear();
                    txtAge.Clear();
                    txtName.Clear();
                    rbtMaleAnimal.Checked = false;
                    rbtFemaleAnimal.Checked = false;
                    Filldatagrids();
                }
                else
                {
                    MessageBox.Show("Please Fill In All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Select an Animal to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClearAnimaldetails_Click(object sender, EventArgs e)
        {
            txtSpecies.Clear();
            txtName.Clear();
            rbtMaleAnimal.Checked = false;
            rbtFemaleAnimal.Checked = false;
        }

        private void BtnClearMealResults_Click(object sender, EventArgs e)
        {
            txtMealName.Clear();
            txtCalorieMealValue.Clear();
        }

        private void BtnSaveMeal_Click(object sender, EventArgs e)
        {
            if (txtMealName.Text != "" && txtCalorieMealValue.Text != "")
            {
                meal.MealName = txtMealName.Text;
                meal.CalorieValue = Convert.ToDouble(txtCalorieMealValue.Text);
                meal.AddMeal();
                txtMealName.Clear();
                txtCalorieMealValue.Clear();
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateMeal_Click(object sender, EventArgs e)
        {
            if (txtMealName.Text != "" && txtCalorieMealValue.Text != "")
            {
                meal.MealName = txtMealName.Text;
                meal.CalorieValue = Convert.ToDouble(txtCalorieMealValue.Text);
                meal.updateMeal();
                txtMealName.Clear();
                txtCalorieMealValue.Clear();
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteMeal_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Delete'" + txtMealName.Text + "'", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    meal.deleteMeal();
                    txtMealName.Clear();
                    txtCalorieMealValue.Clear();
                    Filldatagrids();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select An Exercise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDisplayMeal_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0)
            {
                txtMealName.Text = dgvMeals.SelectedRows[0].Cells[1].Value + string.Empty;
                txtCalorieMealValue.Text = dgvMeals.SelectedRows[0].Cells[2].Value + string.Empty;
                meal.MealID = Convert.ToInt32(dgvMeals.SelectedRows[0].Cells[0].Value);
            }

            else
            {
                MessageBox.Show("Please Select A Meal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClearExercise_Click(object sender, EventArgs e)
        {
            txtExersiceType.Clear();
            txtExerciseCalorieValue.Clear();
        }

        private void BtnDisplayExercise_Click(object sender, EventArgs e)
        {
            if (dgvExercise.SelectedRows.Count > 0)
            {
                txtExerciseCalorieValue.Text = dgvExercise.SelectedRows[0].Cells[2].Value + string.Empty;
                txtExersiceType.Text = dgvExercise.SelectedRows[0].Cells[1].Value + string.Empty;
                exercise.ExerciseID = Convert.ToInt32(dgvExercise.SelectedRows[0].Cells[0].Value);
            }

            else
            {
                MessageBox.Show("Please Select An Exercise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpdateExercise_Click(object sender, EventArgs e)
        {
            if (dgvExercise.SelectedRows.Count > 0)
            {
                exercise.ExerciseType = txtExersiceType.Text;
                exercise.CalorieValue = Convert.ToDouble(txtExerciseCalorieValue.Text);
                exercise.updateExercise();
                txtExersiceType.Clear();
                txtExerciseCalorieValue.Clear();
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Select an Exercise to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteExercise_Click(object sender, EventArgs e)
        {
            if (dgvExercise.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Delete'" + txtExersiceType.Text + "'", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    exercise.deleteExercise();
                    txtExersiceType.Clear();
                    txtExerciseCalorieValue.Clear();
                    Filldatagrids();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Please Select An Exercise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveExercise_Click(object sender, EventArgs e)
        {
            if (txtExersiceType.Text != "" && txtExerciseCalorieValue.Text != "")
            {
                exercise.ExerciseType = txtExersiceType.Text;
                exercise.CalorieValue = Convert.ToDouble(txtExerciseCalorieValue.Text);
                exercise.AddExercise();
                txtExersiceType.Clear();
                txtExerciseCalorieValue.Clear();
                Filldatagrids();
            }
            else
            {
                MessageBox.Show("Please Fill In All Details Correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnmanageAnimals_Click(object sender, EventArgs e)
        {
            ManageAnimals manageAnimals = new ManageAnimals();
            manageAnimals.Show();
            this.Hide();
        }

        private void BtnAnimalprogress_Click(object sender, EventArgs e)
        {
            AnimalProgressAnalysis animalProgressAnalysis = new AnimalProgressAnalysis();
            animalProgressAnalysis.Show();
            this.Hide();
        }
    }
}
