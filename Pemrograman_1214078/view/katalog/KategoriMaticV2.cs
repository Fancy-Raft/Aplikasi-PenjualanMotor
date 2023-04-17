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
    public partial class KategoriMaticV2 : Form
    {
        public KategoriMaticV2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tombolback
            this.Hide();
            KategoriMatic newMatic = new KategoriMatic();
            newMatic.Show();
        }

        

        private void KategoriMaticV2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
