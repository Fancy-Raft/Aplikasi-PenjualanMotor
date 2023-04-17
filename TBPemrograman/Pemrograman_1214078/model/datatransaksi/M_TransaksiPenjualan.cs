using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model.datatransaksi
{
    internal class M_TransaksiPenjualan
    {
        string id_unit, id_pegawai, nama_customer, jenis, tanggal, kondisi, jumlah_unit, total;

        public M_TransaksiPenjualan()
        {

        }

        public M_TransaksiPenjualan(string id_unit, string id_pegawai, string nama_customer, string jenis, string tanggal, string kondisi, string jumlah_unit, string total)
        {
            this.Id_unit = id_unit;
            this.Id_pegawai = id_pegawai;
            this.Nama_customer = nama_customer;
            this.Jenis = jenis;
            this.Tanggal = tanggal;
            this.Kondisi = kondisi;
            this.Jumlah_unit = jumlah_unit;
            this.Total = total;
        }

        public string Id_unit { get => id_unit; set => id_unit = value; }
        public string Id_pegawai { get => id_pegawai; set => id_pegawai = value; }
        public string Nama_customer { get => nama_customer; set => nama_customer = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Kondisi { get => kondisi; set => kondisi = value; }
        public string Jumlah_unit { get => jumlah_unit; set => jumlah_unit = value; }
        public string Total { get => total; set => total = value; }
    }
}
