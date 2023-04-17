namespace Pemrograman_1214078.view.datatransaksi
{
    partial class FormTransaksiMasuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiMasuk));
            this.tbHargaMotor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.DataTransaksiMasuk = new System.Windows.Forms.DataGridView();
            this.TabelDataTransaksi = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.labelCariData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.cbJenisMotor = new System.Windows.Forms.ComboBox();
            this.tbJumlahUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiMasuk)).BeginInit();
            this.TabelDataTransaksi.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHargaMotor
            // 
            this.tbHargaMotor.Location = new System.Drawing.Point(757, 102);
            this.tbHargaMotor.Margin = new System.Windows.Forms.Padding(5);
            this.tbHargaMotor.Name = "tbHargaMotor";
            this.tbHargaMotor.Size = new System.Drawing.Size(347, 22);
            this.tbHargaMotor.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 70;
            this.label5.Text = "Jumlah Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Harga Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tanggal Masuk";
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(163, 103);
            this.tbSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(347, 22);
            this.tbSupplier.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 65;
            this.label2.Text = "Jenis Motor Yang Disuppy";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(865, 303);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(347, 22);
            this.tbCariData.TabIndex = 63;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // DataTransaksiMasuk
            // 
            this.DataTransaksiMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTransaksiMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiMasuk.Location = new System.Drawing.Point(8, 31);
            this.DataTransaksiMasuk.Margin = new System.Windows.Forms.Padding(4);
            this.DataTransaksiMasuk.Name = "DataTransaksiMasuk";
            this.DataTransaksiMasuk.RowHeadersWidth = 51;
            this.DataTransaksiMasuk.Size = new System.Drawing.Size(1475, 385);
            this.DataTransaksiMasuk.TabIndex = 0;
            this.DataTransaksiMasuk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiMasuk_CellClick);
            // 
            // TabelDataTransaksi
            // 
            this.TabelDataTransaksi.Controls.Add(this.DataTransaksiMasuk);
            this.TabelDataTransaksi.Location = new System.Drawing.Point(21, 378);
            this.TabelDataTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.TabelDataTransaksi.Name = "TabelDataTransaksi";
            this.TabelDataTransaksi.Padding = new System.Windows.Forms.Padding(4);
            this.TabelDataTransaksi.Size = new System.Drawing.Size(1501, 433);
            this.TabelDataTransaksi.TabIndex = 60;
            this.TabelDataTransaksi.TabStop = false;
            this.TabelDataTransaksi.Text = "Tabel Data Transaksi Masuk";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(467, 26);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
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
            this.btnUbah.Margin = new System.Windows.Forms.Padding(5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(141, 34);
            this.btnUbah.TabIndex = 16;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // labelCariData
            // 
            this.labelCariData.AutoSize = true;
            this.labelCariData.Location = new System.Drawing.Point(769, 306);
            this.labelCariData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCariData.Name = "labelCariData";
            this.labelCariData.Size = new System.Drawing.Size(63, 16);
            this.labelCariData.TabIndex = 62;
            this.labelCariData.Text = "Cari Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 33);
            this.label7.TabIndex = 61;
            this.label7.Text = "TRANSAKSI MASUK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(21, 271);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(623, 74);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // dtTanggalMasuk
            // 
            this.dtTanggalMasuk.Location = new System.Drawing.Point(163, 215);
            this.dtTanggalMasuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTanggalMasuk.Name = "dtTanggalMasuk";
            this.dtTanggalMasuk.Size = new System.Drawing.Size(347, 22);
            this.dtTanggalMasuk.TabIndex = 76;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(757, 220);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(5);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(347, 22);
            this.tbTotal.TabIndex = 77;
            // 
            // cbJenisMotor
            // 
            this.cbJenisMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenisMotor.FormattingEnabled = true;
            this.cbJenisMotor.Items.AddRange(new object[] {
            "Matic",
            "Gigi",
            "Sport"});
            this.cbJenisMotor.Location = new System.Drawing.Point(163, 155);
            this.cbJenisMotor.Name = "cbJenisMotor";
            this.cbJenisMotor.Size = new System.Drawing.Size(347, 24);
            this.cbJenisMotor.TabIndex = 78;
            // 
            // tbJumlahUnit
            // 
            this.tbJumlahUnit.Location = new System.Drawing.Point(757, 160);
            this.tbJumlahUnit.Margin = new System.Windows.Forms.Padding(5);
            this.tbJumlahUnit.Name = "tbJumlahUnit";
            this.tbJumlahUnit.Size = new System.Drawing.Size(347, 22);
            this.tbJumlahUnit.TabIndex = 79;
            this.tbJumlahUnit.TextChanged += new System.EventHandler(this.tbJumlahUnit_TextChanged_1);
            // 
            // FormTransaksiMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.tbJumlahUnit);
            this.Controls.Add(this.cbJenisMotor);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.dtTanggalMasuk);
            this.Controls.Add(this.tbHargaMotor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.TabelDataTransaksi);
            this.Controls.Add(this.labelCariData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTransaksiMasuk";
            this.Text = "FormTransaksiMasuk";
            this.Load += new System.EventHandler(this.FormTransaksiMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiMasuk)).EndInit();
            this.TabelDataTransaksi.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHargaMotor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.DataGridView DataTransaksiMasuk;
        private System.Windows.Forms.GroupBox TabelDataTransaksi;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label labelCariData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtTanggalMasuk;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ComboBox cbJenisMotor;
        private System.Windows.Forms.TextBox tbJumlahUnit;
    }
}