using Pemrograman_1214078.model.datatransaksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller.datatransaksi
{
    internal class TransaksiMasuk
    {
        //Memanggil class koneksi 
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_TransaksiMasuk transmasuk)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO transaksi_masuk(supplier, jenis, tanggal, jumlah_unit, harga, total) VALUES('" + transmasuk.Supplier + "', '" +
                transmasuk.Jenis + "', '" + transmasuk.Tanggal + "', '" + transmasuk.Jumlah_unit + "', '" + transmasuk.Harga + "', '" + transmasuk.Total + "')");
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

        public bool Update(M_TransaksiMasuk transmasuk, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE transaksi_masuk SET supplier ='" + transmasuk.Supplier + "'," +
                    "jenis='" + transmasuk.Jenis + "'," + "tanggal='" + transmasuk.Tanggal + "'," +
                    "jumlah_unit='" + transmasuk.Jumlah_unit + "'," + "harga='" + transmasuk.Harga + "'," +
                    "total='" + transmasuk.Total + "' WHERE id_masuk ='" + id + "'");

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
                koneksi.ExecuteQuery("DELETE FROM transaksi_masuk WHERE id_masuk ='" + id + "'");
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
