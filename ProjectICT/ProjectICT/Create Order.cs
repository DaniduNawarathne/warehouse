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
    public partial class Create_Order : Form
    {
        ClassDBConnect con = new ClassDBConnect();
        public Create_Order()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "OrderNo";
            dataGridView1.Columns[1].Name = "Date";
            dataGridView1.Columns[2].Name = "Part No";
            dataGridView1.Columns[3].Name = "Part Name";
            dataGridView1.Columns[4].Name = "Qty";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "INSERT INTO `order_table`(`Order No`, `Date`, `Part_No`, `Part_Name`, `qty`) VALUES ('@orderNo',@date','@partno','@partname','qty')";

            cmd.Parameters.Add("@orderNO", MySqlDbType.Date).Value = txtOrderNo.Text;
            cmd.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@partno", MySqlDbType.Decimal).Value = txtPartno.Text;
            cmd.Parameters.Add("@partname", MySqlDbType.VarChar).Value = txtPartname.Text;
            cmd.Parameters.Add("qty", MySqlDbType.VarChar).Value = txtQty.Text;
            con.connectDB.Open();

            addRow(txtPartname.Text, txtPartno.Text, txtQty.Text, dateTimePicker1.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Order created successfully!");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            con.connectDB.Close();
        }

        private void addRow(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        private void addRow(string partno,string partname, string qty, string date,string user   )
        {
            String[] row = { partno, partname, qty, date,user    };
            dataGridView1.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPartname.Clear();
            txtPartno.Clear();
            txtQty.Clear();
            
            dataGridView1.Rows.Clear();
            txtPartno.Focus();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.connectDB.Open();
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "UPDATE `order_table` SET `Order No`='txtOrderNo.Text',`Date`='dateTimePicker1',`Part_No`='txtPartno.Text',`Part_Name`='txtPartname',`qty`='txtQty' WHERE `Order No`+'txtOrderNo' ";
            cmd.ExecuteNonQuery();
            MySqlCommand cmd_DisplayTable = con.connectDB.CreateCommand();
            cmd_DisplayTable.CommandText = "SELECT * FROM`order_table`;";

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
            string query = "DELETE FROM `parts_catogorie` WHERE 'PartNo'='" + txtOrderNo.Text + "';";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MySqlCommand cmd_DisplayTable = con.connectDB.CreateCommand();
            cmd_DisplayTable.CommandText = "SELECT * FROM `order_table`;";

            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd_DisplayTable;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.connectDB.Close();
        }

       
    }
}
