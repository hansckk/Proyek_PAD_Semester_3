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
    public partial class details_form : Form
    {
        int transId;
        int totalMenu;
        public details_form(int transId)
        {
            totalMenu = 0;
            this.transId = transId;
            InitializeComponent();
        }

        private void getDiscount()
        {
            try
            {
                Connection.open();
                string query = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        private void getPPN()
        {
            int taxHarga = (int)Math.Round(totalMenu * 0.12);
            ppnLabel.Text = "PPN 12%: " + taxHarga;
        }

        private void getTotalMenu()
        {
            try
            {
                Connection.open();
                string query = "SELECT SUM(m.harga_menu) FROM transaksi t JOIN transaksi_details td ON t.transaksi_id = td.transaksi_id JOIN menu m ON td.menu_id = m.id_menu WHERE t.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                totalMenu = Convert.ToInt32(cmd.ExecuteScalar());
                totalMenuLabel.Text = "Total Menu: " + totalMenu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        private void loadExtraCharge()
        {
            try
            {
                Connection.open();
                string query = "SELECT e.extra_name AS 'Extra Charge', e.extra_charge_harga AS 'Harga' FROM extra_charge e JOIN extra_charge_trans ec ON e.extra_charge_id = ec.extra_charge_id WHERE ec.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                extraChargeDataGridView.DataSource = dt;
                r.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        private void loadMenuListBox()
        {
            try
            {
                Connection.open();
                string query = "SELECT m.nama_menu AS 'Nama Menu', m.harga_menu AS 'Harga Menu' FROM transaksi t JOIN transaksi_details td ON t.transaksi_id = td.transaksi_id JOIN menu m ON td.menu_id = m.id_menu WHERE t.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query,Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                menuDataGridView.DataSource = dt;
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.close();
            }
        }
        private void details_form_Load(object sender, EventArgs e)
        {
            getTotalMenu();
            getPPN();
            loadExtraCharge();
            loadMenuListBox();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
