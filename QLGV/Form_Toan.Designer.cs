namespace QLGV
{
    partial class Form_Toan
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_DSGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiNCKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_NamHoc = new System.Windows.Forms.ComboBox();
            this.cb_DonVi = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CapBac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenGiaoVien = new System.Windows.Forms.TextBox();
            this.dtgv_Nckh = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cb2_NamHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb2_Magv = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Nckh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgv_DSGV);
            this.tabPage1.Controls.Add(this.cb_NamHoc);
            this.tabPage1.Controls.Add(this.cb_DonVi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê giáo viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đơn vị:";
            // 
            // dtgv_DSGV
            // 
            this.dtgv_DSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSGV.Location = new System.Drawing.Point(7, 68);
            this.dtgv_DSGV.Name = "dtgv_DSGV";
            this.dtgv_DSGV.Size = new System.Drawing.Size(757, 270);
            this.dtgv_DSGV.TabIndex = 2;
            this.dtgv_DSGV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_DSGV_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiNCKHToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // tảiNCKHToolStripMenuItem
            // 
            this.tảiNCKHToolStripMenuItem.Name = "tảiNCKHToolStripMenuItem";
            this.tảiNCKHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tảiNCKHToolStripMenuItem.Text = "Tải NCKH";
            this.tảiNCKHToolStripMenuItem.Click += new System.EventHandler(this.tảiNCKHToolStripMenuItem_Click);
            // 
            // cb_NamHoc
            // 
            this.cb_NamHoc.FormattingEnabled = true;
            this.cb_NamHoc.Location = new System.Drawing.Point(411, 41);
            this.cb_NamHoc.Name = "cb_NamHoc";
            this.cb_NamHoc.Size = new System.Drawing.Size(121, 21);
            this.cb_NamHoc.TabIndex = 1;
            this.cb_NamHoc.SelectedIndexChanged += new System.EventHandler(this.cb_NamHoc_SelectedIndexChanged);
            // 
            // cb_DonVi
            // 
            this.cb_DonVi.FormattingEnabled = true;
            this.cb_DonVi.Location = new System.Drawing.Point(101, 37);
            this.cb_DonVi.Name = "cb_DonVi";
            this.cb_DonVi.Size = new System.Drawing.Size(121, 21);
            this.cb_DonVi.TabIndex = 0;
            this.cb_DonVi.SelectedIndexChanged += new System.EventHandler(this.cb_DonVi_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_CapBac);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_TenGiaoVien);
            this.tabPage2.Controls.Add(this.dtgv_Nckh);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cb2_NamHoc);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cb2_Magv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê NCKH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cấp bậc";
            // 
            // txt_CapBac
            // 
            this.txt_CapBac.Location = new System.Drawing.Point(396, 79);
            this.txt_CapBac.Name = "txt_CapBac";
            this.txt_CapBac.Size = new System.Drawing.Size(121, 20);
            this.txt_CapBac.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên giáo viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_TenGiaoVien
            // 
            this.txt_TenGiaoVien.Location = new System.Drawing.Point(115, 79);
            this.txt_TenGiaoVien.Name = "txt_TenGiaoVien";
            this.txt_TenGiaoVien.Size = new System.Drawing.Size(121, 20);
            this.txt_TenGiaoVien.TabIndex = 8;
            // 
            // dtgv_Nckh
            // 
            this.dtgv_Nckh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Nckh.Location = new System.Drawing.Point(21, 115);
            this.dtgv_Nckh.Name = "dtgv_Nckh";
            this.dtgv_Nckh.Size = new System.Drawing.Size(740, 241);
            this.dtgv_Nckh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm học:";
            // 
            // cb2_NamHoc
            // 
            this.cb2_NamHoc.FormattingEnabled = true;
            this.cb2_NamHoc.Location = new System.Drawing.Point(395, 41);
            this.cb2_NamHoc.Name = "cb2_NamHoc";
            this.cb2_NamHoc.Size = new System.Drawing.Size(121, 21);
            this.cb2_NamHoc.TabIndex = 5;
            this.cb2_NamHoc.SelectedIndexChanged += new System.EventHandler(this.cb2_NamHoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã giáo viên";
            // 
            // cb2_Magv
            // 
            this.cb2_Magv.FormattingEnabled = true;
            this.cb2_Magv.Location = new System.Drawing.Point(115, 41);
            this.cb2_Magv.Name = "cb2_Magv";
            this.cb2_Magv.Size = new System.Drawing.Size(121, 21);
            this.cb2_Magv.TabIndex = 1;
            this.cb2_Magv.SelectedIndexChanged += new System.EventHandler(this.cb2_Magv_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê NCKH của đơn vị";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form_Toan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Toan";
            this.Text = "Form_Toan";
            this.Load += new System.EventHandler(this.Form_Toan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Nckh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgv_DSGV;
        private System.Windows.Forms.ComboBox cb_NamHoc;
        private System.Windows.Forms.ComboBox cb_DonVi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_Nckh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb2_NamHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb2_Magv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenGiaoVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CapBac;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiNCKHToolStripMenuItem;
    }
}