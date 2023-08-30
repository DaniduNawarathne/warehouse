
namespace ProjectICT
{
    partial class checkstock
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartno = new System.Windows.Forms.TextBox();
            this.txtPartname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(473, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Name";
            // 
            // txtPartno
            // 
            this.txtPartno.Location = new System.Drawing.Point(68, 61);
            this.txtPartno.Name = "txtPartno";
            this.txtPartno.Size = new System.Drawing.Size(79, 20);
            this.txtPartno.TabIndex = 3;
            // 
            // txtPartname
            // 
            this.txtPartname.Location = new System.Drawing.Point(257, 63);
            this.txtPartname.Name = "txtPartname";
            this.txtPartname.Size = new System.Drawing.Size(157, 20);
            this.txtPartname.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(15, 13);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // checkstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPartname);
            this.Controls.Add(this.txtPartno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "checkstock";
            this.Text = "checkstock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartno;
        private System.Windows.Forms.TextBox txtPartname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDashboard;
    }
}