namespace AnimalWeightTracker
{
    partial class LoginANDregistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.rbtnRegMale = new System.Windows.Forms.RadioButton();
            this.rbtnRegFemale = new System.Windows.Forms.RadioButton();
            this.pnlregister = new System.Windows.Forms.Panel();
            this.btnRegLogin = new System.Windows.Forms.Button();
            this.chbPassword = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRegComfirm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogpassword = new System.Windows.Forms.TextBox();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.cmbLogCheck = new System.Windows.Forms.CheckBox();
            this.pnlregister.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "USERNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "GENDER";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(203, 136);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(216, 26);
            this.txtRegUsername.TabIndex = 4;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(203, 192);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(216, 26);
            this.txtRegPassword.TabIndex = 5;
            this.txtRegPassword.TextChanged += new System.EventHandler(this.TxtRegPassword_TextChanged);
            // 
            // rbtnRegMale
            // 
            this.rbtnRegMale.AutoSize = true;
            this.rbtnRegMale.Location = new System.Drawing.Point(203, 309);
            this.rbtnRegMale.Name = "rbtnRegMale";
            this.rbtnRegMale.Size = new System.Drawing.Size(61, 24);
            this.rbtnRegMale.TabIndex = 6;
            this.rbtnRegMale.TabStop = true;
            this.rbtnRegMale.Text = "Male";
            this.rbtnRegMale.UseVisualStyleBackColor = true;
            // 
            // rbtnRegFemale
            // 
            this.rbtnRegFemale.AutoSize = true;
            this.rbtnRegFemale.Location = new System.Drawing.Point(339, 309);
            this.rbtnRegFemale.Name = "rbtnRegFemale";
            this.rbtnRegFemale.Size = new System.Drawing.Size(80, 24);
            this.rbtnRegFemale.TabIndex = 7;
            this.rbtnRegFemale.TabStop = true;
            this.rbtnRegFemale.Text = "Female";
            this.rbtnRegFemale.UseVisualStyleBackColor = true;
            // 
            // pnlregister
            // 
            this.pnlregister.Controls.Add(this.btnRegLogin);
            this.pnlregister.Controls.Add(this.chbPassword);
            this.pnlregister.Controls.Add(this.btnSubmit);
            this.pnlregister.Controls.Add(this.txtRegComfirm);
            this.pnlregister.Controls.Add(this.label8);
            this.pnlregister.Controls.Add(this.label3);
            this.pnlregister.Controls.Add(this.rbtnRegFemale);
            this.pnlregister.Controls.Add(this.label1);
            this.pnlregister.Controls.Add(this.label2);
            this.pnlregister.Controls.Add(this.rbtnRegMale);
            this.pnlregister.Controls.Add(this.label4);
            this.pnlregister.Controls.Add(this.txtRegPassword);
            this.pnlregister.Controls.Add(this.txtRegUsername);
            this.pnlregister.Location = new System.Drawing.Point(38, 12);
            this.pnlregister.Name = "pnlregister";
            this.pnlregister.Size = new System.Drawing.Size(462, 492);
            this.pnlregister.TabIndex = 8;
            this.pnlregister.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlregister_Paint);
            // 
            // btnRegLogin
            // 
            this.btnRegLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegLogin.Location = new System.Drawing.Point(29, 431);
            this.btnRegLogin.Name = "btnRegLogin";
            this.btnRegLogin.Size = new System.Drawing.Size(390, 44);
            this.btnRegLogin.TabIndex = 53;
            this.btnRegLogin.Text = "LOGIN";
            this.btnRegLogin.UseVisualStyleBackColor = false;
            this.btnRegLogin.Click += new System.EventHandler(this.BtnRegLogin_Click);
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.Location = new System.Drawing.Point(425, 204);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(15, 14);
            this.chbPassword.TabIndex = 52;
            this.chbPassword.UseVisualStyleBackColor = true;
            this.chbPassword.CheckedChanged += new System.EventHandler(this.ChbPassword_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(29, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(390, 44);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtRegComfirm
            // 
            this.txtRegComfirm.Location = new System.Drawing.Point(203, 246);
            this.txtRegComfirm.Name = "txtRegComfirm";
            this.txtRegComfirm.Size = new System.Drawing.Size(216, 26);
            this.txtRegComfirm.TabIndex = 9;
            this.txtRegComfirm.TextChanged += new System.EventHandler(this.TxtRegComfirm_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "COMFIRM PASSWORD";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.cmbLogCheck);
            this.pnlLogin.Controls.Add(this.lblRegister);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.label7);
            this.pnlLogin.Controls.Add(this.txtLogpassword);
            this.pnlLogin.Controls.Add(this.txtLogUsername);
            this.pnlLogin.Location = new System.Drawing.Point(38, 9);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(462, 492);
            this.pnlLogin.TabIndex = 9;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.LinkColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(271, 330);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(161, 20);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.TabStop = true;
            this.lblRegister.Text = "NOT REGISTERED?";
            this.lblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRegister_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Location = new System.Drawing.Point(18, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(390, 44);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "USERNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "LOGIN FORM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "PASSWORD";
            // 
            // txtLogpassword
            // 
            this.txtLogpassword.Location = new System.Drawing.Point(112, 192);
            this.txtLogpassword.Name = "txtLogpassword";
            this.txtLogpassword.Size = new System.Drawing.Size(216, 26);
            this.txtLogpassword.TabIndex = 5;
            this.txtLogpassword.TextChanged += new System.EventHandler(this.TxtLogpassword_TextChanged);
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.Location = new System.Drawing.Point(112, 136);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.Size = new System.Drawing.Size(216, 26);
            this.txtLogUsername.TabIndex = 4;
            // 
            // cmbLogCheck
            // 
            this.cmbLogCheck.AutoSize = true;
            this.cmbLogCheck.Location = new System.Drawing.Point(332, 201);
            this.cmbLogCheck.Name = "cmbLogCheck";
            this.cmbLogCheck.Size = new System.Drawing.Size(130, 24);
            this.cmbLogCheck.TabIndex = 13;
            this.cmbLogCheck.Text = "See Password";
            this.cmbLogCheck.UseVisualStyleBackColor = true;
            this.cmbLogCheck.CheckedChanged += new System.EventHandler(this.CmbLogCheck_CheckedChanged);
            // 
            // LoginANDregistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(514, 548);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlregister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginANDregistration";
            this.Text = "LoginANDregistration";
            this.Load += new System.EventHandler(this.LoginANDregistration_Load);
            this.pnlregister.ResumeLayout(false);
            this.pnlregister.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.RadioButton rbtnRegMale;
        private System.Windows.Forms.RadioButton rbtnRegFemale;
        private System.Windows.Forms.Panel pnlregister;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRegComfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogpassword;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.CheckBox chbPassword;
        private System.Windows.Forms.Button btnRegLogin;
        private System.Windows.Forms.LinkLabel lblRegister;
        private System.Windows.Forms.CheckBox cmbLogCheck;
    }
}