using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model.master
{
    internal class M_DataUnit
    {
        string jenis, jumlah_unit, harga, tahun_produksi, kondisi;

        public M_DataUnit()
        {

        }

        public M_DataUnit(string jenis, string jumlah_unit, string harga, string tahun_produksi, string kondisi)
        {
            this.Jenis = jenis;
            this.Jumlah_unit = jumlah_unit;
            this.Harga = harga;
            this.Tahun_produksi = tahun_produksi;
            this.Kondisi = kondisi;
        }

        public string Jenis { get => jenis; set => jenis = value; }
        public string Jumlah_unit { get => jumlah_unit; set => jumlah_unit = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Tahun_produksi { get => tahun_produksi; set => tahun_produksi = value; }
        public string Kondisi { get => kondisi; set => kondisi = value; }
    }
}
