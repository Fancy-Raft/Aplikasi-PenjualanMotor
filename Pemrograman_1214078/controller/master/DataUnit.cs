using Pemrograman_1214078.model;
using Pemrograman_1214078.model.master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller.master
{
    internal class DataUnit
    {
        //Memanggil class koneksi 
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_DataUnit data_unit)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_unit(jenis, jumlah_unit, harga, tahun_produksi, kondisi) VALUES('" + data_unit.Jenis +  "', '" + data_unit.Jumlah_unit + "', '" + data_unit.Harga + "', '" + data_unit.Tahun_produksi + "', '" + data_unit.Kondisi + "')");
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

        public bool Update(M_DataUnit data_unit, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_unit SET jenis ='" + data_unit.Jenis +  "'," + "jumlah_unit='" + data_unit.Jumlah_unit + "'," +
                    "harga='" + data_unit.Harga + "'," + "tahun_produksi='" + data_unit.Tahun_produksi + "'," +
                    "kondisi='" + data_unit.Kondisi + "' WHERE id_unit ='" + id + "'");
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
                koneksi.ExecuteQuery("DELETE FROM t_unit WHERE id_unit ='" + id + "'");
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
