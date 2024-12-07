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
    public partial class Form5 : Form
    {
        private string connectionString = "Server=localhost;Database=mcd_pad;Uid=root;Pwd=;";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                // Membuat koneksi ke database MySQL
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Query untuk mengambil data dari tabel 'kasir'
                    string query = "SELECT * FROM kasir";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Menampilkan data ke dalam DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani error jika ada
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Jika Anda ingin menangani klik pada DataGridView, tambahkan kode di sini
        }
    }
}