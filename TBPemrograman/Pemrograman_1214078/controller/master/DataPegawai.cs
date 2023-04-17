using Pemrograman_1214078.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller
{
    internal class DataPegawai
    {
        //Memanggil class koneksi 
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_DataPegawai data_pegawai)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_pegawai(nama_pegawai, jabatan, alamat, jenis_kelamin, umur, nohp) VALUES('" + data_pegawai.Nama_pegawai + "', '" +
                data_pegawai.Jabatan + "', '" + data_pegawai.Alamat + "', '" + data_pegawai.Jenis_kelamin + "', '" + data_pegawai.Umur + "', '" + data_pegawai.Nohp + "')");
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

        public bool Update(M_DataPegawai data_pegawai, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_pegawai SET nama_pegawai ='" + data_pegawai.Nama_pegawai + "'," +
                    "jabatan='" + data_pegawai.Jabatan + "'," + "alamat='" + data_pegawai.Alamat + "'," +
                    "jenis_kelamin='" + data_pegawai.Jenis_kelamin + "'," + "umur='" + data_pegawai.Umur + "'," +
                    "nohp='" + data_pegawai.Nohp + "' WHERE id_pegawai ='" + id + "'");
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
                koneksi.ExecuteQuery("DELETE FROM t_pegawai WHERE id_pegawai ='" + id + "'");
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
