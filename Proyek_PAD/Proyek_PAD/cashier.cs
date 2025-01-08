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
    public partial class cashier : Form
    {
        MySqlConnection con;
        string query;
        string worker;
        string[] food;
        List<image> menuImg;
        public cashier(string u)
        {
            menuImg = new List<image>();
            food = new string[3];
            food[0] = "MAKAN";
            food[1] = "MINUM";
            food[2] = "SNACK";
            worker = u;
            query = "";
            con = new MySqlConnection("Server=localhost;Database=mcd_pad;User Id=root;Password=;");
            InitializeComponent();
        }

        //ini buat nambah number dek textbox1
        // test
        //private void numberButtonClick(string num)
        //{
        //    foreach (var f in food)
        //    {
        //        if (cashierTextBox.Text.Contains(f))
        //        {
        //            cashierTextBox.Text += num;
        //            break;
        //        }
        //    }  
        //}

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



        // ~ dikomen irvin
        //private void showDisplay()    
        //{
        //    clearDisplay();
        //    displayDataGridView.ColumnCount = 2;
        //    displayDataGridView.Columns[0].HeaderText = "Menu Name";
        //    displayDataGridView.Columns[1].HeaderText = "Quantity";
        //    DataGridViewButtonColumn btn_column_add = new DataGridViewButtonColumn();
        //    btn_column_add.HeaderText = "Add";
        //    btn_column_add.Text = "Add";
        //    btn_column_add.UseColumnTextForButtonValue = true;
        //    displayDataGridView.Columns.Add(btn_column_add);
        //    DataGridViewButtonColumn btn_column_remove = new DataGridViewButtonColumn();
        //    btn_column_remove.HeaderText = "Remove";
        //    btn_column_remove.Text = "Remove";
        //    btn_column_remove.UseColumnTextForButtonValue = true;
        //    displayDataGridView.Columns.Add(btn_column_remove);
        //    DataGridViewButtonColumn btn_column_clear = new DataGridViewButtonColumn();
        //    btn_column_clear.HeaderText = "Clear";
        //    btn_column_clear.Text = "Clear";
        //    btn_column_clear.UseColumnTextForButtonValue = true;
        //    displayDataGridView.Columns.Add(btn_column_clear);
        //}

        //buat jam ini
        private void timer1_Tick(object sender, EventArgs e)
        {
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
        }

        //private void showTotal()
        //{
        //    totalPanel.Visible = true;
        //}
        private void Cashier_Load(object sender, EventArgs e)
        {
            workerLabel.Text = "Welcome, " + worker;
            //menuDataGridView.Visible = false;
            //totalPanel.Visible = false;
            dayLabel.Text = "Day: " + DateTime.Now.ToString("dddd, d - M - yyyy");
            timeLabel.Text = "Time: " + DateTime.Now.ToString("HH:mm");
            LoadPendingTransactions();
            time.Start();
        }
        //private void clearText()
        //{
        //    cashierTextBox.Text = "";
        //}

        //private void buttonNo1_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("1");
        //}

        //private void buttonNo2_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("2");
        //}

        //private void buttonNo3_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("3");
        //}

        //private void buttonNo4_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("4");
        //}

        //private void buttonNo5_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("5");
        //}

        //private void buttonNo6_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("6");
        //}

        //private void buttonNo7_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("7");
        //}

        //private void buttonNo8_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("8");
        //}

        //private void buttonNo9_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("9");
        //}

        //private void buttonNo0_Click(object sender, EventArgs e)
        //{
        //    numberButtonClick("0");
        //}

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    if (cashierTextBox.Text.Any(char.IsDigit))
        //    {
        //        cashierTextBox.Text = cashierTextBox.Text.Substring(0, cashierTextBox.Text.Length - 1);
        //    }
        //    else {
        //        foreach (var f in food)
        //        {
        //            if (cashierTextBox.Text.Contains(f))
        //            {
        //                cashierTextBox.Text = "";
        //            }
        //        }
        //    }
        //}
        
        //private void showOrder()
        //{

        //}

        //private void order()
        //{
        //    if (cashierTextBox.Text != "")
        //    {
        //        Quantity q = new Quantity();
        //        DialogResult dr = q.ShowDialog();
        //        if(dr == DialogResult.OK)
        //        {
        //            int quantity = q.selectedQuantity;
        //            showTotal();
        //            // showDisplay();   ~ dikomen irvin 
        //            displayDataGridView.Size = new Size(displayDataGridView.Width, 640);
        //        }
        //        clearText();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Isi textbox dahulu!");
        //    }
        //}
        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Enter:
            //        order();
            //        break;
            //}
        }

        //private void acceptButton_Click(object sender, EventArgs e)
        //{
        //    order();
        //}

        //buat searchnya isa ganti
        //private void searchVisible(bool s1, bool s2)
        //{
        //    buttonNo1.Visible = s1;
        //    buttonNo2.Visible = s1;
        //    buttonNo3.Visible = s1;
        //    buttonNo4.Visible = s1;
        //    buttonNo5.Visible = s1;
        //    buttonNo6.Visible = s1;
        //    buttonNo7.Visible = s1;
        //    buttonNo8.Visible = s1;
        //    buttonNo9.Visible = s1;
        //    buttonNo0.Visible = s1;
        //    makanButton.Visible = s1;
        //    minumButton.Visible = s1;
        //    snackButton.Visible = s1;
        //    clearTextButton.Visible = s1;
        //    deleteButton.Visible = s1;
        //    menuDataGridView.Visible = s2;
        //}

        //buat ganti search
        //private void searchBy(string type, bool s1, bool s2)
        //{
        //    clearText();
        //    searchGroupBox.Text = "Search by " + type;
        //    searchVisible(s1,s2);
        //}

        //private void loadMenu()
        //{
        //    try
        //    {
        //        query = "SELECT nama_menu AS 'Menu', harga_menu AS 'Harga Menu', quantity AS 'Quantity' FROM menu";
        //        MySqlCommand cmd = new MySqlCommand(query, con);
        //        con.Open();
        //        MySqlDataReader r = cmd.ExecuteReader();
        //        DataTable dt = new DataTable();
        //        dt.Load(r);
        //        menuDataGridView.DataSource = dt;
        //        r.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR! " + ex.Message);
        //    }
        //    con.Close();
        //}
        //private void searchByNameButton_Click(object sender, EventArgs e)
        //{
        //    loadMenu();
        //    searchBy("Name",false,true);
        //}

        //private void searchByIdButton_Click(object sender, EventArgs e)
        //{
        //    searchBy("ID", true, false);
        //}

        //private void clearDisplayButton_Click(object sender, EventArgs e)
        //{
        //    //lek ad sg buat buat cek lek misale data grid view display kosong, monggo wkwkw, aku lagi mw fokus sg laen (hans)
        //    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin men-delete order?", "Konfirmasi",MessageBoxButtons.YesNo);
        //    if(dr == DialogResult.Yes)
        //    {
        //        clearDisplay();
        //        clearText();
        //        totalPanel.Visible = false;
        //        displayDataGridView.Size = new Size(displayDataGridView.Width, 733); //iki height e jok diganti, lek diganti ntik elek
        //    }
        //}

        //private void clearTextButton_Click(object sender, EventArgs e)
        //{
        //    clearText();
        //}

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
                    string getInfoQuery = "SELECT cl.log_id, c.crew_id, c.nama, cl.start_time FROM karyawan c JOIN checklog cl ON c.crew_id = cl.crew_id WHERE c.nama = @worker AND cl.end_time = '0000-00-00 00:00:00'";
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

        //private void isiCashierTextbox(string t)
        //{
        //    cashierTextBox.Text = "";
        //    cashierTextBox.Text = t;
        //}
        //private void makanButton_Click(object sender, EventArgs e)
        //{
        //    isiCashierTextbox("MAKAN");
        //}

        //private void minumButton_Click(object sender, EventArgs e)
        //{
        //    isiCashierTextbox("MINUM");
        //}

        //private void snackButton_Click(object sender, EventArgs e)
        //{
        //    isiCashierTextbox("SNACK");
        //}

        //private void search() 
        //{
        //    query = "SELECT nama_menu AS 'Menu', harga_menu AS 'Harga Menu', quantity AS 'Quantity' FROM menu WHERE nama_menu LIKE @namaMakan OR id_menu LIKE @idMakan";
        //    con.Open();
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, con);
        //        cmd.Parameters.AddWithValue("@namaMakan", "%" + cashierTextBox.Text + "%");
        //        cmd.Parameters.AddWithValue("@idMakan", "%" + cashierTextBox.Text + "%");
        //        MySqlDataReader r = cmd.ExecuteReader();
        //        DataTable res = new DataTable();
        //        res.Load(r);
        //        menuDataGridView.DataSource = res;
        //        r.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR! " + ex.Message);
        //    }
        //    con.Close();
        //}
        //private void cashierTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if(cashierTextBox.Text == "")
        //    {
        //        loadMenu();
        //    }
        //    else
        //    {
        //        search();
        //    }
        //}

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
                details_form df = new details_form(id);
                DialogResult res = df.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer Cust = new customer();
            this.Hide();
            DialogResult res = Cust.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            laporan lap = new laporan();
            lap.Show();
            this.Hide();
        }
    }
}
