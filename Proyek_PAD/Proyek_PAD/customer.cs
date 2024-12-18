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
    public partial class customer : Form
    {

        string currentselected = "Makanan"; // DEFAULT

        public customer()
        {
            InitializeComponent();
            LoadMenus();
        }

        private void LoadMenus()
        {
            panel1.Controls.Clear();
            try
            {
                Connection.open();
                string query = $"SELECT id_menu, nama_menu, harga_menu FROM menu WHERE kategori = '{currentselected}'";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int yOffset = 0;
                    int xOffset = 7;
                    int columnCount = 0;
                    int panelWidth = 200;
                    int panelHeight = 180;

                    while (reader.Read())
                    {
                        string id = reader["id_menu"].ToString();
                        string name = reader["nama_menu"].ToString();
                        decimal price = Convert.ToDecimal(reader["harga_menu"]);

                        Panel menuPanel = new Panel
                        {
                            Size = new Size(panelWidth, panelHeight),
                            Location = new Point(xOffset, yOffset),
                            BorderStyle = BorderStyle.FixedSingle,
                            BackColor = Color.WhiteSmoke
                        };

                        Label nameLabel = new Label
                        {
                            Text = name,
                            Location = new Point(10, 135),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Bold)
                        };

                        Label priceLabel = new Label
                        {
                            Text = $"Rp {price:N0}",
                            Location = new Point(10, 155),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular)
                        };

                        Label qtyLabel = new Label
                        {
                            Text = "0",
                            Location = new Point(menuPanel.Width - 55, 155),
                            AutoSize = true,
                            Font = new Font("Arial", 12, FontStyle.Regular)
                        };

                        Button increaseQty = new Button
                        {
                            Text = ">",
                            Location = new Point(menuPanel.Width - 30, 155),
                            Size = new Size(20, 20)
                        };

                        Button decreaseQty = new Button
                        {
                            Text = "<",
                            Location = new Point(menuPanel.Width - 80, 155),
                            Size = new Size(20, 20)
                        };
                        PictureBox Thumbnail = new PictureBox
                        {
                            Size = new Size(120, 120), // Adjust size
                            Location = new Point(40, 0), // Adjust location
                            Image = Properties.Resources.bone,
                            SizeMode = PictureBoxSizeMode.Zoom // Optional: Adjust the image display mode
                        };

                        int qty = 0;

                        increaseQty.Click += (s, e) =>
                        {
                            qty++;
                            qtyLabel.Text = qty.ToString();

                            if (qty > 99)
                            {
                                qty--;
                                qtyLabel.Text = qty.ToString();
                            }
                        };

                        decreaseQty.Click += (s, e) =>
                        {
                            if (qty > 0)
                            {
                                qty--;
                                qtyLabel.Text = qty.ToString();
                            }
                        };

                        menuPanel.Controls.Add(nameLabel);
                        menuPanel.Controls.Add(priceLabel);
                        menuPanel.Controls.Add(increaseQty);
                        menuPanel.Controls.Add(decreaseQty);
                        menuPanel.Controls.Add(qtyLabel);
                        menuPanel.Controls.Add(Thumbnail);

                        panel1.Controls.Add(menuPanel);

                        xOffset += panelWidth + 10;
                        columnCount++;

                        if (columnCount >= 3)
                        {
                            xOffset = 7;
                            yOffset += panelHeight + 10;
                            columnCount = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentselected = "Makanan";
            LoadMenus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currentselected = "Minuman";
            LoadMenus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            currentselected = "Snack";
            LoadMenus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}