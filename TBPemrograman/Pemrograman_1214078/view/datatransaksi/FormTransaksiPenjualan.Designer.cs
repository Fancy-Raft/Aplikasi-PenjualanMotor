namespace Pemrograman_1214078.view
{
    partial class FormTransaksiPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiPenjualan));
            this.tbJumlahUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.labelCariData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TabelDataTransaksi = new System.Windows.Forms.GroupBox();
            this.DataTransaksiPenjualan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTanggalPenjualan = new System.Windows.Forms.DateTimePicker();
            this.tbHargaMotor = new System.Windows.Forms.TextBox();
            this.IDunit = new System.Windows.Forms.ComboBox();
            this.cbKondisiMotor = new System.Windows.Forms.ComboBox();
            this.tbJenisMotor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbNamaPegawai = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IDpegawai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TabelDataTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiPenjualan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbJumlahUnit
            // 
            this.tbJumlahUnit.Location = new System.Drawing.Point(763, 174);
            this.tbJumlahUnit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbJumlahUnit.Name = "tbJumlahUnit";
            this.tbJumlahUnit.Size = new System.Drawing.Size(347, 22);
            this.tbJumlahUnit.TabIndex = 75;
            this.tbJumlahUnit.TextChanged += new System.EventHandler(this.tbJumlahUnit_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Harga Motor";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(597, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 70;
            this.label5.Text = "ID Pegawai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Jumlah Unit Pembelian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tanggal Transaksi";
            // 
            // tbNamaCustomer
            // 
            this.tbNamaCustomer.Location = new System.Drawing.Point(168, 68);
            this.tbNamaCustomer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNamaCustomer.Name = "tbNamaCustomer";
            this.tbNamaCustomer.Size = new System.Drawing.Size(347, 22);
            this.tbNamaCustomer.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nama Customer";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(865, 303);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(347, 22);
            this.tbCariData.TabIndex = 63;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // labelCariData
            // 
            this.labelCariData.Location = new System.Drawing.Point(769, 306);
            this.labelCariData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCariData.Name = "labelCariData";
            this.labelCariData.Size = new System.Drawing.Size(73, 19);
            this.labelCariData.TabIndex = 62;
            this.labelCariData.Text = "Cari Data ";
            this.labelCariData.Click += new System.EventHandler(this.labelCariData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(356, 33);
            this.label7.TabIndex = 61;
            this.label7.Text = "TRANSAKSI PENJUALAN";
            // 
            // TabelDataTransaksi
            // 
            this.TabelDataTransaksi.Controls.Add(this.DataTransaksiPenjualan);
            this.TabelDataTransaksi.Location = new System.Drawing.Point(21, 378);
            this.TabelDataTransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabelDataTransaksi.Name = "TabelDataTransaksi";
            this.TabelDataTransaksi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabelDataTransaksi.Size = new System.Drawing.Size(1501, 433);
            this.TabelDataTransaksi.TabIndex = 60;
            this.TabelDataTransaksi.TabStop = false;
            this.TabelDataTransaksi.Text = "Tabel Data Transaksi";
            // 
            // DataTransaksiPenjualan
            // 
            this.DataTransaksiPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiPenjualan.Location = new System.Drawing.Point(8, 31);
            this.DataTransaksiPenjualan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTransaksiPenjualan.Name = "DataTransaksiPenjualan";
            this.DataTransaksiPenjualan.RowHeadersWidth = 51;
            this.DataTransaksiPenjualan.Size = new System.Drawing.Size(1475, 385);
            this.DataTransaksiPenjualan.TabIndex = 0;
            this.DataTransaksiPenjualan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiPenjualan_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(21, 271);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(623, 74);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(467, 26);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(141, 34);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(11, 26);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 34);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(163, 26);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(141, 34);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(315, 26);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(141, 34);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "ID Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Kondisi Motor";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(763, 226);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(347, 22);
            this.tbTotal.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 79;
            this.label9.Text = "Total";
            // 
            // dtTanggalPenjualan
            // 
            this.dtTanggalPenjualan.Location = new System.Drawing.Point(168, 174);
            this.dtTanggalPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTanggalPenjualan.Name = "dtTanggalPenjualan";
            this.dtTanggalPenjualan.Size = new System.Drawing.Size(347, 22);
            this.dtTanggalPenjualan.TabIndex = 81;
            // 
            // tbHargaMotor
            // 
            this.tbHargaMotor.Location = new System.Drawing.Point(763, 123);
            this.tbHargaMotor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbHargaMotor.Name = "tbHargaMotor";
            this.tbHargaMotor.Size = new System.Drawing.Size(347, 22);
            this.tbHargaMotor.TabIndex = 81;
            // 
            // IDunit
            // 
            this.IDunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDunit.FormattingEnabled = true;
            this.IDunit.Location = new System.Drawing.Point(168, 121);
            this.IDunit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDunit.Name = "IDunit";
            this.IDunit.Size = new System.Drawing.Size(212, 24);
            this.IDunit.TabIndex = 83;
            this.IDunit.SelectedIndexChanged += new System.EventHandler(this.cbJenisMotor_SelectedIndexChanged);
            // 
            // cbKondisiMotor
            // 
            this.cbKondisiMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKondisiMotor.FormattingEnabled = true;
            this.cbKondisiMotor.Items.AddRange(new object[] {
            "Baru",
            "Bekas"});
            this.cbKondisiMotor.Location = new System.Drawing.Point(168, 226);
            this.cbKondisiMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKondisiMotor.Name = "cbKondisiMotor";
            this.cbKondisiMotor.Size = new System.Drawing.Size(347, 24);
            this.cbKondisiMotor.TabIndex = 84;
            // 
            // tbJenisMotor
            // 
            this.tbJenisMotor.Location = new System.Drawing.Point(387, 123);
            this.tbJenisMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbJenisMotor.Name = "tbJenisMotor";
            this.tbJenisMotor.Size = new System.Drawing.Size(129, 22);
            this.tbJenisMotor.TabIndex = 85;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbNamaPegawai
            // 
            this.cbNamaPegawai.Location = new System.Drawing.Point(869, 71);
            this.cbNamaPegawai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamaPegawai.Name = "cbNamaPegawai";
            this.cbNamaPegawai.Size = new System.Drawing.Size(240, 22);
            this.cbNamaPegawai.TabIndex = 88;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // IDpegawai
            // 
            this.IDpegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDpegawai.FormattingEnabled = true;
            this.IDpegawai.Location = new System.Drawing.Point(761, 68);
            this.IDpegawai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDpegawai.Name = "IDpegawai";
            this.IDpegawai.Size = new System.Drawing.Size(102, 24);
            this.IDpegawai.TabIndex = 90;
            this.IDpegawai.SelectedIndexChanged += new System.EventHandler(this.IDpegawai_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(876, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 25);
            this.label10.TabIndex = 91;
            this.label10.Text = "Pegawai Yang Menangani";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(769, 330);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 19);
            this.label11.TabIndex = 92;
            this.label11.Text = "ID Penjualan dan Nama Customer";
            // 
            // FormTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IDpegawai);
            this.Controls.Add(this.cbNamaPegawai);
            this.Controls.Add(this.tbJenisMotor);
            this.Controls.Add(this.cbKondisiMotor);
            this.Controls.Add(this.IDunit);
            this.Controls.Add(this.dtTanggalPenjualan);
            this.Controls.Add(this.tbHargaMotor);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJumlahUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamaCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.labelCariData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TabelDataTransaksi);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTransaksiPenjualan";
            this.Text = "FormTransaksiPenjualan";
            this.Load += new System.EventHandler(this.FormTransaksiPenjualan_Load);
            this.TabelDataTransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiPenjualan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJumlahUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label labelCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox TabelDataTransaksi;
        private System.Windows.Forms.DataGridView DataTransaksiPenjualan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTanggalPenjualan;
        private System.Windows.Forms.TextBox tbHargaMotor;
        private System.Windows.Forms.ComboBox IDunit;
        private System.Windows.Forms.ComboBox cbKondisiMotor;
        private System.Windows.Forms.TextBox tbJenisMotor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cbNamaPegawai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ComboBox IDpegawai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}