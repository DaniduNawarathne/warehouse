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
    public partial class FrmWorkspace : Form
    {
        public FrmWorkspace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parts_inward inward = new parts_inward();
            this.Hide();
            inward.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBill formbill = new FormBill();
            formbill.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            Inwards_Report Inreport = new Inwards_Report();
            this.Hide();
            Inreport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Order crOrder = new Create_Order();
            this.Hide();
            crOrder.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StorageBin bin = new StorageBin();
            this.Hide();
            bin.Show();
        }
    }
}
