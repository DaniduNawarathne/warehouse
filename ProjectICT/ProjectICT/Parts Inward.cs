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
    public partial class parts_inward : Form
    {
        ClassDBConnect con = new ClassDBConnect();
        public parts_inward()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.connectDB.CreateCommand();
            cmd.CommandText = "INSERT INTO `parts_catogorie`(`PartNo`, `Part_Name`, `added_date`, `added_by`) VALUES ('@partNo','@partname','@added_date','@added_by')";

            cmd.Parameters.Add("@partNo", MySqlDbType.VarChar).Value = txtParts_no.Text;
            cmd.Parameters.Add("@partname", MySqlDbType.VarChar).Value = txtPartname.Text;
            cmd.Parameters.Add("@added_date", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@added_by", MySqlDbType.VarChar).Value = txtAddedby.Text;
        }
    }
}
