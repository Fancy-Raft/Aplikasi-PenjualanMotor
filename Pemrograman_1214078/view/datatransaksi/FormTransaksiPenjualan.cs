using MySql.Data.MySqlClient;
using Pemrograman_1214078.controller;
using Pemrograman_1214078.controller.datatransaksi;
using Pemrograman_1214078.controller.master;
using Pemrograman_1214078.model;
using Pemrograman_1214078.model.datatransaksi;
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

namespace Pemrograman_1214078.view
{
    public partial class FormTransaksiPenjualan : Form
    {
        Koneksi koneksi = new Koneksi();
        M_TransaksiPenjualan transaksipenjualannn = new M_TransaksiPenjualan();
        M_DataPegawai datapegawai = new M_DataPegawai();
        M_DataUnit dataunit = new M_DataUnit();
        string id;

        public void Tampil()
        {
            /*
            DataBarang.DataSource = koneksi.ShowData("SELECT " + "id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " +
                "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");*/
            DataTransaksiPenjualan.DataSource = koneksi.ShowData("SELECT " + " id_penjualan, transaksi_penjualan.id_unit, transaksi_penjualan.id_pegawai, nama_customer, transaksi_penjualan.jenis, tanggal, transaksi_penjualan.kondisi, nama_pegawai, transaksi_penjualan.jumlah_unit, harga, transaksi_penjualan.total " +
                "FROM transaksi_penjualan JOIN t_pegawai ON t_pegawai.id_pegawai = transaksi_penjualan.id_pegawai JOIN t_unit ON transaksi_penjualan.id_unit = t_unit.id_unit");

            //QueryDB
            //DataTransaksiPenjualan.DataSource = koneksi.ShowData("select * from transaksi_penjualan");

                        //Mengubah Nama Kolom Table
                        DataTransaksiPenjualan.Columns[0].HeaderText = "ID_Penjualan";
                        DataTransaksiPenjualan.Columns[1].HeaderText = "ID_Unit";
                        DataTransaksiPenjualan.Columns[2].HeaderText = "ID_Pegawai";
                        DataTransaksiPenjualan.Columns[3].HeaderText = "Nama Customer";
                        DataTransaksiPenjualan.Columns[4].HeaderText = "Jenis";
                        DataTransaksiPenjualan.Columns[5].HeaderText = "Tanggal";
                        DataTransaksiPenjualan.Columns[6].HeaderText = "Kondisi";
                        DataTransaksiPenjualan.Columns[7].HeaderText = "Pegawai Yang Menangani";
                        DataTransaksiPenjualan.Columns[8].HeaderText = "Jumlah Unit";
                        DataTransaksiPenjualan.Columns[9].HeaderText = "Harga";
                        DataTransaksiPenjualan.Columns[10].HeaderText = "Total";

        }
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
        }

