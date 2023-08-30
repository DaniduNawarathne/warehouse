using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectICT
{
    public partial class SellingReports : Form
    {
        public SellingReports()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminFrmWorkspace adminFrm = new AdminFrmWorkspace();
            this.Hide();
            adminFrm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPartName.Clear();
            txtPartno.Clear();
            dataGridView1.Rows.Clear();
            txtPartno.Focus();
        }
    }
}
