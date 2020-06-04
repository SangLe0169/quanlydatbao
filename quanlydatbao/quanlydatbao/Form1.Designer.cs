namespace quanlydatbao
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSodienthoai = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.dtNgaydat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMakhachhang = new System.Windows.Forms.ComboBox();
            this.txtSophieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.btnSửa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInphieu = new System.Windows.Forms.Button();
            this.dgPhieudatbao = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numThangKT = new System.Windows.Forms.NumericUpDown();
            this.numThangBD = new System.Windows.Forms.NumericUpDown();
            this.numSoluong = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTimtentapchi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bdPDB = new System.Windows.Forms.BindingSource(this.components);
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentapchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thangbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thangketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongiathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieudatbao)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu đặt báo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSodienthoai);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenkhachhang);
            this.groupBox1.Controls.Add(this.dtNgaydat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbMakhachhang);
            this.groupBox1.Controls.Add(this.txtSophieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt báo";
            // 
            // cmbSodienthoai
            // 
            this.cmbSodienthoai.FormattingEnabled = true;
            this.cmbSodienthoai.Location = new System.Drawing.Point(129, 78);
            this.cmbSodienthoai.Name = "cmbSodienthoai";
            this.cmbSodienthoai.Size = new System.Drawing.Size(100, 21);
            this.cmbSodienthoai.TabIndex = 15;
            this.cmbSodienthoai.SelectedIndexChanged += new System.EventHandler(this.cmbSodienthoai_SelectedIndexChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(395, 78);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(287, 20);
            this.txtDiachi.TabIndex = 11;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(395, 51);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(287, 20);
            this.txtTenkhachhang.TabIndex = 10;
            // 
            // dtNgaydat
            // 
            this.dtNgaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaydat.Location = new System.Drawing.Point(395, 25);
            this.dtNgaydat.Name = "dtNgaydat";
            this.dtNgaydat.Size = new System.Drawing.Size(112, 20);
            this.dtNgaydat.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày đặt";
            // 
            // cmbMakhachhang
            // 
            this.cmbMakhachhang.FormattingEnabled = true;
            this.cmbMakhachhang.Location = new System.Drawing.Point(129, 51);
            this.cmbMakhachhang.Name = "cmbMakhachhang";
            this.cmbMakhachhang.Size = new System.Drawing.Size(100, 21);
            this.cmbMakhachhang.TabIndex = 4;
            // 
            // txtSophieu
            // 
            this.txtSophieu.Location = new System.Drawing.Point(129, 23);
            this.txtSophieu.Name = "txtSophieu";
            this.txtSophieu.Size = new System.Drawing.Size(100, 20);
            this.txtSophieu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "VND";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(112, 49);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(100, 20);
            this.txtTongtien.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng tiền";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.Location = new System.Drawing.Point(317, 187);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(58, 23);
            this.btnKhoitao.TabIndex = 6;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = true;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // btnSửa
            // 
            this.btnSửa.Location = new System.Drawing.Point(381, 187);
            this.btnSửa.Name = "btnSửa";
            this.btnSửa.Size = new System.Drawing.Size(58, 23);
            this.btnSửa.TabIndex = 7;
            this.btnSửa.Text = "Sửa";
            this.btnSửa.UseVisualStyleBackColor = true;
            this.btnSửa.Click += new System.EventHandler(this.btnSửa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(445, 187);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(58, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(590, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Trở về";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInphieu
            // 
            this.btnInphieu.Location = new System.Drawing.Point(668, 187);
            this.btnInphieu.Name = "btnInphieu";
            this.btnInphieu.Size = new System.Drawing.Size(72, 23);
            this.btnInphieu.TabIndex = 11;
            this.btnInphieu.Text = "In phiếu";
            this.btnInphieu.UseVisualStyleBackColor = true;
            // 
            // dgPhieudatbao
            // 
            this.dgPhieudatbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieudatbao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tentapchi,
            this.Thangbatdau,
            this.Thangketthuc,
            this.Soluong,
            this.Dongiathang,
            this.Thanhtien});
            this.dgPhieudatbao.Location = new System.Drawing.Point(25, 312);
            this.dgPhieudatbao.Name = "dgPhieudatbao";
            this.dgPhieudatbao.Size = new System.Drawing.Size(737, 150);
            this.dgPhieudatbao.TabIndex = 12;
            this.dgPhieudatbao.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgPhieudatbao_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.numThangKT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numThangBD);
            this.groupBox2.Controls.Add(this.numSoluong);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbTimtentapchi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(25, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 82);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết dai bao";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(465, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numThangKT
            // 
            this.numThangKT.Location = new System.Drawing.Point(643, 24);
            this.numThangKT.Name = "numThangKT";
            this.numThangKT.Size = new System.Drawing.Size(31, 20);
            this.numThangKT.TabIndex = 20;
            // 
            // numThangBD
            // 
            this.numThangBD.Location = new System.Drawing.Point(501, 22);
            this.numThangBD.Name = "numThangBD";
            this.numThangBD.Size = new System.Drawing.Size(31, 20);
            this.numThangBD.TabIndex = 19;
            // 
            // numSoluong
            // 
            this.numSoluong.Location = new System.Drawing.Point(356, 22);
            this.numSoluong.Name = "numSoluong";
            this.numSoluong.Size = new System.Drawing.Size(31, 20);
            this.numSoluong.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(557, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tháng kết thúc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tháng bắt đầu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Số lượng";
            // 
            // cmbTimtentapchi
            // 
            this.cmbTimtentapchi.FormattingEnabled = true;
            this.cmbTimtentapchi.Location = new System.Drawing.Point(112, 16);
            this.cmbTimtentapchi.Name = "cmbTimtentapchi";
            this.cmbTimtentapchi.Size = new System.Drawing.Size(100, 21);
            this.cmbTimtentapchi.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tìm tên tạp chí";
            // 
            // bdPDB
            // 
            this.bdPDB.PositionChanged += new System.EventHandler(this.bdPDB_PositionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tentapchi
            // 
            this.Tentapchi.DataPropertyName = "TenTC";
            this.Tentapchi.HeaderText = "Tên tạp chí";
            this.Tentapchi.Name = "Tentapchi";
            // 
            // Thangbatdau
            // 
            this.Thangbatdau.DataPropertyName = "ThangBD";
            this.Thangbatdau.HeaderText = "Tháng bắt đầu";
            this.Thangbatdau.Name = "Thangbatdau";
            // 
            // Thangketthuc
            // 
            this.Thangketthuc.DataPropertyName = "ThangKT";
            this.Thangketthuc.HeaderText = "Tháng kết thúc";
            this.Thangketthuc.Name = "Thangketthuc";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SoLuong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Dongiathang
            // 
            this.Dongiathang.DataPropertyName = "DonGiaThang";
            this.Dongiathang.HeaderText = "Đơn giá tháng";
            this.Dongiathang.Name = "Dongiathang";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "ThanhTien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgPhieudatbao);
            this.Controls.Add(this.btnInphieu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSửa);
            this.Controls.Add(this.btnKhoitao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quan ly dat bao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieudatbao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.DateTimePicker dtNgaydat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMakhachhang;
        private System.Windows.Forms.TextBox txtSophieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.Button btnSửa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInphieu;
        private System.Windows.Forms.DataGridView dgPhieudatbao;
        private System.Windows.Forms.ComboBox cmbSodienthoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numThangKT;
        private System.Windows.Forms.NumericUpDown numThangBD;
        private System.Windows.Forms.NumericUpDown numSoluong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTimtentapchi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource bdPDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentapchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thangbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thangketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongiathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
    }
}

