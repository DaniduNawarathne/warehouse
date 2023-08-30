using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectICT
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PJN\source\repos\ProjectICT\ProjectICT\DbSpareaprts.mdf;Integrated Security=True");
            string Querry = "select * from[Stock]";
            SqlConnection conDatabase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Querry, conDatabase);
            SqlDataReader Reader;
            try
            {
                conDatabase.Open();
                Reader = cmdDatabase.ExecuteReader();
                while(Reader.Read())
                {
                    string strn = Reader.GetString(0);
                    cmbPartname.Items.Add(strn);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWorkspace mainFrm = new FrmWorkspace();

            mainFrm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }
    }
}
