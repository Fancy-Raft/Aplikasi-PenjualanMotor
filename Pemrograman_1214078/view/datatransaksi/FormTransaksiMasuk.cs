using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.datatransaksi;
using Pemrograman_1214078.model.datatransaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view.datatransaksi
{
    public partial class FormTransaksiMasuk : Form
    {
        Koneksi koneksi = new Koneksi();
        M_TransaksiMasuk transmasukkk = new M_TransaksiMasuk();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/


            //QueryDB
            DataTransaksiMasuk.DataSource = koneksi.ShowData("select * from transaksi_masuk");

            //Mengubah Nama Kolom Table
            DataTransaksiMasuk.Columns[0].HeaderText = "ID_Masuk";
            DataTransaksiMasuk.Columns[1].HeaderText = "Supplier";
            DataTransaksiMasuk.Columns[2].HeaderText = "Merk";
            DataTransaksiMasuk.Columns[3].HeaderText = "Tanggal";
            DataTransaksiMasuk.Columns[4].HeaderText = "Jumlah Unit";
            DataTransaksiMasuk.Columns[5].HeaderText = "Harga";
            DataTransaksiMasuk.Columns[6].HeaderText = "Total";
            
        }

        public FormTransaksiMasuk()
        {
            InitializeComponent();
        }

        private void FormTransaksiMasuk_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSupplier.Text = "";
            cbJenisMotor.SelectedIndex = -1;
            dtTanggalMasuk.Text = "";
            tbJumlahUnit.Text = "";
            tbHargaMotor.Text = "";
            tbTotal.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbSupplier.Text == "" || cbJenisMotor.SelectedIndex == -1 || dtTanggalMasuk.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTotal.Text ==  "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiMasuk transmasukk = new TransaksiMasuk();
                transmasukkk.Supplier = tbSupplier.Text;
                transmasukkk.Jenis = cbJenisMotor.Text;
                transmasukkk.Tanggal = dtTanggalMasuk.Text;
                transmasukkk.Jumlah_unit = tbJumlahUnit.Text;
                transmasukkk.Harga = tbHargaMotor.Text;
                transmasukkk.Total = tbTotal.Text;

                //string nama_customer, jenis, tanggal, kondisi, pegawai_menangani, jumlah_unit, harga, total;

                transmasukk.Insert(transmasukkk);

                tbSupplier.Text = "";
                cbJenisMotor.SelectedIndex = -1;
                dtTanggalMasuk.Text = "";
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTotal.Text = "";

                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbSupplier.Text == "" || cbJenisMotor.SelectedIndex == -1 || dtTanggalMasuk.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiMasuk transmasukk = new TransaksiMasuk();
                transmasukkk.Supplier = tbSupplier.Text;
                transmasukkk.Jenis = cbJenisMotor.Text;
                transmasukkk.Tanggal = dtTanggalMasuk.Text;
                transmasukkk.Jumlah_unit = tbJumlahUnit.Text;
                transmasukkk.Harga = tbHargaMotor.Text;
                transmasukkk.Total = tbTotal.Text;

                //string nama_customer, jenis, tanggal, kondisi, pegawai_menangani, jumlah_unit, harga, total;

                transmasukk.Update(transmasukkk, id);

                tbSupplier.Text = "";
                cbJenisMotor.SelectedIndex = -1;
                dtTanggalMasuk.Text = "";
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTotal.Text = "";

                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah Yakin Ingin Menghapus?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                TransaksiMasuk transmasuk = new TransaksiMasuk();
                transmasuk.Delete(id);
                Tampil();
            }
        }

        private void DataTransaksiMasuk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTransaksiMasuk.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbSupplier.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbJenisMotor.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtTanggalMasuk.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbHargaMotor.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbJumlahUnit.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbTotal.Text = DataTransaksiMasuk.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            //Query DB Search Data
            DataTransaksiMasuk.DataSource = koneksi.ShowData("SELECT * FROM transaksi_masuk WHERE id_masuk LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR supplier LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR tanggal LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jumlah_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR harga LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR total LIKE '%' '" + tbCariData.Text + "' '%' ");
        }

        //private void tbJumlahUnit_TextChanged(object sender, EventArgs e)
        

        private void tbJumlahUnit_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (tbJumlahUnit.Text != "")
                {
                    try
                    {
                        tbTotal.Text = (float.Parse(tbJumlahUnit.Text) * float.Parse(tbHargaMotor.Text)).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbTotal.Text = "";
                    }
                }
                else
                {
                    tbTotal.Text = "";
                }
            }
        }
    }
}
