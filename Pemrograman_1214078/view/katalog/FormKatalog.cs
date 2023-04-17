using Pemrograman_1214078.view.katalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view
{
    public partial class FormKatalog : Form
    {
        public FormKatalog()
        {
            InitializeComponent();
        }

        private void kembaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAwalUtama newFormUtama = new FormAwalUtama();
            newFormUtama.ShowDialog();
        }

        private void maticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriMatic newKategoriMatic = new KategoriMatic();
            //newTransaksiPenjualan.MdiParent = this;
            newKategoriMatic.ShowDialog();
        }

        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestSeller newBestSeller = new BestSeller();
            //newTransaksiPenjualan.MdiParent = this;
            newBestSeller.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Promo newpromo = new Promo();
            //newTransaksiPenjualan.MdiParent = this;
            newpromo.ShowDialog();
        }

        private void gigiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriGigi newGigi = new KategoriGigi();
            //newTransaksiPenjualan.MdiParent = this;
            newGigi.ShowDialog();
        }

        private void koplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriSport newKopling = new KategoriSport();
            //newTransaksiPenjualan.MdiParent = this;
            newKopling.ShowDialog();
        }

       

        private void FormKatalog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
