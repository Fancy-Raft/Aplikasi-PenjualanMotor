using Pemrograman_1214078.view.loginregister;
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
    public partial class FormAwalUtama : Form
    {
        public FormAwalUtama()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newLogin = new FormLogin();
            newLogin.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMe newAboutme = new FormAboutMe();
            newAboutme.MdiParent = this;
            newAboutme.Show();
        }

        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKatalog newKatalog = new FormKatalog();
            newKatalog.Show();
        }

        private void superAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperAdminLogin newSuperAdmin = new SuperAdminLogin();
            newSuperAdmin.Show();
        }

        private void FormAwalUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
