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
    public partial class laporan : Form
    {
        public laporan()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void laporan_Load(object sender, EventArgs e)
        {

        }

        private void laporan_transaksi_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.open();

                string query = @"
            SELECT 
                transaksi_id, 
                employee_id, 
                status, 
                diskon_id, 
                queue, 
                time_ordered
            FROM 
                transaksi
            WHERE 
                status = 'gagal'";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }
        }

        private void selled_menu_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Buka koneksi ke database
                Connection.open();

                // Query SQL untuk mengambil data menu
                string query = @"
            SELECT 
                id_menu, 
                nama_menu, 
                quantity, 
                kategori
            FROM 
                menu";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }
        }

        private void laporan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.open();

                string query = @"
            SELECT 
                transaksi_id, 
                employee_id, 
                status, 
                diskon_id, 
                queue, 
                time_ordered
            FROM 
                transaksi
            WHERE 
                status = 'berhasil'";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }
        }

        private void checklog_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.open();

                string query = @"
            SELECT 
                c.log_id, 
                c.crew_id, 
                k.nama AS crew_name, 
                IFNULL(c.start_time, 'N/A') AS start_time, 
                IFNULL(c.end_time, 'N/A') AS end_time
            FROM 
                checklog c
            INNER JOIN 
                karyawan k 
            ON 
                c.crew_id = k.crew_id";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }
        }

        private void best_seller_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
