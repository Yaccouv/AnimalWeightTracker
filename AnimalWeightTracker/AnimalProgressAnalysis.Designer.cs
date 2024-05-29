namespace AnimalWeightTracker
{
    partial class AnimalProgressAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cmbSelectAnimal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvweights = new System.Windows.Forms.DataGridView();
            this.AnimalWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.lblweightchange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllExercise = new System.Windows.Forms.DataGridView();
            this.TotalCaloriesLost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllmeal = new System.Windows.Forms.DataGridView();
            this.TotalCalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysis = new System.Windows.Forms.DataGridView();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estamation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGainLoss = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvweights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllmeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectAnimal
            // 
            this.cmbSelectAnimal.FormattingEnabled = true;
            this.cmbSelectAnimal.Location = new System.Drawing.Point(12, 73);
            this.cmbSelectAnimal.Name = "cmbSelectAnimal";
            this.cmbSelectAnimal.Size = new System.Drawing.Size(232, 21);
            this.cmbSelectAnimal.TabIndex = 104;
            this.cmbSelectAnimal.SelectedIndexChanged += new System.EventHandler(this.CmbSelectAnimal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 103;
            this.label4.Text = "SELECT ANIMAL";
            // 
            // dgvweights
            // 
            this.dgvweights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvweights.Location = new System.Drawing.Point(2, 250);
            this.dgvweights.Name = "dgvweights";
            this.dgvweights.Size = new System.Drawing.Size(407, 188);
            this.dgvweights.TabIndex = 102;
            // 
            // AnimalWeight
            // 
            this.AnimalWeight.BorderlineWidth = 4;
            chartArea1.Name = "ChartArea1";
            this.AnimalWeight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AnimalWeight.Legends.Add(legend1);
            this.AnimalWeight.Location = new System.Drawing.Point(870, 45);
            this.AnimalWeight.Name = "AnimalWeight";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.AnimalWeight.Series.Add(series1);
            this.AnimalWeight.Size = new System.Drawing.Size(357, 402);
            this.AnimalWeight.TabIndex = 105;
            this.AnimalWeight.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Name = "Weight";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Date";
            this.AnimalWeight.Titles.Add(title1);
            this.AnimalWeight.Titles.Add(title2);
            // 
            // btnShowResults
            // 
            this.btnShowResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnShowResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.ForeColor = System.Drawing.Color.White;
            this.btnShowResults.Location = new System.Drawing.Point(12, 100);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(124, 36);
            this.btnShowResults.TabIndex = 111;
            this.btnShowResults.Text = "SHOW";
            this.btnShowResults.UseVisualStyleBackColor = false;
            this.btnShowResults.Click += new System.EventHandler(this.BtnShowResults_Click);
            // 
            // lblweightchange
            // 
            this.lblweightchange.AutoSize = true;
            this.lblweightchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.lblweightchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweightchange.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblweightchange.Location = new System.Drawing.Point(329, 222);
            this.lblweightchange.Name = "lblweightchange";
            this.lblweightchange.Size = new System.Drawing.Size(80, 25);
            this.lblweightchange.TabIndex = 112;
            this.lblweightchange.Text = "weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Weight change from the start:";
            // 
            // dgvAllExercise
            // 
            this.dgvAllExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllExercise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalCaloriesLost});
            this.dgvAllExercise.Location = new System.Drawing.Point(595, 18);
            this.dgvAllExercise.Name = "dgvAllExercise";
            this.dgvAllExercise.Size = new System.Drawing.Size(269, 205);
            this.dgvAllExercise.TabIndex = 115;
            // 
            // TotalCaloriesLost
            // 
            this.TotalCaloriesLost.HeaderText = "TotalCaloriesLost";
            this.TotalCaloriesLost.Name = "TotalCaloriesLost";
            // 
            // dgvAllmeal
            // 
            this.dgvAllmeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllmeal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalCalories});
            this.dgvAllmeal.Location = new System.Drawing.Point(301, 18);
            this.dgvAllmeal.Name = "dgvAllmeal";
            this.dgvAllmeal.Size = new System.Drawing.Size(288, 200);
            this.dgvAllmeal.TabIndex = 119;
            // 
            // TotalCalories
            // 
            this.TotalCalories.HeaderText = "TotalCalories";
            this.TotalCalories.Name = "TotalCalories";
            // 
            // dgvAnalysis
            // 
            this.dgvAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Difference,
            this.Estamation});
            this.dgvAnalysis.Location = new System.Drawing.Point(415, 250);
            this.dgvAnalysis.Name = "dgvAnalysis";
            this.dgvAnalysis.Size = new System.Drawing.Size(393, 192);
            this.dgvAnalysis.TabIndex = 124;
            // 
            // Difference
            // 
            this.Difference.HeaderText = "Calorific Defference";
            this.Difference.Name = "Difference";
            // 
            // Estamation
            // 
            this.Estamation.HeaderText = "EstamationActivity Level";
            this.Estamation.Name = "Estamation";
            // 
            // lblGainLoss
            // 
            this.lblGainLoss.AutoSize = true;
            this.lblGainLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.lblGainLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainLoss.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblGainLoss.Location = new System.Drawing.Point(224, 184);
            this.lblGainLoss.Name = "lblGainLoss";
            this.lblGainLoss.Size = new System.Drawing.Size(80, 25);
            this.lblGainLoss.TabIndex = 125;
            this.lblGainLoss.Text = "weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 126;
            this.label2.Text = "Weight GainORLoss";
            // 
            // AnimalProgressAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGainLoss);
            this.Controls.Add(this.dgvAnalysis);
            this.Controls.Add(this.dgvAllmeal);
            this.Controls.Add(this.dgvAllExercise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblweightchange);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.AnimalWeight);
            this.Controls.Add(this.cmbSelectAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvweights);
            this.Name = "AnimalProgressAnalysis";
            this.Text = "AnimalProgressAnalysis";
            this.Load += new System.EventHandler(this.AnimalProgressAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvweights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllmeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectAnimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvweights;
        private System.Windows.Forms.DataVisualization.Charting.Chart AnimalWeight;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Label lblweightchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllExercise;
        private System.Windows.Forms.DataGridView dgvAllmeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCalories;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCaloriesLost;
        private System.Windows.Forms.DataGridView dgvAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estamation;
        private System.Windows.Forms.Label lblGainLoss;
        private System.Windows.Forms.Label label2;
    }
}