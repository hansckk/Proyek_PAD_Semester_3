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
        public details_form(int transId)
        {
            this.transId = transId;
            InitializeComponent();
        }

        private void loadMenuListBox()
        {
            try
            {
                Connection.open();
                string query = "SELECT nama_menu AS 'Nama Menu' FROM transaksi t JOIN transaksi_details td ON t.transaksi_id = td.transaksi_id JOIN menu m ON td.menu_id = m.id_menu WHERE t.transaksi_id = @trans_id";
                MySqlCommand cmd = new MySqlCommand(query,Connection.conn);
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
            loadMenuListBox();
        }

        
    }
}
