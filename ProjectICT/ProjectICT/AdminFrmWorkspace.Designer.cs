
namespace ProjectICT
{
    partial class AdminFrmWorkspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSRegi = new System.Windows.Forms.Button();
            this.btnInwardReport = new System.Windows.Forms.Button();
            this.btnSreports = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnCreBill = new System.Windows.Forms.Button();
            this.BtnCheckSto = new System.Windows.Forms.Button();
            this.btnCreOrder = new System.Windows.Forms.Button();
            this.btnPartsInward = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSRegi);
            this.panel1.Controls.Add(this.btnInwardReport);
            this.panel1.Controls.Add(this.btnSreports);
            this.panel1.Controls.Add(this.btnBin);
            this.panel1.Controls.Add(this.btnCreBill);
            this.panel1.Controls.Add(this.BtnCheckSto);
            this.panel1.Controls.Add(this.btnCreOrder);
            this.panel1.Controls.Add(this.btnPartsInward);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 496);
            this.panel1.TabIndex = 1;
            // 
            // btnSRegi
            // 
            this.btnSRegi.Location = new System.Drawing.Point(399, 77);
            this.btnSRegi.Name = "btnSRegi";
            this.btnSRegi.Size = new System.Drawing.Size(172, 47);
            this.btnSRegi.TabIndex = 9;
            this.btnSRegi.Text = "Staff Registeration";
            this.btnSRegi.UseVisualStyleBackColor = true;
            this.btnSRegi.Click += new System.EventHandler(this.btnSRegi_Click);
            // 
            // btnInwardReport
            // 
            this.btnInwardReport.Location = new System.Drawing.Point(69, 342);
            this.btnInwardReport.Name = "btnInwardReport";
            this.btnInwardReport.Size = new System.Drawing.Size(172, 44);
            this.btnInwardReport.TabIndex = 8;
            this.btnInwardReport.Text = "Inward Report";
            this.btnInwardReport.UseVisualStyleBackColor = true;
            this.btnInwardReport.Click += new System.EventHandler(this.btnInwardReport_Click);
            // 
            // btnSreports
            // 
            this.btnSreports.Location = new System.Drawing.Point(399, 247);
            this.btnSreports.Name = "btnSreports";
            this.btnSreports.Size = new System.Drawing.Size(172, 42);
            this.btnSreports.TabIndex = 7;
            this.btnSreports.Text = "Selling Report";
            this.btnSreports.UseVisualStyleBackColor = true;
            this.btnSreports.Click += new System.EventHandler(this.btnSreports_Click);
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(399, 343);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(172, 42);
            this.btnBin.TabIndex = 6;
            this.btnBin.Text = "Storage Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnCreBill
            // 
            this.btnCreBill.Location = new System.Drawing.Point(399, 158);
            this.btnCreBill.Name = "btnCreBill";
            this.btnCreBill.Size = new System.Drawing.Size(172, 47);
            this.btnCreBill.TabIndex = 5;
            this.btnCreBill.Text = "Create Bill";
            this.btnCreBill.UseVisualStyleBackColor = true;
            this.btnCreBill.Click += new System.EventHandler(this.btnCreBill_Click);
            // 
            // BtnCheckSto
            // 
            this.BtnCheckSto.Location = new System.Drawing.Point(69, 247);
            this.BtnCheckSto.Name = "BtnCheckSto";
            this.BtnCheckSto.Size = new System.Drawing.Size(172, 42);
            this.BtnCheckSto.TabIndex = 3;
            this.BtnCheckSto.Text = "Check Stock";
            this.BtnCheckSto.UseVisualStyleBackColor = true;
            this.BtnCheckSto.Click += new System.EventHandler(this.BtnCheckSto_Click);
            // 
            // btnCreOrder
            // 
            this.btnCreOrder.Location = new System.Drawing.Point(69, 163);
            this.btnCreOrder.Name = "btnCreOrder";
            this.btnCreOrder.Size = new System.Drawing.Size(172, 42);
            this.btnCreOrder.TabIndex = 2;
            this.btnCreOrder.Text = "Create Order";
            this.btnCreOrder.UseVisualStyleBackColor = true;
            this.btnCreOrder.Click += new System.EventHandler(this.btnCreOrder_Click);
            // 
            // btnPartsInward
            // 
            this.btnPartsInward.Location = new System.Drawing.Point(69, 77);
            this.btnPartsInward.Name = "btnPartsInward";
            this.btnPartsInward.Size = new System.Drawing.Size(172, 47);
            this.btnPartsInward.TabIndex = 1;
            this.btnPartsInward.Text = "Parts Inward";
            this.btnPartsInward.UseVisualStyleBackColor = true;
            this.btnPartsInward.Click += new System.EventHandler(this.btnPartsInward_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // AdminFrmWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 495);
            this.Controls.Add(this.panel1);
            this.Name = "AdminFrmWorkspace";
            this.Text = "AdminFrmWorkspace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInwardReport;
        private System.Windows.Forms.Button btnSreports;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnCreBill;
        private System.Windows.Forms.Button BtnCheckSto;
        private System.Windows.Forms.Button btnCreOrder;
        private System.Windows.Forms.Button btnPartsInward;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnSRegi;
    }
}