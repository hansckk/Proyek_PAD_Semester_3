using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Proyek_PAD
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            textBox2.Enabled = false;
        }
        


        private void Form7_Load(object sender, EventArgs e)
        {
            LoadPaymentMethods();
        }

        private void LoadPaymentMethods()
        {
            try
            {
                Connection.open();

                string query = "SELECT nama_payment FROM payment_method";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["nama_payment"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment methods: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kembali ke Form customer
            customer customerForm = new customer();
            customerForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hapus inputan kecuali textBox2
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tambahkan logika lain jika diperlukan, misalnya konfirmasi pembayaran.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
