
namespace ProjectICT
{
    partial class StorageBin
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
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPartName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPartNo);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 436);
            this.panel1.TabIndex = 11;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(308, 88);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(131, 20);
            this.txtPartName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(40, 403);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 237);
            this.dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part Name";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(15, 23);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(364, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Part No";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(116, 88);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(100, 20);
            this.txtPartNo.TabIndex = 7;
            // 
            // StorageBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StorageBin";
            this.Text = "StorageBin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartNo;
    }
}