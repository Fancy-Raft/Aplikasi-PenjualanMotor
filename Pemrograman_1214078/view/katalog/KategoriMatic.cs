using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view.katalog
{
    public partial class KategoriMatic : Form
    {
        public KategoriMatic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tombolback
            this.Hide();
            FormKatalog newKatalog = new FormKatalog();
            newKatalog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tombolnext
            this.Hide();
            KategoriMaticV2 newMaticV2 = new KategoriMaticV2();
            newMaticV2.Show();
        }

        private void KategoriMatic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
