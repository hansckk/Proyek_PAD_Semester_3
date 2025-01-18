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
            button1.Visible = false;
            dateTimePicker1.Enabled = false;
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

            dateTimePicker1.Enabled = false;

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

                dataGridView1.Columns[0].HeaderText = "Transaction ID";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Status";
                dataGridView1.Columns[3].HeaderText = "Discount ID";
                dataGridView1.Columns[4].HeaderText = "Queue";
                dataGridView1.Columns[5].HeaderText = "Time Ordered";

                button1.Visible = true;
                button1.Text = "Print transaksi gagal";
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

            dateTimePicker1.Enabled = false;

            try
            {
                Connection.open();

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

                dataGridView1.Columns[0].HeaderText = "Menu ID";
                dataGridView1.Columns[1].HeaderText = "Menu Name";
                dataGridView1.Columns[2].HeaderText = "Quantity";
                dataGridView1.Columns[3].HeaderText = "Category";

                button1.Visible = true;
                button1.Text = "Print stock makanan";
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
            dateTimePicker1.Enabled = true;

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

                dataGridView1.Columns[0].HeaderText = "Transaction ID";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Status";
                dataGridView1.Columns[3].HeaderText = "Discount ID";
                dataGridView1.Columns[4].HeaderText = "Queue";
                dataGridView1.Columns[5].HeaderText = "Time Ordered";

                button1.Visible = true;
                button1.Text = "Print semua transaksi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.close();
            }

            dateTimePicker1.ValueChanged += (s, ev) =>
            {
                try
                {
                    Connection.open();

                    string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
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
                    status = 'berhasil' AND DATE(time_ordered) = @selectedDate";

                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[0].HeaderText = "Transaction ID";
                    dataGridView1.Columns[1].HeaderText = "Employee ID";
                    dataGridView1.Columns[2].HeaderText = "Status";
                    dataGridView1.Columns[3].HeaderText = "Discount ID";
                    dataGridView1.Columns[4].HeaderText = "Queue";
                    dataGridView1.Columns[5].HeaderText = "Time Ordered";

                    button1.Visible = true;
                    button1.Text = "Print transaksi harian";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connection.close();
                }
            };
        }

        private void checklog_btn_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Enabled = false;

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

                dataGridView1.Columns[0].HeaderText = "Log ID";
                dataGridView1.Columns[1].HeaderText = "Crew ID";
                dataGridView1.Columns[2].HeaderText = "Crew Name";
                dataGridView1.Columns[3].HeaderText = "Start Time";
                dataGridView1.Columns[4].HeaderText = "End Time";

                button1.Visible = true;
                button1.Text = "Print laporan checklog";
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
            dateTimePicker1.Enabled = false;

            try
            {
                Connection.open();

                string query = @"
            SELECT 
                transaksi_details.menu_id,
                menu.nama_menu,
                COUNT(transaksi_details.menu_id) AS total_dipesan
            FROM 
                transaksi
            JOIN 
                transaksi_details ON transaksi.transaksi_id = transaksi_details.transaksi_id
            JOIN 
                menu ON transaksi_details.menu_id = menu.id_menu
            WHERE 
                transaksi.status = 'berhasil'
            GROUP BY 
                transaksi_details.menu_id, menu.nama_menu
            ORDER BY 
                total_dipesan DESC
            LIMIT 3";

                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].HeaderText = "Menu ID";
                dataGridView1.Columns[1].HeaderText = "Menu Name";
                dataGridView1.Columns[2].HeaderText = "Total Sold";

                button1.Visible = true;
                button1.Text = "Print best seller menu";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
