using Pemrograman_1214078.controller;
using Pemrograman_1214078.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view
{
    public partial class FormDataCustomer : Form
    {

        Koneksi koneksi = new Koneksi();
        M_DataCustomer datacustomer = new M_DataCustomer();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/


            //QueryDB
            DataCustomer.DataSource = koneksi.ShowData("select * from t_customer");

            //Mengubah Nama Kolom Table
            DataCustomer.Columns[0].HeaderText = "ID_Customer";
            DataCustomer.Columns[1].HeaderText = "Nama_customer";
            DataCustomer.Columns[2].HeaderText = "Nomor KTP";
            DataCustomer.Columns[3].HeaderText = "Alamat";
            DataCustomer.Columns[4].HeaderText = "Jenis Motor";
            DataCustomer.Columns[5].HeaderText = "Nomor HP";
            DataCustomer.Columns[6].HeaderText = "Tanggal Pembelian";
            
        }

        public FormDataCustomer()
        {
            InitializeComponent();
        }

        private void FormDataCustomer_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaCustomer.Text == "" || tbKTP.Text == "" || tbAlamat.Text == "" || cbJenismotor.Text == "" || tbNOHP.Text == "" || dtTANGGALPEMBELIAN.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataCustomer datacstmr = new DataCustomer();
                datacustomer.Nama_customer = tbNamaCustomer.Text;
                datacustomer.Nomor_ktp = tbKTP.Text;
                datacustomer.Alamat = tbAlamat.Text;
                datacustomer.Jenis_motor = cbJenismotor.Text;
                datacustomer.Nomor_hp = tbNOHP.Text;
                datacustomer.Tanggal_pembelian = dtTANGGALPEMBELIAN.Text;

                datacstmr.Insert(datacustomer);

                tbNamaCustomer.Text = "";
                tbKTP.Text = "";
                tbAlamat.Text = "";
                cbJenismotor.SelectedIndex = -1;
                tbNOHP.Text = "";
                dtTANGGALPEMBELIAN.Text = "";


                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbNamaCustomer.Text = "";
            tbKTP.Text = "";
            tbAlamat.Text = "";
            cbJenismotor.SelectedIndex = -1;
            tbNOHP.Text = "";
            dtTANGGALPEMBELIAN.Text = "";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaCustomer.Text == "" || tbKTP.Text == "" || tbAlamat.Text == "" || cbJenismotor.SelectedIndex == -1 || tbNOHP.Text == "" || dtTANGGALPEMBELIAN.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataCustomer datacstmr = new DataCustomer();
                datacustomer.Nama_customer = tbNamaCustomer.Text;
                datacustomer.Nomor_ktp = tbKTP.Text;
                datacustomer.Alamat = tbAlamat.Text;
                datacustomer.Jenis_motor = cbJenismotor.Text;
                datacustomer.Nomor_hp = tbNOHP.Text;
                datacustomer.Tanggal_pembelian = dtTANGGALPEMBELIAN.Text;

                datacstmr.Update(datacustomer, id);

                tbNamaCustomer.Text = "";
                tbKTP.Text = "";
                tbAlamat.Text = "";
                cbJenismotor.SelectedIndex = -1;
                tbNOHP.Text = "";
                dtTANGGALPEMBELIAN.Text = "";


                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                DataCustomer datacustomer = new DataCustomer();
                datacustomer.Delete(id);
                Tampil();
            }
        }

        private void DataCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaCustomer.Text = DataCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbKTP.Text = DataCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAlamat.Text = DataCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbJenismotor.Text = DataCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbNOHP.Text = DataCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtTANGGALPEMBELIAN.Text = DataCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        
        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataCustomer.DataSource = koneksi.ShowData("SELECT * FROM t_customer WHERE id_customer LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nama_customer LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nomor_ktp LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR alamat LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis_motor LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nomor_hp LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR tanggal_pembelian LIKE '%' '" + tbCariData.Text + "' '%' ");
        }

        private void tbNamaCustomer_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

