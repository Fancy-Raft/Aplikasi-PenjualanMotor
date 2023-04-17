using Pemrograman_1214078.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.controller
{
    internal class DataCustomer
    {
        //Memanggil class koneksi 
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_DataCustomer datacust)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_customer(nama_customer, nomor_ktp, alamat, jenis_motor, nomor_hp, tanggal_pembelian) VALUES('" + datacust.Nama_customer + "', '" +
                datacust.Nomor_ktp + "', '" + datacust.Alamat + "', '" + datacust.Jenis_motor + "', '" + datacust.Nomor_hp+ "', '" + datacust.Tanggal_pembelian + "')");
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

        public bool Update(M_DataCustomer datacust, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_customer SET nama_customer ='" + datacust.Nama_customer + "'," +
                    "nomor_ktp='" + datacust.Nomor_ktp + "'," + "alamat='" + datacust.Alamat + "'," +
                    "jenis_motor='" + datacust.Jenis_motor + "'," + "nomor_hp='" + datacust.Nomor_hp + "'," +
                    "tanggal_pembelian='" + datacust.Tanggal_pembelian + "' WHERE id_customer ='" + id + "'");
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
                koneksi.ExecuteQuery("DELETE FROM t_customer WHERE id_customer ='" + id + "'");
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