        public void GetDataUnit()
        {
            //ambil data ID Unit dari table (t_unit) untuk mengisi data pada combobox ID Unit
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_unit");
            while (reader.Read())
            {
                IDunit.Items.Add(reader.GetString("id_unit"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetDataPegawai()
        {
            //ambil data ID Pegawai dari table (t_pegawai) untuk mengisi data pada combobox ID Pegawai
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_pegawai");
            while (reader.Read())
            {
                IDpegawai.Items.Add(reader.GetString("id_pegawai"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        /*public void GetDataUnit()
        {
            //ambil data ID Barang dari table (t_barang) untuk mengisi data pada combobox ID Barang
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_unit");
            while (reader.Read())
            {
                tbHargaMotor.Items.Add(reader.GetString("harga"));
            }
            reader.Close();
            koneksi.CloseConnection();
        }*/

        private void FormTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataUnit();
            GetDataPegawai();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IDunit.SelectedIndex = -1;
            IDpegawai.SelectedIndex = -1;
            tbNamaCustomer.Text = "";
            tbJenisMotor.Text = "";
            dtTanggalPenjualan.Text = "";
            cbKondisiMotor.SelectedIndex = -1;
            cbNamaPegawai.Text = "";
            tbJumlahUnit.Text = "";
            tbHargaMotor.Text = "";
            tbTotal.Text = "";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaCustomer.Text == "" || IDunit.SelectedIndex == -1 || dtTanggalPenjualan.Text == "" || cbKondisiMotor.SelectedIndex == -1 || cbNamaPegawai.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiPenjualan transpenjualann = new TransaksiPenjualan();
                transaksipenjualannn.Id_unit = IDunit.Text;
                transaksipenjualannn.Id_pegawai = IDpegawai.Text;
                transaksipenjualannn.Nama_customer = tbNamaCustomer.Text;
                transaksipenjualannn.Jenis = IDunit.Text;
                transaksipenjualannn.Tanggal = dtTanggalPenjualan.Text;
                transaksipenjualannn.Kondisi = cbKondisiMotor.Text;
                datapegawai.Nama_pegawai = cbNamaPegawai.Text;
                transaksipenjualannn.Jumlah_unit = tbJumlahUnit.Text;
                dataunit.Harga = tbHargaMotor.Text;
                transaksipenjualannn.Total = tbTotal.Text;

                //string nama_customer, jenis, tanggal, kondisi, pegawai_menangani, jumlah_unit, harga, total;

                transpenjualann.Insert(transaksipenjualannn);

                IDunit.Text = "";
                IDpegawai.SelectedIndex = -1;
                tbNamaCustomer.Text = "";
                IDunit.SelectedIndex = -1;
                dtTanggalPenjualan.Text = "";
                cbKondisiMotor.SelectedIndex = -1;
                cbNamaPegawai.Text = "";
                tbJumlahUnit.Text = "";
                tbHargaMotor.Text = "";
                tbTotal.Text = "";


                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNamaCustomer.Text == "" || IDunit.SelectedIndex == -1 || dtTanggalPenjualan.Text == "" || cbKondisiMotor.SelectedIndex == -1 || cbNamaPegawai.Text == "" || tbJumlahUnit.Text == "" || tbHargaMotor.Text == "" || tbTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiPenjualan transpenjualann = new TransaksiPenjualan();
                transaksipenjualannn.Id_unit = IDunit.Text;
                transaksipenjualannn.Id_pegawai = IDpegawai.Text;
                transaksipenjualannn.Nama_customer = tbNamaCustomer.Text;
                transaksipenjualannn.Jenis = IDunit.Text;
                transaksipenjualannn.Tanggal = dtTanggalPenjualan.Text;
                transaksipenjualannn.Kondisi = cbKondisiMotor.Text;
                datapegawai.Nama_pegawai = cbNamaPegawai.Text;
                transaksipenjualannn.Jumlah_unit = tbJumlahUnit.Text;
                dataunit.Harga = tbHargaMotor.Text;
                transaksipenjualannn.Total = tbTotal.Text;

                //string nama_customer, jenis, tanggal, kondisi, pegawai_menangani, jumlah_unit, harga, total;

                transpenjualann.Update(transaksipenjualannn, id);

                IDunit.Text = "";
                IDpegawai.SelectedIndex = -1;
                tbNamaCustomer.Text = "";
                IDunit.SelectedIndex = -1;
                dtTanggalPenjualan.Text = "";
                cbKondisiMotor.SelectedIndex = -1;
                cbNamaPegawai.Text = "";
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
                TransaksiPenjualan transpenjualan = new TransaksiPenjualan();
                transpenjualan.Delete(id);
                Tampil();
            }
        }

        private void DataTransaksiPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[0].Value.ToString();
            IDunit.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDpegawai.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbNamaCustomer.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbJenisMotor.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtTanggalPenjualan.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbKondisiMotor.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbNamaPegawai.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbJumlahUnit.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbHargaMotor.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbTotal.Text = DataTransaksiPenjualan.Rows[e.RowIndex].Cells[10].Value.ToString();

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksiPenjualan.DataSource = koneksi.ShowData("SELECT id_penjualan, transaksi_penjualan.id_unit, transaksi_penjualan.id_pegawai, nama_customer, transaksi_penjualan.jenis, tanggal, transaksi_penjualan.kondisi, nama_pegawai, transaksi_penjualan.jumlah_unit, harga, transaksi_penjualan.total " +
                "FROM transaksi_penjualan JOIN t_pegawai ON t_pegawai.id_pegawai = transaksi_penjualan.id_pegawai JOIN t_unit ON transaksi_penjualan.id_unit = t_unit.id_unit WHERE id_penjualan LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nama_customer LIKE '%' '" + tbCariData.Text + "' '%' ");

            //DataTransaksiPenjualan.DataSource = koneksi.ShowData("SELECT id_penjualan, transaksi_penjualan.id_unit, transaksi_penjualan.id_pegawai, nama_customer, transaksi_penjualan.jenis, tanggal, transaksi_penjualan.kondisi, nama_pegawai, transaksi_penjualan.jumlah_unit, harga, transaksi_penjualan.total " +
            //"FROM transaksi_penjualan JOIN t_pegawai ON t_pegawai.id_pegawai = transaksi_penjualan.id_pegawai JOIN t_unit ON transaksi_penjualan.id_unit = t_unit.id_unit WHERE t_transaksi.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' ");

            //Query DB Search Data
            /*DataTransaksiPenjualan.DataSource = koneksi.ShowData("SELECT * FROM transaksi_penjualan WHERE id_penjualan LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR id_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR id_pegawai LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR nama_customer LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jenis LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR tanggal LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR kondisi LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR jumlah_unit LIKE '%' '" + tbCariData.Text + "' '%' " +
                    "OR total LIKE '%' '" + tbCariData.Text + "' '%' "); */
        }

        public void GetHargaMotor()
        {
            //ambil data HargaMotor ketika combobox ID Unit dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT harga FROM t_unit " + "WHERE id_unit = '" + IDunit.Text + "'");
            while (reader.Read())
            {
                tbHargaMotor.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
        public void GetJenisMotor()
        {
            //ambil data JenisMotor ketika combobox ID Unit dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT jenis FROM t_unit " + "WHERE id_unit = '" + IDunit.Text + "'");
            while (reader.Read())
            {
                tbJenisMotor.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void GetNamaPegawai()
        {
            //ambil data Nama Pegawai ketikan combobox ID pegawai dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama_pegawai FROM t_pegawai " + "WHERE id_pegawai = '" + IDpegawai.Text + "'");
            while (reader.Read())
            {
                cbNamaPegawai.Text = reader.GetString(0);
            }
            reader.Close();
            koneksi.CloseConnection();
        }
       

        private void tbJumlahUnit_TextChanged(object sender, EventArgs e)
        {
            if (tbJumlahUnit.Text != "")
            {
                try
                {
                    tbTotal.Text = (float.Parse(tbHargaMotor.Text) * float.Parse(tbJumlahUnit.Text)).ToString();
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

        private void cbJenisMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetHargaMotor();
            GetJenisMotor();
            

        }

        private void IDpegawai_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaPegawai();
        }

        private void labelCariData_Click(object sender, EventArgs e)
        {

        }
    }
}
