using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectICT
{
    public partial class LoginFrm : Form
    {
        ClassDBConnect con = new ClassDBConnect();

        public LoginFrm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUsername.Text;
            String pass = txtPassword.Text;
            String id = txtID.Text;

            String db_Pass;
            try
            {

                con.connectDB.Open();
                if (comboBox1.SelectedItem.ToString().Equals("Admin"))
                {
                    MySqlCommand cmd = con.connectDB.CreateCommand();
                    cmd.CommandText = "Select * from login_admin WHERE Username= '" + user + "'; ";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        db_Pass = reader["Password"].ToString();
                        if (pass.Equals(db_Pass))
                        {
                            AdminFrmWorkspace workspace = new AdminFrmWorkspace();
                            workspace.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username");
                    }
                    reader.Close();
                }
                else
                {
                    MySqlCommand cmd2 = con.connectDB.CreateCommand();
                    cmd2.CommandText = "Select * from info_employe WHERE Username= '" + user + "'; ";
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        db_Pass = reader2["Password"].ToString();
                        if (pass.Equals(db_Pass))
                        {
                            FrmWorkspace workspace2 = new FrmWorkspace();
                            workspace2.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username");
                    }
                    reader2.Close();
                }
                

                
                con.connectDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
            }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtID.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


