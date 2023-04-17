using Pemrograman_1214078.model;
using Pemrograman_1214078.model.datatransaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller.datatransaksi
{
    internal class TransaksiPenjualan
    {
        //Memanggil class koneksi 
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_TransaksiPenjualan transpenjualan)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO transaksi_penjualan(id_unit, id_pegawai, nama_customer, jenis, tanggal, kondisi, jumlah_unit, total) VALUES('" + transpenjualan.Id_unit + "', '" + transpenjualan.Id_pegawai + "', '" + transpenjualan.Nama_customer + "', '" +
                transpenjualan.Jenis + "', '" + transpenjualan.Tanggal + "', '" + transpenjualan.Kondisi +  "', '" + transpenjualan.Jumlah_unit +  "', '" + transpenjualan.Total + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_TransaksiPenjualan transpenjualan, string id)
        {
 
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE transaksi_penjualan SET id_unit ='" + transpenjualan.Id_unit + "'," +
                    "id_pegawai='" + transpenjualan.Id_pegawai + "'," + "nama_customer='" + transpenjualan.Nama_customer + "'," + "jenis='" + transpenjualan.Jenis + "'," + "tanggal='" + transpenjualan.Tanggal + "'," +
                    "kondisi='" + transpenjualan.Kondisi + "'," + 
                    "jumlah_unit='" + transpenjualan.Jumlah_unit + "'," +
                    "total='" + transpenjualan.Total + "' WHERE id_penjualan ='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }


        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM transaksi_penjualan WHERE id_penjualan ='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
