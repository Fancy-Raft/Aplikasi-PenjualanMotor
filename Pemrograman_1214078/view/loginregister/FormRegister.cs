using Pemrograman_1214078.controller;
using Pemrograman_1214078.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pemrograman_1214078.view
{
    public partial class FormRegister : Form
    {
        M_User user = new M_User();

        public FormRegister()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void Registrasi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || role.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CekRegister cekregistr = new CekRegister();
                user.Username = textBox1.Text;
                user.Password = textBox2.Text;
                user.Role = role.Text;


                cekregistr.cek_register(user);

                textBox1.Text = "";
                textBox2.Text = "";
                role.Text = "";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        /*private void LoginDisini_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin newLogin = new FormLogin();
            newLogin.Show();
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormRegister_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAwalUtama newFormAwalUtama = new FormAwalUtama();
            newFormAwalUtama.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
