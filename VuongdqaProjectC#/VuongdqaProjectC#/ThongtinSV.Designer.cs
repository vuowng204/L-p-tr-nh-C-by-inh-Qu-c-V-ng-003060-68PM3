namespace VuongdqaProjectC_
{
    partial class ThongtinSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Hovaten = new System.Windows.Forms.TextBox();
            this.txb_Mssv = new System.Windows.Forms.TextBox();
            this.txb_Lop = new System.Windows.Forms.TextBox();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_Timkiem = new System.Windows.Forms.TextBox();
            this.btn_TImkiem = new System.Windows.Forms.Button();
            this.btn_QLL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "MSSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txb_Hovaten
            // 
            this.txb_Hovaten.Location = new System.Drawing.Point(18, 44);
            this.txb_Hovaten.Name = "txb_Hovaten";
            this.txb_Hovaten.Size = new System.Drawing.Size(350, 22);
            this.txb_Hovaten.TabIndex = 14;
            this.txb_Hovaten.TextChanged += new System.EventHandler(this.txb_Hovaten_TextChanged);
            // 
            // txb_Mssv
            // 
            this.txb_Mssv.Location = new System.Drawing.Point(18, 105);
            this.txb_Mssv.Name = "txb_Mssv";
            this.txb_Mssv.Size = new System.Drawing.Size(350, 22);
            this.txb_Mssv.TabIndex = 15;
            this.txb_Mssv.TextChanged += new System.EventHandler(this.txb_Mssv_TextChanged);
            // 
            // txb_Lop
            // 
            this.txb_Lop.Location = new System.Drawing.Point(18, 183);
            this.txb_Lop.Name = "txb_Lop";
            this.txb_Lop.Size = new System.Drawing.Size(350, 22);
            this.txb_Lop.TabIndex = 16;
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.Location = new System.Drawing.Point(18, 256);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(350, 22);
            this.dt_Ngaysinh.TabIndex = 17;
            this.dt_Ngaysinh.ValueChanged += new System.EventHandler(this.dt_Ngaysinh_ValueChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(18, 328);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 50);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(203, 328);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 50);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(21, 414);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Yellow;
            this.btn_Update.Location = new System.Drawing.Point(203, 414);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 50);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 397);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txb_Timkiem
            // 
            this.txb_Timkiem.Location = new System.Drawing.Point(469, 44);
            this.txb_Timkiem.Name = "txb_Timkiem";
            this.txb_Timkiem.Size = new System.Drawing.Size(489, 22);
            this.txb_Timkiem.TabIndex = 23;
            this.txb_Timkiem.TextChanged += new System.EventHandler(this.txb_Timkiem_TextChanged);
            // 
            // btn_TImkiem
            // 
            this.btn_TImkiem.Location = new System.Drawing.Point(964, 44);
            this.btn_TImkiem.Name = "btn_TImkiem";
            this.btn_TImkiem.Size = new System.Drawing.Size(81, 23);
            this.btn_TImkiem.TabIndex = 24;
            this.btn_TImkiem.Text = "ok";
            this.btn_TImkiem.UseVisualStyleBackColor = true;
            this.btn_TImkiem.Click += new System.EventHandler(this.btn_TImkiem_Click);
            // 
            // btn_QLL
            // 
            this.btn_QLL.Location = new System.Drawing.Point(1063, 42);
            this.btn_QLL.Name = "btn_QLL";
            this.btn_QLL.Size = new System.Drawing.Size(120, 23);
            this.btn_QLL.TabIndex = 25;
            this.btn_QLL.Text = "QL Lớp";
            this.btn_QLL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QLL.UseVisualStyleBackColor = true;
            this.btn_QLL.Click += new System.EventHandler(this.btn_QLL_Click);
            // 
            // ThongtinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 487);
            this.Controls.Add(this.btn_QLL);
            this.Controls.Add(this.btn_TImkiem);
            this.Controls.Add(this.txb_Timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dt_Ngaysinh);
            this.Controls.Add(this.txb_Lop);
            this.Controls.Add(this.txb_Mssv);
            this.Controls.Add(this.txb_Hovaten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongtinSV";
            this.Text = "Quản Lý Sinh vien";
            this.Load += new System.EventHandler(this.ThongtinSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Hovaten;
        private System.Windows.Forms.TextBox txb_Mssv;
        private System.Windows.Forms.TextBox txb_Lop;
        private System.Windows.Forms.DateTimePicker dt_Ngaysinh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_Timkiem;
        private System.Windows.Forms.Button btn_TImkiem;
        private System.Windows.Forms.Button btn_QLL;
    }
}

