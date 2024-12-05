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

namespace Proyek_PAD
{
    public partial class loginForm : Form
    {
        private string connectionString = "Server=localhost;Database=mcd_pad;Uid=root;Pwd=;";

        public loginForm()
        {
            InitializeComponent();
        }

        private void clear()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void checkLogin()
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string query = "SELECT COUNT(1) FROM kasir WHERE nama_kasir = @username AND password_kasir = @password";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cashier form1 = new Cashier(username);
                            clear();
                            this.Hide();
                            DialogResult res = form1.ShowDialog();
                            if(res == DialogResult.OK)
                            {
                                this.Show();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    checkLogin();
                    break;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            checkLogin();
        }
    }
}
