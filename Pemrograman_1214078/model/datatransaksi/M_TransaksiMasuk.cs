using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model.datatransaksi
{
    internal class M_TransaksiMasuk
    {
        string supplier, jenis, tanggal, jumlah_unit, harga, total;

        public M_TransaksiMasuk()
        {

        }

        public M_TransaksiMasuk(string supplier, string jenis, string tanggal, string jumlah_unit, string harga, string total)
        {
            this.Supplier = supplier;
            this.Jenis = jenis;
            this.Tanggal = tanggal;
            this.Jumlah_unit = jumlah_unit;
            this.Harga = harga;
            this.Total = total;
        }

        public string Supplier { get => supplier; set => supplier = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Jumlah_unit { get => jumlah_unit; set => jumlah_unit = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Total { get => total; set => total = value; }
    }

}
