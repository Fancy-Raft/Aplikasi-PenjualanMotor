using MySql.Data.MySqlClient;
using Pemrograman_1214078.controller;
using Pemrograman_1214078.view;
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

namespace Pemrograman_1214078
{
    public partial class FormLogin : Form
    {
        /*private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conn;*/

        CekLogin login = new CekLogin();

        public FormLogin()
        {
            /*server = "localhost";
            database = "tbpemrograman";
            uid = "root";
            password = "";

            string connString;
            connString = "Server=localhost;Database=tbpemrograman;Uid=root;Pwd=;";

            conn = new MySqlConnection(connString);*/

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        /*private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }*/

        /*public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM user WHERE username = '{user}' AND password = '{pass}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }*/

        /*public bool Register(string user, string pass)
        {
            string query = $"INSERT INTO user (id, username, password) VALUES ('', '{user}', '{pass}');";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }*/

        /*private void Registrasi_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (Register(user, pass))
            {
                //MessageBox.Show($"User {user} has been created!");
                this.Hide();
                MessageBox.Show($"User {user} berhasil dibuat !", "Berhasil", MessageBoxButtons.OK);
                FormLoginRegister panggil = new FormLoginRegister();
                panggil.Show();

            }
            else
            {
                MessageBox.Show($"User {user} gagal dibuat!");
            }
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

                bool status = login.cek_login(username, password);
                //bool status1 = login.cek_loginadmin(username, password);
                if (status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pform = new ParentForm();
                    pform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }

        /*{
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (IsLogin(user, pass))
            {
                this.Hide();
                MessageBox.Show($"Login Berhasil \rSelamat Datang {user} !", "Berhasil", MessageBoxButtons.OK);
                ParentForm panggil = new ParentForm();
                panggil.Show();

            }
            else if (user == "" && pass == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!!");
            }
            else if (user == "")
            {
                MessageBox.Show("Username tidak boleh kosong!!");
            }
            else if (pass == "")
            {
                MessageBox.Show("Password tidak boleh kosong!!");
            }
            else
            {
                MessageBox.Show("GAGAL LOGIN!!", "Gagal", MessageBoxButtons.OK);
            }
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized; 
            else
                this.WindowState = FormWindowState.Normal;
        }*/

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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

        /*private void RegisterDisini_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister newRegister = new FormRegister();
            newRegister.Show();
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAwalUtama newFormAwalUtama = new FormAwalUtama();
            newFormAwalUtama.Show();
        }
        private void FormLoginRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
