using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zakat_fitrah
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=zakatfitrah;uid=root;pwd=; Convert Zero Datetime=true");
        private void textbok_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection koneksi = new MySqlConnection("server=localhost;database=zakatfitrah;uid=root;pwd=; Convert Zero Datetime=true");

                
                MySqlCommand cmd;

                cmd = koneksi.CreateCommand();
                koneksi.Open();
                cmd.CommandText = "SELECT * FROM admin where username=@USERNAME AND password=@PASSWORD";

                cmd.Parameters.AddWithValue("@USERNAME", textbox_username.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", textbox_password.Text);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    MessageBox.Show("Login berhasil!");
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password atau Username salah. Silahkan Cek Kembali.", "Peringatan");
                }
                cmd.Parameters.Clear();
                koneksi.Close();
            }

            catch (Exception c)
            {
                MessageBox.Show("Ups, Ada Kesalahan. \nIni Detail Errornya: \"" + c.Message + "\"", "Pesan Error");
            }
            finally
            {
                koneksi.Close();
            }

        }
    }
}
