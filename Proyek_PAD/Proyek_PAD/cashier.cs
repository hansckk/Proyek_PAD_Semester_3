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
using CrystalDecisions.CrystalReports.Engine;

namespace Proyek_PAD
{
    public partial class cashier : Form
    {
        MySqlConnection con;
        string query;
        public string worker;
        string[] food;
        List<image> menuImg;
        int crewID;
        public cashier(string u, int id)
        {
            menuImg = new List<image>();
            food = new string[3];
            food[0] = "MAKAN";
            food[1] = "MINUM";
            food[2] = "SNACK";
            worker = u;
            query = "";
            crewID = id;
            con = new MySqlConnection("Server=localhost;Database=mcd_pad;User Id=root;Password=;");
            InitializeComponent();
           
        }

   

        private void clearDisplay()
        {
            displayDataGridView.Columns.Clear();
            displayDataGridView.Rows.Clear();
        }

       

        private void CustomizeDataGridView()
        {
            // Customize column headers based on the table structure
            displayDataGridView.Columns[0].HeaderText = "ID";
            displayDataGridView.Columns[1].HeaderText = "Customer Name";
            displayDataGridView.Columns[2].HeaderText = "Order Number";
            displayDataGridView.Columns[3].HeaderText = "Quantity";
            displayDataGridView.Columns[4].HeaderText = "Price";


            // Optional: Format the price and total_price columns as currency
            displayDataGridView.Columns[4].DefaultCellStyle.Format = "C3"; // Format as currency

            // Optional: Adjust column widths for better readability
            displayDataGridView.Columns[0].Width = 150;
            displayDataGridView.Columns[1].Width = 300;
            displayDataGridView.Columns[2].Width = 150;
            displayDataGridView.Columns[3].Width = 100;
            displayDataGridView.Columns[4].Width = 350;

        }


        // BANGSAT TESSSS
        private void LoadPendingTransactions()
        {
            try
            {
                // Query to get data from the pending_transactions table
                query = "SELECT transaksi_id AS 'Transaksi ID',time_ordered AS 'Time Ordered' FROM transaksi WHERE status = 'pending'";
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Open connection to the database
                con.Open();

                // Execute the query and get the data
                MySqlDataReader reader = cmd.ExecuteReader();

                // Create a DataTable to hold the result
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Set the data source of the DataGridView
                displayDataGridView.DataSource = dt;

                // Close the reader
                reader.Close();

                // Customize the DataGridView after the data has been loaded
                // tak command iki bntr -hans
                //CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error loading pending transactions: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
        }

       
        private void Cashier_Load(object sender, EventArgs e)
        {
            workerLabel.Text = "Welcome, " + worker;
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
            LoadPendingTransactions();
            time.Start();
        }
       
        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

     

        private void menuDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Apakah {worker} yakin untuk logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string getInfoQuery = @"
                SELECT cl.log_id, c.crew_id, c.nama, cl.start_time 
                FROM karyawan c 
                JOIN checklog cl ON c.crew_id = cl.crew_id 
                WHERE c.nama = @worker AND cl.end_time IS NULL";

                    MySqlCommand cmd = new MySqlCommand(getInfoQuery, con);
                    cmd.Parameters.AddWithValue("@worker", worker);

                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string logId = reader.GetString("log_id");
                        int crewId = reader.GetInt32("crew_id");
                        string nama = reader.GetString("nama");
                        DateTime startTime = reader.GetDateTime("start_time");

                        reader.Close();

                        string updateQuery = "UPDATE checklog SET end_time = @end_time WHERE log_id = @log_id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                        DateTime endTime = DateTime.Now;
                        updateCmd.Parameters.AddWithValue("@end_time", endTime);
                        updateCmd.Parameters.AddWithValue("@log_id", logId);
                        updateCmd.ExecuteNonQuery();

                        string hari = DateTime.Now.ToString("dddd, d - M - yyyy");
                        string pesan = $"Name: {nama}\nCrew ID: {crewId}\nDay: {hari}\nWaktu Mulai: {startTime}\nWaktu Selesai: {endTime}";
                        MessageBox.Show(pesan, "Informasi Logout");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data log tidak ditemukan untuk pengguna ini.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat logout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void splitPaymentButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void displayDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            if(e.RowIndex >= 0)
            {
                id = Convert.ToInt32(displayDataGridView.Rows[e.RowIndex].Cells[0].Value);
                details_form df = new details_form(id,crewID,worker);
                DialogResult res = df.ShowDialog();
                if(res == DialogResult.OK)
                {
                    LoadPendingTransactions();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                customer Cust = new customer(this);
                this.Hide();
                DialogResult res = Cust.ShowDialog();
                this.Show();
                LoadPendingTransactions();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form8 form8 = new Form8(this); // Pass reference of 'customer'
                this.Hide(); // Hide 'customer' form
                form8.ShowDialog(); // Use ShowDialog to keep control flow
                this.Show(); // Restore 'customer' form visibility when returning
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void workerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
