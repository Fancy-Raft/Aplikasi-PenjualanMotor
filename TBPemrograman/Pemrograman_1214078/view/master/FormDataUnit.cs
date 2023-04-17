using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.master;
using Pemrograman_1214078.model;
using Pemrograman_1214078.model.master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view.master
{
    public partial class FormDataUnit : Form
    {
        Koneksi koneksi = new Koneksi();
        M_DataUnit dataunit = new M_DataUnit();
        string id;

        public void Tampil()
        {
            /* DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/



            //QueryDB
            DataUnitt.DataSource = koneksi.ShowData("select * from t_unit");

            //Mengubah Nama Kolom Table
            DataUnitt.Columns[0].HeaderText = "ID_Unit";
            DataUnitt.Columns[1].HeaderText = "Jenis Motor";
            DataUnitt.Columns[2].HeaderText = "Jumlah Unit";
            DataUnitt.Columns[3].HeaderText = "Harga Motor";
            DataUnitt.Columns[4].HeaderText = "Tahun Produksi";
            DataUnitt.Columns[5].HeaderText = "Kondisi Motor";

        }

        public FormDataUnit()
        {         
            InitializeComponent();
        }

        private void FormDataUnit_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbJenisMotor.SelectedIndex = -1;
            tbJumlahUnit.Text = "";
            tbHargaMotor.Text = "";
            tbTahunProduksi.Text = "";
            cbKondisiMotor.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbJenisMotor.SelectedIndex == -1 ||  tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTahunProduksi.Text == "" || cbKondisiMotor.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataUnit dataunitt = new DataUnit();
                dataunit.Jenis = tbJenisMotor.Text;
                dataunit.Jumlah_unit = tbJumlahUnit.Text;
                dataunit.Harga = tbHargaMotor.Text;
                dataunit.Tahun_produksi = tbTahunProduksi.Text;
                dataunit.Kondisi = cbKondisiMotor.Text;

                dataunitt.Insert(dataunit);

                tbJenisMotor.SelectedIndex = -1;
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTahunProduksi.Text = "";
                cbKondisiMotor.SelectedIndex = -1;


                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbJenisMotor.SelectedIndex == -1 ||  tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTahunProduksi.Text == "" || cbKondisiMotor.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataUnit dataunitt = new DataUnit();
                dataunit.Jenis = tbJenisMotor.Text;
                dataunit.Jumlah_unit = tbJumlahUnit.Text;
                dataunit.Harga = tbHargaMotor.Text;
                dataunit.Tahun_produksi = tbTahunProduksi.Text;
                dataunit.Kondisi = cbKondisiMotor.Text;

                dataunitt.Update(dataunit, id);

                tbJenisMotor.SelectedIndex = -1;
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTahunProduksi.Text = "";
                cbKondisiMotor.SelectedIndex = -1;


                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                DataUnit dataunit = new DataUnit();
                dataunit.Delete(id);
                Tampil();
            }
        }

        private void DataUnitt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataUnitt.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbJenisMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbJumlahUnit.Text = DataUnitt.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbTahunProduksi.Text = DataUnitt.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbKondisiMotor.Text = DataUnitt.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataUnitt.DataSource = koneksi.ShowData("SELECT * FROM t_unit WHERE id_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jumlah_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR harga LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR tahun_produksi LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR kondisi LIKE '%' '" + tbCariData.Text + "' '%' ");
        }
    }
}
