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
    public partial class LoginANDregistration : Form
    {
        Staff staff = new Staff();
        public static string user;
        public LoginANDregistration()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbtnRegMale.Checked == true)
            {
                gender = rbtnRegMale.Text;
            }
            else
            {
                gender = rbtnRegFemale.Text;
            }
            if (txtRegUsername.Text != "" && txtRegPassword.Text != "" && txtRegComfirm.Text != "" && txtRegPassword.Text == txtRegComfirm.Text)
            {
                if (txtRegPassword.Text == txtRegComfirm.Text)
                {
                        staff.userGender = gender;
                        staff.userUsername = txtRegUsername.Text;
                        staff.userPassword = txtRegPassword.Text;
                        staff.AddStaff();
                        txtRegUsername.Clear();
                        txtRegPassword.Clear();
                        txtRegComfirm.Clear();
                        rbtnRegMale.Checked = false;
                        rbtnRegFemale.Checked = false;
                }
                else
                {
                    MessageBox.Show("Password Do Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please fill in all the details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChbPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRegPassword.PasswordChar = this.chbPassword.Checked ? char.MinValue : '*';
        }

        private void Pnlregister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtRegPassword_TextChanged(object sender, EventArgs e)
        {
            txtRegPassword.PasswordChar = '*';
        }

        private void TxtRegComfirm_TextChanged(object sender, EventArgs e)
        {
            txtRegComfirm.PasswordChar = '*';
        }

        private void BtnRegLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlregister.Visible = false;
        }

        private void LoginANDregistration_Load(object sender, EventArgs e)
        {
            pnlregister.Visible = false;
            pnlLogin.Visible = true;
        }

        private void LblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlregister.Visible = true;
            pnlLogin.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogUsername.Text != "" && txtLogpassword.Text != "")
            {
                staff.userUsername = txtLogUsername.Text;
                staff.userPassword = txtLogpassword.Text;
                user = txtLogUsername.Text;
                staff.StaffLogin();
                txtLogUsername.Clear();
                txtLogpassword.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all the details correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtLogpassword_TextChanged(object sender, EventArgs e)
        {
            txtLogpassword.PasswordChar = '*';
        }

        private void CmbLogCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLogpassword.PasswordChar = this.cmbLogCheck.Checked ? char.MinValue : '*';
        }
    }
}
