using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemrograman_1214078.model
{
    internal class M_DataPegawai
    {
        string nama_pegawai, jabatan, alamat, jenis_kelamin, umur, nohp;

        public M_DataPegawai()
        {

        }

        public M_DataPegawai(string nama_pegawai, string jabatan, string alamat, string jenis_kelamin, string umur, string nohp)
        {
            this.Nama_pegawai = nama_pegawai;
            this.Jabatan = jabatan;
            this.Alamat = alamat;
            this.Jenis_kelamin = jenis_kelamin;
            this.Umur = umur;
            this.Nohp = nohp;
        }

        public string Nama_pegawai { get => nama_pegawai; set => nama_pegawai = value; }
        public string Jabatan { get => jabatan; set => jabatan = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Jenis_kelamin { get => jenis_kelamin; set => jenis_kelamin = value; }
        public string Umur { get => umur; set => umur = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
