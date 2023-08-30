using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectICT
{
    public partial class FormStaffRegisteration : Form
    {
        ClassDBConnect con = new ClassDBConnect();
        public FormStaffRegisteration()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "INSERT INTO `info_employe`( `First Name`, `Last Name`, `Address`, `Contact`, `Position`, `Username`, `Password`) VALUES (@fn,@ln,@ad,@cno,@po,@un,@ps)";

            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = txtFirstName.Text;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = txtLastName.Text;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@cno", MySqlDbType.VarChar).Value = txtContact.Text;
            cmd.Parameters.Add("@po", MySqlDbType.VarChar).Value = txtPostion.Text;
            cmd.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@ps", MySqlDbType.VarChar).Value = txtPassword.Text;

            con.connectDB.Open();
            if(txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ACCOUNT CREATED");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }

            
            }
            else
            {
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                MessageBox.Show("PASSWORD IS NOT RIGH.\n ENTER AGAIN");
            }
            con.connectDB.Close();
        }

        public Boolean checkUsername()
        {

            return false;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            /*String fname = txtFirstName.Text;
            if(fname.Equals("first"))*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }
    }
}
