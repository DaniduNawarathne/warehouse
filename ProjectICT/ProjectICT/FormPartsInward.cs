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
    public partial class FormPartsInward : Form
    {
        ClassDBConnect con = new ClassDBConnect();
        public FormPartsInward()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Part Name";
            dataGridView1.Columns[1].Name = "Part No";
            dataGridView1.Columns[2].Name = "qty";
            dataGridView1.Columns[3].Name = "Date";
            dataGridView1.Columns[4].Name = "User";
            


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "INSERT INTO `parts_catogorie`(`PartNo`, `Part_Name`,`qty`, `added_date`, `added_by`) VALUES ('@partNo','@partname',`@qty`, '@added_date','@added_by')";

            cmd.Parameters.Add("@partNo", MySqlDbType.Int32).Value = txtParts_no.Text;
            cmd.Parameters.Add("@partname", MySqlDbType.VarChar).Value = txtPartname.Text;
            cmd.Parameters.Add("@qty", MySqlDbType.VarChar).Value = txtQty.Text;
            cmd.Parameters.Add("@added_date", MySqlDbType.Date).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@added_by", MySqlDbType.VarChar).Value = txtAddedby.Text;
            con.connectDB.Open();

            addRow(txtPartname.Text, txtParts_no.Text, txtQty.Text, dateTimePicker1.Text, txtAddedby.Text);
            if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save successfully!");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            con.connectDB.Close();

        }

        private void addRow(string partno, string partname, string qty, string date, string user)
        {
            String[] row = { date, partname, partno, user ,qty };
            dataGridView1.Rows.Add(row); 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPartname.Clear();
            txtParts_no.Clear();
            txtQty.Clear();
            txtAddedby.Clear();
            dataGridView1.Rows.Clear();
            txtPartname.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.connectDB.Open();
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "UPDATE `parts_catogorie` SET `PartNo`='txtParts_no.Text',`Part_Name`='txtPartname.Text',`qty`='txtQty.Text',`added_date`='dateTimePicker1.Text',`added_by`='txtAddedby.Text'+ WHERE 'PartNo' = '"+txtParts_no.Text+"'';";
            cmd.ExecuteNonQuery();
            MySqlCommand cmd_DisplayTable = con.connectDB.CreateCommand();
            cmd_DisplayTable.CommandText = "SELECT * FROM`parts_catogorie`;";

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd_DisplayTable;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.connectDB.Close();

            MessageBox.Show("Updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.connectDB.Open();
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string query = "DELETE FROM `parts_catogorie` WHERE 'PartNo'='" + txtParts_no.Text + "';";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MySqlCommand cmd_DisplayTable = con.connectDB.CreateCommand();
            cmd_DisplayTable.CommandText = "SELECT * FROM`parts_catogorie`;";

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd_DisplayTable;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.connectDB.Close();

            MessageBox.Show("Deleted successfully!");
        }
    }
}
