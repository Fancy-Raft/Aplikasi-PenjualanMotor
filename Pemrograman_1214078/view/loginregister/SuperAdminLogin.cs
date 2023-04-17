using MySql.Data.MySqlClient;
using Pemrograman_1214078.controller;
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

namespace Pemrograman_1214078.view.loginregister
{
    public partial class SuperAdminLogin : Form
    {
        /*private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conn;*/
    
        CekLogin sadminlogin = new CekLogin();
        public SuperAdminLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        /*private void RegisterDisini_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister newRegister = new FormRegister();
            newRegister.Show();
        }*/

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!!");
            }
            else
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                bool status = sadminlogin.cek_loginadmin(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    FormRegister newRegister = new FormRegister();
                    newRegister.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
