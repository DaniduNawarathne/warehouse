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
    public partial class AdminFrmWorkspace : Form
    {
        public AdminFrmWorkspace()
        {
            InitializeComponent();
        }
     

    

        private void btnPartsInward_Click(object sender, EventArgs e)
        {
            FormPartsInward inward = new FormPartsInward();
            this.Hide();
            inward.Show();
        }

        private void btnSRegi_Click(object sender, EventArgs e)
        {
            FormStaffRegisteration registeration = new FormStaffRegisteration();
            this.Hide();
            registeration.Show();
        }

        private void btnCreOrder_Click(object sender, EventArgs e)
        {
                Create_Order crOrder = new Create_Order();
                this.Hide();
                crOrder.Show();
            }

        private void btnCreBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBill formbill = new FormBill();
            formbill.Show();
        }

        private void BtnCheckSto_Click(object sender, EventArgs e)
        {
            checkstock checkstock = new checkstock();
            this.Hide();
            checkstock.Show();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
                StorageBin bin = new StorageBin();
                this.Hide();
                bin.Show();
            
        }

        private void btnPartsIssue_Click(object sender, EventArgs e)
        {
            parts_inward Issuements = new parts_inward();
            this.Hide();
            Issuements.Show();
        }

        private void btnSreports_Click(object sender, EventArgs e)
        {
            SellingReports Sreport = new SellingReports();
            this.Hide();
            Sreport.Show();
        }

        private void btnInwardReport_Click(object sender, EventArgs e)
        {
            Inwards_Report Inreport = new Inwards_Report();
            this.Hide();
            Inreport.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    }
}

