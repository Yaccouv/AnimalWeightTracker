namespace AnimalWeightTracker
{
    partial class ManageAnimals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAnimalMeal = new System.Windows.Forms.DataGridView();
            this.TotalCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnShowFromCombobox = new System.Windows.Forms.Button();
            this.cmbSelectAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimalMealTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimalMeal = new System.Windows.Forms.ComboBox();
            this.txtAnmalMealInG = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateAnimalMeal = new System.Windows.Forms.Button();
            this.btnClearAnimalMealdetails = new System.Windows.Forms.Button();
            this.btnDisplayAnimalMealData = new System.Windows.Forms.Button();
            this.btnSaveAnimalMeal = new System.Windows.Forms.Button();
            this.btnDeleteAnimalMeal = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbAnimalonExerciseType = new System.Windows.Forms.ComboBox();
            this.btnShowAnimalonExercise = new System.Windows.Forms.Button();
            this.cmbSelectAnimalonExercise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExerciseTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvAnimalExercise = new System.Windows.Forms.DataGridView();
            this.TotalCaloriesLost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearAnimalExercise = new System.Windows.Forms.Button();
            this.btnDisplayAnimalExercise = new System.Windows.Forms.Button();
            this.btnSaveAnimalExercise = new System.Windows.Forms.Button();
            this.btnDeleteAnimalExercise = new System.Windows.Forms.Button();
            this.btnUpdateAnimalExercise = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWaist = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnShowwaist = new System.Windows.Forms.Button();
            this.cmbMeasureType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowweight = new System.Windows.Forms.Button();
            this.cmbSelectAnimalonMeasuerement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMeasureTime = new System.Windows.Forms.ComboBox();
            this.txtmeasurement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMeasurement = new System.Windows.Forms.DataGridView();
            this.btnDisplayMeasurement = new System.Windows.Forms.Button();
            this.btnSaveMeasurement = new System.Windows.Forms.Button();
            this.btnDeleteMeasurement = new System.Windows.Forms.Button();
            this.btnUpdateMeasurement = new System.Windows.Forms.Button();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnActivity = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalMeal)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalExercise)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 429);
            this.tabControl1.TabIndex = 57;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAnimalMeal);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.label);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(918, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ANIMAL MEAL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAnimalMeal
            // 
            this.dgvAnimalMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalMeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalCalories});
            this.dgvAnimalMeal.Location = new System.Drawing.Point(7, 293);
            this.dgvAnimalMeal.Name = "dgvAnimalMeal";
            this.dgvAnimalMeal.Size = new System.Drawing.Size(905, 99);
            this.dgvAnimalMeal.TabIndex = 100;
            // 
            // TotalCalories
            // 
            this.TotalCalories.HeaderText = "TotalCalories";
            this.TotalCalories.Name = "TotalCalories";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnShowFromCombobox);
            this.panel5.Controls.Add(this.cmbSelectAnimal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbAnimalMealTime);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cmbAnimalMeal);
            this.panel5.Controls.Add(this.txtAnmalMealInG);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(8, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(479, 240);
            this.panel5.TabIndex = 68;
            // 
            // btnShowFromCombobox
            // 
            this.btnShowFromCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnShowFromCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFromCombobox.ForeColor = System.Drawing.Color.White;
            this.btnShowFromCombobox.Location = new System.Drawing.Point(3, 69);
            this.btnShowFromCombobox.Name = "btnShowFromCombobox";
            this.btnShowFromCombobox.Size = new System.Drawing.Size(89, 36);
            this.btnShowFromCombobox.TabIndex = 90;
            this.btnShowFromCombobox.Text = "SHOW";
            this.btnShowFromCombobox.UseVisualStyleBackColor = false;
            this.btnShowFromCombobox.Click += new System.EventHandler(this.BtnShowFromCombobox_Click);
            // 
            // cmbSelectAnimal
            // 
            this.cmbSelectAnimal.FormattingEnabled = true;
            this.cmbSelectAnimal.Location = new System.Drawing.Point(3, 41);
            this.cmbSelectAnimal.Name = "cmbSelectAnimal";
            this.cmbSelectAnimal.Size = new System.Drawing.Size(470, 28);
            this.cmbSelectAnimal.TabIndex = 89;
            this.cmbSelectAnimal.SelectedIndexChanged += new System.EventHandler(this.CmbSelectAnimal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "SELECT ANIMAL";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cmbAnimalMealTime
            // 
            this.cmbAnimalMealTime.FormattingEnabled = true;
            this.cmbAnimalMealTime.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.cmbAnimalMealTime.Location = new System.Drawing.Point(174, 165);
            this.cmbAnimalMealTime.Name = "cmbAnimalMealTime";
            this.cmbAnimalMealTime.Size = new System.Drawing.Size(299, 28);
            this.cmbAnimalMealTime.TabIndex = 86;
            this.cmbAnimalMealTime.SelectedIndexChanged += new System.EventHandler(this.CmbAnimalMealTime_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "MEAL";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbAnimalMeal
            // 
            this.cmbAnimalMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAnimalMeal.FormattingEnabled = true;
            this.cmbAnimalMeal.Location = new System.Drawing.Point(174, 204);
            this.cmbAnimalMeal.Name = "cmbAnimalMeal";
            this.cmbAnimalMeal.Size = new System.Drawing.Size(299, 28);
            this.cmbAnimalMeal.TabIndex = 84;
            this.cmbAnimalMeal.SelectedIndexChanged += new System.EventHandler(this.CmbAnimalMeal_SelectedIndexChanged);
            // 
            // txtAnmalMealInG
            // 
            this.txtAnmalMealInG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnmalMealInG.Location = new System.Drawing.Point(174, 122);
            this.txtAnmalMealInG.Name = "txtAnmalMealInG";
            this.txtAnmalMealInG.Size = new System.Drawing.Size(299, 31);
            this.txtAnmalMealInG.TabIndex = 81;
            this.txtAnmalMealInG.TextChanged += new System.EventHandler(this.TxtAnmalMealInG_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 25);
            this.label15.TabIndex = 69;
            this.label15.Text = "MEAL IN GM";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 25);
            this.label14.TabIndex = 70;
            this.label14.Text = "TIME";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdateAnimalMeal);
            this.panel4.Controls.Add(this.btnClearAnimalMealdetails);
            this.panel4.Controls.Add(this.btnDisplayAnimalMealData);
            this.panel4.Controls.Add(this.btnSaveAnimalMeal);
            this.panel4.Controls.Add(this.btnDeleteAnimalMeal);
            this.panel4.Location = new System.Drawing.Point(583, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 236);
            this.panel4.TabIndex = 84;
            // 
            // btnUpdateAnimalMeal
            // 
            this.btnUpdateAnimalMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnUpdateAnimalMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAnimalMeal.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAnimalMeal.Location = new System.Drawing.Point(2, 89);
            this.btnUpdateAnimalMeal.Name = "btnUpdateAnimalMeal";
            this.btnUpdateAnimalMeal.Size = new System.Drawing.Size(304, 35);
            this.btnUpdateAnimalMeal.TabIndex = 85;
            this.btnUpdateAnimalMeal.Text = "UPDATE";
            this.btnUpdateAnimalMeal.UseVisualStyleBackColor = false;
            this.btnUpdateAnimalMeal.Click += new System.EventHandler(this.BtnUpdateAnimalMeal_Click_1);
            // 
            // btnClearAnimalMealdetails
            // 
            this.btnClearAnimalMealdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnClearAnimalMealdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAnimalMealdetails.ForeColor = System.Drawing.Color.White;
            this.btnClearAnimalMealdetails.Location = new System.Drawing.Point(4, 166);
            this.btnClearAnimalMealdetails.Name = "btnClearAnimalMealdetails";
            this.btnClearAnimalMealdetails.Size = new System.Drawing.Size(301, 38);
            this.btnClearAnimalMealdetails.TabIndex = 84;
            this.btnClearAnimalMealdetails.Text = "CLEAR RESULTS";
            this.btnClearAnimalMealdetails.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAnimalMealData
            // 
            this.btnDisplayAnimalMealData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDisplayAnimalMealData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAnimalMealData.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAnimalMealData.Location = new System.Drawing.Point(3, 3);
            this.btnDisplayAnimalMealData.Name = "btnDisplayAnimalMealData";
            this.btnDisplayAnimalMealData.Size = new System.Drawing.Size(304, 42);
            this.btnDisplayAnimalMealData.TabIndex = 83;
            this.btnDisplayAnimalMealData.Text = "DISPLAY RESULTS";
            this.btnDisplayAnimalMealData.UseVisualStyleBackColor = false;
            this.btnDisplayAnimalMealData.Click += new System.EventHandler(this.BtnDisplayAnimalMealData_Click);
            // 
            // btnSaveAnimalMeal
            // 
            this.btnSaveAnimalMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnSaveAnimalMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAnimalMeal.ForeColor = System.Drawing.Color.White;
            this.btnSaveAnimalMeal.Location = new System.Drawing.Point(3, 127);
            this.btnSaveAnimalMeal.Name = "btnSaveAnimalMeal";
            this.btnSaveAnimalMeal.Size = new System.Drawing.Size(304, 39);
            this.btnSaveAnimalMeal.TabIndex = 61;
            this.btnSaveAnimalMeal.Text = "SAVE";
            this.btnSaveAnimalMeal.UseVisualStyleBackColor = false;
            this.btnSaveAnimalMeal.Click += new System.EventHandler(this.BtnSaveAnimalMeal_Click);
            // 
            // btnDeleteAnimalMeal
            // 
            this.btnDeleteAnimalMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDeleteAnimalMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnimalMeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAnimalMeal.Location = new System.Drawing.Point(3, 46);
            this.btnDeleteAnimalMeal.Name = "btnDeleteAnimalMeal";
            this.btnDeleteAnimalMeal.Size = new System.Drawing.Size(304, 35);
            this.btnDeleteAnimalMeal.TabIndex = 58;
            this.btnDeleteAnimalMeal.Text = "DELETE";
            this.btnDeleteAnimalMeal.UseVisualStyleBackColor = false;
            this.btnDeleteAnimalMeal.Click += new System.EventHandler(this.BtnDeleteAnimalMeal_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(327, 265);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(197, 25);
            this.label.TabIndex = 78;
            this.label.Text = "ANIMAL DETAILS";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbAnimalonExerciseType);
            this.tabPage1.Controls.Add(this.btnShowAnimalonExercise);
            this.tabPage1.Controls.Add(this.cmbSelectAnimalonExercise);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtExerciseTime);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.dgvAnimalExercise);
            this.tabPage1.Controls.Add(this.btnClearAnimalExercise);
            this.tabPage1.Controls.Add(this.btnDisplayAnimalExercise);
            this.tabPage1.Controls.Add(this.btnSaveAnimalExercise);
            this.tabPage1.Controls.Add(this.btnDeleteAnimalExercise);
            this.tabPage1.Controls.Add(this.btnUpdateAnimalExercise);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 392);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "ANIMAL EXERCISE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbAnimalonExerciseType
            // 
            this.cmbAnimalonExerciseType.FormattingEnabled = true;
            this.cmbAnimalonExerciseType.Location = new System.Drawing.Point(107, 111);
            this.cmbAnimalonExerciseType.Name = "cmbAnimalonExerciseType";
            this.cmbAnimalonExerciseType.Size = new System.Drawing.Size(285, 32);
            this.cmbAnimalonExerciseType.TabIndex = 112;
            this.cmbAnimalonExerciseType.SelectedIndexChanged += new System.EventHandler(this.CmbAnimalonExerciseType_SelectedIndexChanged);
            // 
            // btnShowAnimalonExercise
            // 
            this.btnShowAnimalonExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnShowAnimalonExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAnimalonExercise.ForeColor = System.Drawing.Color.White;
            this.btnShowAnimalonExercise.Location = new System.Drawing.Point(12, 68);
            this.btnShowAnimalonExercise.Name = "btnShowAnimalonExercise";
            this.btnShowAnimalonExercise.Size = new System.Drawing.Size(124, 36);
            this.btnShowAnimalonExercise.TabIndex = 110;
            this.btnShowAnimalonExercise.Text = "SHOW";
            this.btnShowAnimalonExercise.UseVisualStyleBackColor = false;
            this.btnShowAnimalonExercise.Click += new System.EventHandler(this.BtnShowAnimalonExercise_Click);
            // 
            // cmbSelectAnimalonExercise
            // 
            this.cmbSelectAnimalonExercise.FormattingEnabled = true;
            this.cmbSelectAnimalonExercise.Location = new System.Drawing.Point(7, 33);
            this.cmbSelectAnimalonExercise.Name = "cmbSelectAnimalonExercise";
            this.cmbSelectAnimalonExercise.Size = new System.Drawing.Size(470, 32);
            this.cmbSelectAnimalonExercise.TabIndex = 109;
            this.cmbSelectAnimalonExercise.SelectedIndexChanged += new System.EventHandler(this.CmbSelectAnimalonExercise_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 108;
            this.label3.Text = "SELECT ANIMAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 107;
            this.label12.Text = "TIME";
            // 
            // txtExerciseTime
            // 
            this.txtExerciseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExerciseTime.Location = new System.Drawing.Point(107, 149);
            this.txtExerciseTime.Name = "txtExerciseTime";
            this.txtExerciseTime.Size = new System.Drawing.Size(285, 31);
            this.txtExerciseTime.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(7, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 25);
            this.label18.TabIndex = 100;
            this.label18.Text = "TYPE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(326, 196);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(226, 25);
            this.label20.TabIndex = 102;
            this.label20.Text = "EXERCISE DETAILS";
            // 
            // dgvAnimalExercise
            // 
            this.dgvAnimalExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalExercise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalCaloriesLost});
            this.dgvAnimalExercise.Location = new System.Drawing.Point(7, 221);
            this.dgvAnimalExercise.Name = "dgvAnimalExercise";
            this.dgvAnimalExercise.Size = new System.Drawing.Size(905, 164);
            this.dgvAnimalExercise.TabIndex = 99;
            // 
            // TotalCaloriesLost
            // 
            this.TotalCaloriesLost.HeaderText = "TotalCaloriesLost";
            this.TotalCaloriesLost.Name = "TotalCaloriesLost";
            this.TotalCaloriesLost.ReadOnly = true;
            // 
            // btnClearAnimalExercise
            // 
            this.btnClearAnimalExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnClearAnimalExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAnimalExercise.ForeColor = System.Drawing.Color.White;
            this.btnClearAnimalExercise.Location = new System.Drawing.Point(597, 183);
            this.btnClearAnimalExercise.Name = "btnClearAnimalExercise";
            this.btnClearAnimalExercise.Size = new System.Drawing.Size(301, 38);
            this.btnClearAnimalExercise.TabIndex = 106;
            this.btnClearAnimalExercise.Text = "CLEAR RESULTS";
            this.btnClearAnimalExercise.UseVisualStyleBackColor = false;
            // 
            // btnDisplayAnimalExercise
            // 
            this.btnDisplayAnimalExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDisplayAnimalExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAnimalExercise.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAnimalExercise.Location = new System.Drawing.Point(597, 48);
            this.btnDisplayAnimalExercise.Name = "btnDisplayAnimalExercise";
            this.btnDisplayAnimalExercise.Size = new System.Drawing.Size(304, 42);
            this.btnDisplayAnimalExercise.TabIndex = 105;
            this.btnDisplayAnimalExercise.Text = "DISPLAY RESULTS";
            this.btnDisplayAnimalExercise.UseVisualStyleBackColor = false;
            this.btnDisplayAnimalExercise.Click += new System.EventHandler(this.BtnDisplayAnimalExercise_Click);
            // 
            // btnSaveAnimalExercise
            // 
            this.btnSaveAnimalExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnSaveAnimalExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAnimalExercise.ForeColor = System.Drawing.Color.White;
            this.btnSaveAnimalExercise.Location = new System.Drawing.Point(597, 138);
            this.btnSaveAnimalExercise.Name = "btnSaveAnimalExercise";
            this.btnSaveAnimalExercise.Size = new System.Drawing.Size(304, 39);
            this.btnSaveAnimalExercise.TabIndex = 98;
            this.btnSaveAnimalExercise.Text = "SAVE";
            this.btnSaveAnimalExercise.UseVisualStyleBackColor = false;
            this.btnSaveAnimalExercise.Click += new System.EventHandler(this.BtnSaveAnimalExercise_Click);
            // 
            // btnDeleteAnimalExercise
            // 
            this.btnDeleteAnimalExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDeleteAnimalExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAnimalExercise.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAnimalExercise.Location = new System.Drawing.Point(597, 7);
            this.btnDeleteAnimalExercise.Name = "btnDeleteAnimalExercise";
            this.btnDeleteAnimalExercise.Size = new System.Drawing.Size(304, 35);
            this.btnDeleteAnimalExercise.TabIndex = 97;
            this.btnDeleteAnimalExercise.Text = "DELETE";
            this.btnDeleteAnimalExercise.UseVisualStyleBackColor = false;
            this.btnDeleteAnimalExercise.Click += new System.EventHandler(this.BtnDeleteAnimalExercise_Click);
            // 
            // btnUpdateAnimalExercise
            // 
            this.btnUpdateAnimalExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnUpdateAnimalExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAnimalExercise.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAnimalExercise.Location = new System.Drawing.Point(597, 93);
            this.btnUpdateAnimalExercise.Name = "btnUpdateAnimalExercise";
            this.btnUpdateAnimalExercise.Size = new System.Drawing.Size(304, 39);
            this.btnUpdateAnimalExercise.TabIndex = 96;
            this.btnUpdateAnimalExercise.Text = "UPDATE";
            this.btnUpdateAnimalExercise.UseVisualStyleBackColor = false;
            this.btnUpdateAnimalExercise.Click += new System.EventHandler(this.BtnUpdateAnimalExercise_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnActivity);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.cmbActivity);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.lblWaist);
            this.tabPage4.Controls.Add(this.lblWeight);
            this.tabPage4.Controls.Add(this.btnShowwaist);
            this.tabPage4.Controls.Add(this.cmbMeasureType);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.btnShowweight);
            this.tabPage4.Controls.Add(this.cmbSelectAnimalonMeasuerement);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.cmbMeasureTime);
            this.tabPage4.Controls.Add(this.txtmeasurement);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.dgvMeasurement);
            this.tabPage4.Controls.Add(this.btnDisplayMeasurement);
            this.tabPage4.Controls.Add(this.btnSaveMeasurement);
            this.tabPage4.Controls.Add(this.btnDeleteMeasurement);
            this.tabPage4.Controls.Add(this.btnUpdateMeasurement);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(918, 392);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "ANIMAL MEASUREMENT";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(544, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 25);
            this.label9.TabIndex = 110;
            this.label9.Text = "Day Average Waist:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(544, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 25);
            this.label8.TabIndex = 109;
            this.label8.Text = "Day Average Weight:";
            // 
            // lblWaist
            // 
            this.lblWaist.AutoSize = true;
            this.lblWaist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.lblWaist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaist.ForeColor = System.Drawing.Color.White;
            this.lblWaist.Location = new System.Drawing.Point(849, 359);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(66, 25);
            this.lblWaist.TabIndex = 107;
            this.lblWaist.Text = "waist";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(838, 317);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 25);
            this.lblWeight.TabIndex = 106;
            this.lblWeight.Text = "weight";
            // 
            // btnShowwaist
            // 
            this.btnShowwaist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnShowwaist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowwaist.ForeColor = System.Drawing.Color.White;
            this.btnShowwaist.Location = new System.Drawing.Point(206, 71);
            this.btnShowwaist.Name = "btnShowwaist";
            this.btnShowwaist.Size = new System.Drawing.Size(179, 36);
            this.btnShowwaist.TabIndex = 105;
            this.btnShowwaist.Text = "SHOW WAIST";
            this.btnShowwaist.UseVisualStyleBackColor = false;
            this.btnShowwaist.Click += new System.EventHandler(this.BtnShowwaist_Click);
            // 
            // cmbMeasureType
            // 
            this.cmbMeasureType.FormattingEnabled = true;
            this.cmbMeasureType.Items.AddRange(new object[] {
            "Weight",
            "Waist"});
            this.cmbMeasureType.Location = new System.Drawing.Point(203, 116);
            this.cmbMeasureType.Name = "cmbMeasureType";
            this.cmbMeasureType.Size = new System.Drawing.Size(267, 32);
            this.cmbMeasureType.TabIndex = 104;
            this.cmbMeasureType.SelectedIndexChanged += new System.EventHandler(this.CmbMeasureType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 103;
            this.label7.Text = "MEASURE TYPE";
            // 
            // btnShowweight
            // 
            this.btnShowweight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnShowweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowweight.ForeColor = System.Drawing.Color.White;
            this.btnShowweight.Location = new System.Drawing.Point(6, 72);
            this.btnShowweight.Name = "btnShowweight";
            this.btnShowweight.Size = new System.Drawing.Size(191, 36);
            this.btnShowweight.TabIndex = 102;
            this.btnShowweight.Text = "SHOW WEIGHT";
            this.btnShowweight.UseVisualStyleBackColor = false;
            this.btnShowweight.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbSelectAnimalonMeasuerement
            // 
            this.cmbSelectAnimalonMeasuerement.FormattingEnabled = true;
            this.cmbSelectAnimalonMeasuerement.Location = new System.Drawing.Point(6, 39);
            this.cmbSelectAnimalonMeasuerement.Name = "cmbSelectAnimalonMeasuerement";
            this.cmbSelectAnimalonMeasuerement.Size = new System.Drawing.Size(470, 32);
            this.cmbSelectAnimalonMeasuerement.TabIndex = 101;
            this.cmbSelectAnimalonMeasuerement.SelectedIndexChanged += new System.EventHandler(this.CmbSelectAnimalonMeasuerement_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 100;
            this.label4.Text = "SELECT ANIMAL";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cmbMeasureTime
            // 
            this.cmbMeasureTime.FormattingEnabled = true;
            this.cmbMeasureTime.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.cmbMeasureTime.Location = new System.Drawing.Point(199, 185);
            this.cmbMeasureTime.Name = "cmbMeasureTime";
            this.cmbMeasureTime.Size = new System.Drawing.Size(271, 32);
            this.cmbMeasureTime.TabIndex = 99;
            this.cmbMeasureTime.SelectedIndexChanged += new System.EventHandler(this.CmbMeasureTime_SelectedIndexChanged);
            // 
            // txtmeasurement
            // 
            this.txtmeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmeasurement.Location = new System.Drawing.Point(200, 151);
            this.txtmeasurement.Name = "txtmeasurement";
            this.txtmeasurement.Size = new System.Drawing.Size(270, 31);
            this.txtmeasurement.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "MEASUREMENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "TIME";
            // 
            // dgvMeasurement
            // 
            this.dgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurement.Location = new System.Drawing.Point(2, 220);
            this.dgvMeasurement.Name = "dgvMeasurement";
            this.dgvMeasurement.Size = new System.Drawing.Size(536, 164);
            this.dgvMeasurement.TabIndex = 88;
            // 
            // btnDisplayMeasurement
            // 
            this.btnDisplayMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDisplayMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayMeasurement.ForeColor = System.Drawing.Color.White;
            this.btnDisplayMeasurement.Location = new System.Drawing.Point(592, 47);
            this.btnDisplayMeasurement.Name = "btnDisplayMeasurement";
            this.btnDisplayMeasurement.Size = new System.Drawing.Size(304, 42);
            this.btnDisplayMeasurement.TabIndex = 94;
            this.btnDisplayMeasurement.Text = "DISPLAY";
            this.btnDisplayMeasurement.UseVisualStyleBackColor = false;
            this.btnDisplayMeasurement.Click += new System.EventHandler(this.BtnDisplayMeasurement_Click);
            // 
            // btnSaveMeasurement
            // 
            this.btnSaveMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnSaveMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMeasurement.ForeColor = System.Drawing.Color.White;
            this.btnSaveMeasurement.Location = new System.Drawing.Point(592, 137);
            this.btnSaveMeasurement.Name = "btnSaveMeasurement";
            this.btnSaveMeasurement.Size = new System.Drawing.Size(304, 39);
            this.btnSaveMeasurement.TabIndex = 87;
            this.btnSaveMeasurement.Text = "SAVE";
            this.btnSaveMeasurement.UseVisualStyleBackColor = false;
            this.btnSaveMeasurement.Click += new System.EventHandler(this.BtnSaveMeasurement_Click);
            // 
            // btnDeleteMeasurement
            // 
            this.btnDeleteMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnDeleteMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMeasurement.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMeasurement.Location = new System.Drawing.Point(592, 6);
            this.btnDeleteMeasurement.Name = "btnDeleteMeasurement";
            this.btnDeleteMeasurement.Size = new System.Drawing.Size(304, 35);
            this.btnDeleteMeasurement.TabIndex = 86;
            this.btnDeleteMeasurement.Text = "DELETE";
            this.btnDeleteMeasurement.UseVisualStyleBackColor = false;
            this.btnDeleteMeasurement.Click += new System.EventHandler(this.BtnDeleteMeasurement_Click);
            // 
            // btnUpdateMeasurement
            // 
            this.btnUpdateMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnUpdateMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMeasurement.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMeasurement.Location = new System.Drawing.Point(592, 92);
            this.btnUpdateMeasurement.Name = "btnUpdateMeasurement";
            this.btnUpdateMeasurement.Size = new System.Drawing.Size(304, 39);
            this.btnUpdateMeasurement.TabIndex = 85;
            this.btnUpdateMeasurement.Text = "UPDATE";
            this.btnUpdateMeasurement.UseVisualStyleBackColor = false;
            this.btnUpdateMeasurement.Click += new System.EventHandler(this.BtnUpdateMeasurement_Click);
            // 
            // cmbActivity
            // 
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Items.AddRange(new object[] {
            "Active",
            "Moderate Active",
            "Inactive"});
            this.cmbActivity.Location = new System.Drawing.Point(667, 192);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(248, 32);
            this.cmbActivity.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(544, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 112;
            this.label10.Text = "ACTIVITY";
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivity.ForeColor = System.Drawing.Color.White;
            this.btnActivity.Location = new System.Drawing.Point(770, 227);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(145, 36);
            this.btnActivity.TabIndex = 113;
            this.btnActivity.Text = "Set Activity";
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.BtnActivity_Click);
            // 
            // ManageAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageAnimals";
            this.Text = "ManageAnimals";
            this.Load += new System.EventHandler(this.ManageAnimals_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalMeal)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalExercise)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimalMealTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimalMeal;
        private System.Windows.Forms.TextBox txtAnmalMealInG;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClearAnimalMealdetails;
        private System.Windows.Forms.Button btnDisplayAnimalMealData;
        private System.Windows.Forms.Button btnSaveAnimalMeal;
        private System.Windows.Forms.Button btnDeleteAnimalMeal;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExerciseTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvAnimalExercise;
        private System.Windows.Forms.Button btnClearAnimalExercise;
        private System.Windows.Forms.Button btnDisplayAnimalExercise;
        private System.Windows.Forms.Button btnSaveAnimalExercise;
        private System.Windows.Forms.Button btnDeleteAnimalExercise;
        private System.Windows.Forms.Button btnUpdateAnimalExercise;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvMeasurement;
        private System.Windows.Forms.Button btnDisplayMeasurement;
        private System.Windows.Forms.Button btnSaveMeasurement;
        private System.Windows.Forms.Button btnDeleteMeasurement;
        private System.Windows.Forms.Button btnUpdateMeasurement;
        private System.Windows.Forms.ComboBox cmbSelectAnimal;
        private System.Windows.Forms.Button btnShowFromCombobox;
        private System.Windows.Forms.DataGridView dgvAnimalMeal;
        private System.Windows.Forms.Button btnUpdateAnimalMeal;
        private System.Windows.Forms.Button btnShowAnimalonExercise;
        private System.Windows.Forms.ComboBox cmbSelectAnimalonExercise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnimalonExerciseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCaloriesLost;
        private System.Windows.Forms.ComboBox cmbSelectAnimalonMeasuerement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMeasureTime;
        private System.Windows.Forms.TextBox txtmeasurement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMeasureType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowweight;
        private System.Windows.Forms.Button btnShowwaist;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Button btnActivity;
    }
}