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
using QRCoder;

namespace Proyek_PAD
{
    public partial class details_form : Form
    {
        int diskon;
        int transId;
        int totalMenu;
        int totalExtraCharge;
        int crewID;
        string crewName;
        int taxHarga;
        public details_form(int transId,int id,string u)
        {
            taxHarga = 0;
            totalMenu = 0;
            totalExtraCharge = 0;
            diskon = 0;
            this.transId = transId;
            this.crewID = id;
            crewName = u;
            InitializeComponent();
            


        }

        private void showDiscount(int id)
        {
            if(id > 0)
            {
                try
                {
                    Connection.open();
                    string query = "SELECT * FROM diskon WHERE diskon_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader r = cmd.ExecuteReader();
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            string name = r.GetString("diskon_name");
                            diskon = r.GetInt32("diskon_percent");
                            diskonLabel.Visible = true;
                            diskonLabel.Text = "Discount: " + name;
                        }
                    }
                    else
                    {
                        diskonLabel.Visible = false;
                    }
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
        }
        private void getDiscount()
        {
            int id = 0;
            try
            {
                Connection.open();
                string query = "SELECT * FROM transaksi WHERE diskon_id IS NOT NULL AND transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        
                        id = r.GetInt32("diskon_id");
                    }
                }
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
            showDiscount(id);
        }
        private void getPPN()
        {
            taxHarga = (int)Math.Ceiling(totalMenu * 0.12);
            ppnLabel.Text = "PPN 12%: " + taxHarga;
        }

        private void getTotalExtraCharge()
        {
            try
            {
                Connection.open();
                string query = "SELECT SUM(ec.extra_charge_harga) FROM extra_charge_trans ect JOIN extra_charge ec ON ect.extra_charge_id = ec.extra_charge_id WHERE ect.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id",transId);
                object res = cmd.ExecuteScalar();
                totalExtraCharge = (res == DBNull.Value || res == null) ? 0 : Convert.ToInt32(res);
                totalExtraChargeLabel.Text = "Total: " + totalExtraCharge;
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
        private void getTotalMenu()
        {
            try
            {
                Connection.open();
                string query = "SELECT SUM(m.harga_menu) FROM transaksi t JOIN transaksi_details td ON t.transaksi_id = td.transaksi_id JOIN menu m ON td.menu_id = m.id_menu WHERE t.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                object result = cmd.ExecuteScalar();
                totalMenu = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
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

        private void getName()
        {
            try
            {
                Connection.open();
                string query = "SELECT c.nama_customer FROM transaksi_details td JOIN customers c ON td.customer_id = c.id_customer WHERE td.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        string name = r.GetString("nama_customer");
                        memberNameLabel.Visible = true;
                        memberNameLabel.Text = "Name: " + name;
                    }
                }   
                else
                {
                    memberNameLabel.Visible = false;
                }
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

        private void loadPaymentMethod()
        {
            try
            {
                Connection.open();
                string query = "SELECT pm.nama_payment AS 'Nama Payment', pt.total AS 'Total' FROM payment_trans pt JOIN payment_method pm ON pt.payment_method = pm.payment_id WHERE transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                MySqlDataReader r = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(r);
                paymentMethodDataGridView.DataSource = dt;
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

        private void hitungTotal()
        {
            double discAmount = 0;
            if(diskon > 0)
            {
                discAmount = Math.Ceiling((diskon / 100.0) * totalMenu);
            }
            int total = totalMenu + totalExtraCharge + taxHarga - (int)discAmount;
            totalOrderLabel.Text = "TOTAL: " + total;
        }
        private void details_form_Load(object sender, EventArgs e)
        {
            getName();
            getTotalMenu();
            getTotalExtraCharge();
            getPPN();
            loadExtraCharge();
            loadMenuListBox();
            loadPaymentMethod();
            getDiscount();
            getName();
            hitungTotal();
        }

        private void updateTrans(string status)
        {
            try
            {
                Connection.open();
                string query = "UPDATE transaksi SET STATUS = @status, employee_id = @crewID WHERE transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@crewID", crewID);
                cmd.Parameters.AddWithValue("@trans_id", transId);
                cmd.ExecuteNonQuery();
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

        // lek gara gara iki terus crystal report e error command en ae, sak iki pisan ->private void GenerateQRCode()

        private string GetMenuListFromGrid()
        {
            StringBuilder menuList = new StringBuilder();

            foreach (DataGridViewRow row in menuDataGridView.Rows)
            {
                if (row.Cells["Nama Menu"].Value != null && row.Cells["Harga Menu"].Value != null)
                {
                    string menuName = row.Cells["Nama Menu"].Value.ToString();
                    string menuPrice = row.Cells["Harga Menu"].Value.ToString();
                    menuList.AppendLine($"- {menuName} ({menuPrice})");
                }
            }

            return menuList.ToString();
        }

        private void GenerateQRCode()
        {
            try
            {
                // Membuat daftar menu dari menuDataGridView
                string menuList = GetMenuListFromGrid();

                // Membuat data untuk QR Code
                string qrData = $"Transaction ID: {transId}\nCrew: {crewName}\nTotal: {totalMenu + totalExtraCharge + taxHarga - Math.Ceiling((diskon / 100.0) * totalMenu)}\nMenus:\n{menuList}";

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                        {
                            pictureBox1.Image = new Bitmap(qrCodeImage);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR Code: {ex.Message}");
            }
        }


        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateTrans("berhasil");
                GenerateQRCode();

                nota_form nota = new nota_form(transId, crewName);
                this.Hide();
                DialogResult res = nota.ShowDialog();
                this.Show();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            updateTrans("gagal");
            this.DialogResult = DialogResult.OK;
        }
    }
}
