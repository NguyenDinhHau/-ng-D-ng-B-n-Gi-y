namespace QuanLyBanGiay
{
    partial class fm_timKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_tk_xoa = new System.Windows.Forms.Button();
            this.txt_tk_timKiem = new System.Windows.Forms.Button();
            this.txt_tk_size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsv_tiemKiem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.txt_tk_xoa);
            this.groupBox1.Controls.Add(this.txt_tk_timKiem);
            this.groupBox1.Controls.Add(this.txt_tk_size);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(825, 29);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(116, 30);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_tk_xoa
            // 
            this.txt_tk_xoa.Location = new System.Drawing.Point(648, 29);
            this.txt_tk_xoa.Name = "txt_tk_xoa";
            this.txt_tk_xoa.Size = new System.Drawing.Size(143, 30);
            this.txt_tk_xoa.TabIndex = 3;
            this.txt_tk_xoa.Text = "Xóa";
            this.txt_tk_xoa.UseVisualStyleBackColor = true;
            this.txt_tk_xoa.Click += new System.EventHandler(this.txt_tk_xoa_Click);
            // 
            // txt_tk_timKiem
            // 
            this.txt_tk_timKiem.BackColor = System.Drawing.Color.Silver;
            this.txt_tk_timKiem.Location = new System.Drawing.Point(280, 32);
            this.txt_tk_timKiem.Name = "txt_tk_timKiem";
            this.txt_tk_timKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tk_timKiem.Size = new System.Drawing.Size(73, 30);
            this.txt_tk_timKiem.TabIndex = 2;
            this.txt_tk_timKiem.Text = "Tìm Kiếm";
            this.txt_tk_timKiem.UseVisualStyleBackColor = false;
            this.txt_tk_timKiem.Click += new System.EventHandler(this.txt_tk_timKiem_Click);
            // 
            // txt_tk_size
            // 
            this.txt_tk_size.Location = new System.Drawing.Point(79, 29);
            this.txt_tk_size.Multiline = true;
            this.txt_tk_size.Name = "txt_tk_size";
            this.txt_tk_size.Size = new System.Drawing.Size(181, 35);
            this.txt_tk_size.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size Giày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv_tiemKiem);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 446);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ Liệu";
            // 
            // lsv_tiemKiem
            // 
            this.lsv_tiemKiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsv_tiemKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_tiemKiem.FullRowSelect = true;
            this.lsv_tiemKiem.GridLines = true;
            this.lsv_tiemKiem.HideSelection = false;
            this.lsv_tiemKiem.Location = new System.Drawing.Point(3, 16);
            this.lsv_tiemKiem.Name = "lsv_tiemKiem";
            this.lsv_tiemKiem.Size = new System.Drawing.Size(977, 427);
            this.lsv_tiemKiem.TabIndex = 0;
            this.lsv_tiemKiem.UseCompatibleStateImageBehavior = false;
            this.lsv_tiemKiem.View = System.Windows.Forms.View.Details;
            this.lsv_tiemKiem.DoubleClick += new System.EventHandler(this.lsv_tiemKiem_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Stt";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hãng Giày";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Màu Giày";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ghi Chú";
            this.columnHeader6.Width = 240;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vị Trí";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá Bán";
            this.columnHeader8.Width = 131;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xuất Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fm_timKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_timKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.fm_timKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_tk_timKiem;
        private System.Windows.Forms.TextBox txt_tk_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_tk_xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListView lsv_tiemKiem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button button1;
    }
}