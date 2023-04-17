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
    public partial class FormDataPegawai : Form
    {

        Koneksi koneksi = new Koneksi();
        M_DataPegawai datapegawai = new M_DataPegawai();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/


            //QueryDB
            DataPegawai.DataSource = koneksi.ShowData("select * from t_pegawai");

            //Mengubah Nama Kolom Table
            DataPegawai.Columns[0].HeaderText = "ID_Pegawai";
            DataPegawai.Columns[1].HeaderText = "Nama_pegawai";
            DataPegawai.Columns[2].HeaderText = "Jabatan";
            DataPegawai.Columns[3].HeaderText = "Alamat";
            DataPegawai.Columns[4].HeaderText = "Jenis Kelamin";
            DataPegawai.Columns[5].HeaderText = "Umur";
            DataPegawai.Columns[6].HeaderText = "No HP";

        }

        public FormDataPegawai()
        {
            InitializeComponent();
        }

        private void FormDataPegawai_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaPegawai.Text == "" || cbJabatan.SelectedIndex == -1 || tbAlamat.Text == "" || cbJenisKelamin.SelectedIndex == -1 || tbUmur.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataPegawai datapgwai = new DataPegawai();
                datapegawai.Nama_pegawai = tbNamaPegawai.Text;
                datapegawai.Jabatan = cbJabatan.Text;
                datapegawai.Alamat = tbAlamat.Text;
                datapegawai.Jenis_kelamin = cbJenisKelamin.Text;
                datapegawai.Umur = tbUmur.Text;
                datapegawai.Nohp = tbNoHP.Text;

                datapgwai.Insert(datapegawai);

                tbNamaPegawai.Text = "";
                cbJabatan.SelectedIndex = -1;
                tbAlamat.Text = "";
                cbJenisKelamin.SelectedIndex = -1;
                tbUmur.Text = "";
                tbNoHP.Text = "";


                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbNamaPegawai.Text = "";
            cbJabatan.SelectedIndex = -1;
            tbAlamat.Text = "";
            cbJenisKelamin.SelectedIndex = -1;
            tbUmur.Text = "";
            tbNoHP.Text = "";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaPegawai.Text == "" || cbJabatan.SelectedIndex == -1 || tbAlamat.Text == "" || cbJenisKelamin.SelectedIndex == -1 || tbUmur.Text == "" || tbNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataPegawai datapgwai = new DataPegawai();
                datapegawai.Nama_pegawai = tbNamaPegawai.Text;
                datapegawai.Jabatan = cbJabatan.Text;
                datapegawai.Alamat = tbAlamat.Text;
                datapegawai.Jenis_kelamin = cbJenisKelamin.Text;
                datapegawai.Umur = tbUmur.Text;
                datapegawai.Nohp = tbNoHP.Text;

                datapgwai.Update(datapegawai, id);

                tbNamaPegawai.Text = "";
                cbJabatan.SelectedIndex = -1;
                tbAlamat.Text = "";
                cbJenisKelamin.SelectedIndex = -1;
                tbUmur.Text = "";
                tbNoHP.Text = "";


                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                DataPegawai datapegawai = new DataPegawai();
                datapegawai.Delete(id);
                Tampil();
            }
        }

        private void DataPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataPegawai.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaPegawai.Text = DataPegawai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbJabatan.Text = DataPegawai.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAlamat.Text = DataPegawai.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbJenisKelamin.Text = DataPegawai.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbUmur.Text = DataPegawai.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbNoHP.Text = DataPegawai.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataPegawai.DataSource = koneksi.ShowData("SELECT * FROM t_pegawai WHERE id_pegawai LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nama_pegawai LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jabatan LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR alamat LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis_kelamin LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR umur LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nohp LIKE '%' '" + tbCariData.Text + "' '%' ");
        }

        private void cbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
