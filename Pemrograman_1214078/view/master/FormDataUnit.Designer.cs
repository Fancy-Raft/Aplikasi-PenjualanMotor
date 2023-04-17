namespace Pemrograman_1214078.view.master
{
    partial class FormDataUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataUnit));
            this.TabelDataUnit = new System.Windows.Forms.GroupBox();
            this.DataUnitt = new System.Windows.Forms.DataGridView();
            this.tbTahunProduksi = new System.Windows.Forms.TextBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.labelCariData = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJumlahUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbHargaMotor = new System.Windows.Forms.TextBox();
            this.tbJenisMotor = new System.Windows.Forms.ComboBox();
            this.cbKondisiMotor = new System.Windows.Forms.ComboBox();
            this.TabelDataUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUnitt)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelDataUnit
            // 
            this.TabelDataUnit.Controls.Add(this.DataUnitt);
            this.TabelDataUnit.Location = new System.Drawing.Point(24, 378);
            this.TabelDataUnit.Margin = new System.Windows.Forms.Padding(4);
            this.TabelDataUnit.Name = "TabelDataUnit";
            this.TabelDataUnit.Padding = new System.Windows.Forms.Padding(4);
            this.TabelDataUnit.Size = new System.Drawing.Size(1496, 437);
            this.TabelDataUnit.TabIndex = 81;
            this.TabelDataUnit.TabStop = false;
            this.TabelDataUnit.Text = "Tabel Data Unit";
            // 
            // DataUnitt
            // 
            this.DataUnitt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataUnitt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUnitt.Location = new System.Drawing.Point(8, 31);
            this.DataUnitt.Margin = new System.Windows.Forms.Padding(4);
            this.DataUnitt.Name = "DataUnitt";
            this.DataUnitt.RowHeadersWidth = 51;
            this.DataUnitt.Size = new System.Drawing.Size(1480, 399);
            this.DataUnitt.TabIndex = 0;
            this.DataUnitt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUnitt_CellClick);
            // 
            // tbTahunProduksi
            // 
            this.tbTahunProduksi.Location = new System.Drawing.Point(748, 159);
            this.tbTahunProduksi.Margin = new System.Windows.Forms.Padding(5);
            this.tbTahunProduksi.Name = "tbTahunProduksi";
            this.tbTahunProduksi.Size = new System.Drawing.Size(347, 22);
            this.tbTahunProduksi.TabIndex = 78;
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(866, 301);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(347, 22);
            this.tbCariData.TabIndex = 76;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // labelCariData
            // 
            this.labelCariData.AutoSize = true;
            this.labelCariData.Location = new System.Drawing.Point(770, 303);
            this.labelCariData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCariData.Name = "labelCariData";
            this.labelCariData.Size = new System.Drawing.Size(63, 16);
            this.labelCariData.TabIndex = 75;
            this.labelCariData.Text = "Cari Data";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 33);
            this.label7.TabIndex = 74;
            this.label7.Text = "DATA UNIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Kondisi Motor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Harga Motor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Tahun Produksi";
            // 
            // tbJumlahUnit
            // 
            this.tbJumlahUnit.Location = new System.Drawing.Point(168, 159);
            this.tbJumlahUnit.Margin = new System.Windows.Forms.Padding(5);
            this.tbJumlahUnit.Name = "tbJumlahUnit";
            this.tbJumlahUnit.Size = new System.Drawing.Size(347, 22);
            this.tbJumlahUnit.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Jumlah Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Jenis Motor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(24, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(623, 74);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            // 
            // tbHargaMotor
            // 
            this.tbHargaMotor.Location = new System.Drawing.Point(748, 105);
            this.tbHargaMotor.Margin = new System.Windows.Forms.Padding(5);
            this.tbHargaMotor.Name = "tbHargaMotor";
            this.tbHargaMotor.Size = new System.Drawing.Size(347, 22);
            this.tbHargaMotor.TabIndex = 82;
            // 
            // tbJenisMotor
            // 
            this.tbJenisMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbJenisMotor.FormattingEnabled = true;
            this.tbJenisMotor.Items.AddRange(new object[] {
            "Matic",
            "Gigi",
            "Sport"});
            this.tbJenisMotor.Location = new System.Drawing.Point(168, 109);
            this.tbJenisMotor.Name = "tbJenisMotor";
            this.tbJenisMotor.Size = new System.Drawing.Size(347, 24);
            this.tbJenisMotor.TabIndex = 83;
            // 
            // cbKondisiMotor
            // 
            this.cbKondisiMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKondisiMotor.FormattingEnabled = true;
            this.cbKondisiMotor.Items.AddRange(new object[] {
            "Baru",
            "Bekas"});
            this.cbKondisiMotor.Location = new System.Drawing.Point(748, 212);
            this.cbKondisiMotor.Name = "cbKondisiMotor";
            this.cbKondisiMotor.Size = new System.Drawing.Size(347, 24);
            this.cbKondisiMotor.TabIndex = 84;
            // 
            // FormDataUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1545, 847);
            this.Controls.Add(this.cbKondisiMotor);
            this.Controls.Add(this.tbJenisMotor);
            this.Controls.Add(this.tbHargaMotor);
            this.Controls.Add(this.TabelDataUnit);
            this.Controls.Add(this.tbTahunProduksi);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.labelCariData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJumlahUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataUnit";
            this.Text = "FormDataUnit";
            this.Load += new System.EventHandler(this.FormDataUnit_Load);
            this.TabelDataUnit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataUnitt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox TabelDataUnit;
        private System.Windows.Forms.DataGridView DataUnitt;
        private System.Windows.Forms.TextBox tbTahunProduksi;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label labelCariData;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJumlahUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbHargaMotor;
        private System.Windows.Forms.ComboBox tbJenisMotor;
        private System.Windows.Forms.ComboBox cbKondisiMotor;
    }
}