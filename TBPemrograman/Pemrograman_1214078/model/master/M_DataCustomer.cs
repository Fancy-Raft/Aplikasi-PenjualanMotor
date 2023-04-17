using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model
{
    internal class M_DataCustomer
    {
        string nama_customer, nomor_ktp, alamat, jenis_motor, nomor_hp, tanggal_pembelian;

        public M_DataCustomer()
        {

        }

        public M_DataCustomer(string nama_customer, string nomor_ktp, string alamat, string jenis_motor, string nomor_hp, string tanggal_pembelian)
        {
            this.Nama_customer = nama_customer;
            this.Nomor_ktp = nomor_ktp;
            this.Alamat = alamat;
            this.Jenis_motor = jenis_motor;
            this.Nomor_hp = nomor_hp;
            this.Tanggal_pembelian = tanggal_pembelian;
        }

        public string Nama_customer { get => nama_customer; set => nama_customer = value; }
        public string Nomor_ktp { get => nomor_ktp; set => nomor_ktp = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Jenis_motor { get => jenis_motor; set => jenis_motor = value; }
        public string Nomor_hp { get => nomor_hp; set => nomor_hp = value; }
        public string Tanggal_pembelian { get => tanggal_pembelian; set => tanggal_pembelian = value; }
    }
}
