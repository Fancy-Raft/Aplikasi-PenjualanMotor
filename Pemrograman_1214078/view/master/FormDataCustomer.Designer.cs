namespace Pemrograman_1214078.view
{
    partial class FormDataCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataCustomer));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.TabelDataCustomer = new System.Windows.Forms.GroupBox();
            this.DataCustomer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.labelCariData = new System.Windows.Forms.Label();
            this.tbNOHP = new System.Windows.Forms.TextBox();
            this.dtTANGGALPEMBELIAN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKTP = new System.Windows.Forms.TextBox();
            this.tbNamaCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbJenismotor = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.TabelDataCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(28, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(623, 74);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
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
            // TabelDataCustomer
            // 
            this.TabelDataCustomer.Controls.Add(this.DataCustomer);
            this.TabelDataCustomer.Location = new System.Drawing.Point(28, 377);
            this.TabelDataCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.TabelDataCustomer.Name = "TabelDataCustomer";
            this.TabelDataCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.TabelDataCustomer.Size = new System.Drawing.Size(1501, 433);
            this.TabelDataCustomer.TabIndex = 27;
            this.TabelDataCustomer.TabStop = false;
            this.TabelDataCustomer.Text = "Tabel Data Customer";
            // 
            // DataCustomer
            // 
            this.DataCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCustomer.Location = new System.Drawing.Point(8, 31);
            this.DataCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DataCustomer.Name = "DataCustomer";
            this.DataCustomer.RowHeadersWidth = 51;
            this.DataCustomer.Size = new System.Drawing.Size(1475, 385);
            this.DataCustomer.TabIndex = 0;
            this.DataCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCustomer_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 33);
            this.label7.TabIndex = 40;
            this.label7.Text = "DATA CUSTOMER";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(871, 302);
            this.tbCariData.Margin = new System.Windows.Forms.Padding(5);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(347, 22);
            this.tbCariData.TabIndex = 44;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // labelCariData
            // 
            this.labelCariData.AutoSize = true;
            this.labelCariData.Location = new System.Drawing.Point(775, 305);
            this.labelCariData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCariData.Name = "labelCariData";
            this.labelCariData.Size = new System.Drawing.Size(60, 16);
            this.labelCariData.TabIndex = 43;
            this.labelCariData.Text = "CariData";
            // 
            // tbNOHP
            // 
            this.tbNOHP.Location = new System.Drawing.Point(763, 156);
            this.tbNOHP.Margin = new System.Windows.Forms.Padding(5);
            this.tbNOHP.Name = "tbNOHP";
            this.tbNOHP.Size = new System.Drawing.Size(347, 22);
            this.tbNOHP.TabIndex = 58;
            // 
            // dtTANGGALPEMBELIAN
            // 
            this.dtTANGGALPEMBELIAN.Location = new System.Drawing.Point(763, 219);
            this.dtTANGGALPEMBELIAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTANGGALPEMBELIAN.Name = "dtTANGGALPEMBELIAN";
            this.dtTANGGALPEMBELIAN.Size = new System.Drawing.Size(347, 22);
            this.dtTANGGALPEMBELIAN.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tanggal Pembelian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Jenis Motor Yang Dibeli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Nomor HP";
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(169, 212);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(5);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(347, 22);
            this.tbAlamat.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Alamat";
            // 
            // tbKTP
            // 
            this.tbKTP.Location = new System.Drawing.Point(169, 156);
            this.tbKTP.Margin = new System.Windows.Forms.Padding(5);
            this.tbKTP.Name = "tbKTP";
            this.tbKTP.Size = new System.Drawing.Size(347, 22);
            this.tbKTP.TabIndex = 49;
            // 
            // tbNamaCustomer
            // 
            this.tbNamaCustomer.Location = new System.Drawing.Point(169, 103);
            this.tbNamaCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.tbNamaCustomer.Name = "tbNamaCustomer";
            this.tbNamaCustomer.Size = new System.Drawing.Size(347, 22);
            this.tbNamaCustomer.TabIndex = 50;
            this.tbNamaCustomer.TextChanged += new System.EventHandler(this.tbNamaCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nama Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nomor KTP";
            // 
            // cbJenismotor
            // 
            this.cbJenismotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJenismotor.FormattingEnabled = true;
            this.cbJenismotor.Items.AddRange(new object[] {
            "Matic",
            "Gigi",
            "Sport"});
            this.cbJenismotor.Location = new System.Drawing.Point(763, 103);
            this.cbJenismotor.Name = "cbJenismotor";
            this.cbJenismotor.Size = new System.Drawing.Size(347, 24);
            this.cbJenismotor.TabIndex = 59;
            // 
            // FormDataCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(157)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1545, 847);
            this.Controls.Add(this.cbJenismotor);
            this.Controls.Add(this.tbNOHP);
            this.Controls.Add(this.dtTANGGALPEMBELIAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKTP);
            this.Controls.Add(this.tbNamaCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCariData);
            this.Controls.Add(this.labelCariData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TabelDataCustomer);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataCustomer";
            this.Text = "FormDataCustomer";
            this.Load += new System.EventHandler(this.FormDataCustomer_Load);
            this.groupBox3.ResumeLayout(false);
            this.TabelDataCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.GroupBox TabelDataCustomer;
        private System.Windows.Forms.DataGridView DataCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.Label labelCariData;
        private System.Windows.Forms.TextBox tbNOHP;
        private System.Windows.Forms.DateTimePicker dtTANGGALPEMBELIAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKTP;
        private System.Windows.Forms.TextBox tbNamaCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbJenismotor;
    }
}