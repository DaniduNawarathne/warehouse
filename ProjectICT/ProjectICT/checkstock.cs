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
    public partial class checkstock : Form
    {
        ClassDBConnect con = new ClassDBConnect();
        public checkstock()
        {
           /* InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Part No";
            dataGridView1.Columns[1].Name = "Part Name";
            dataGridView1.Columns[2].Name = "qty";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.connectDB.Open();
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "SELECT * FROM `parts_catogorie` WHERE 1";
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.connectDB.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }
    }
}
