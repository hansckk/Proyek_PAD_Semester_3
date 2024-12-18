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
    public partial class Form6 : Form
    {

        string currentselected = "Makanan"; // DEFAULT

        public Form6()
        {
            InitializeComponent();
            LoadMenus();
        }

        private void LoadMenus()
        {
            // Clear any existing controls in panel1
            panel1.Controls.Clear();

            try
            {
                // Open the database connection
                Connection.open();

                string query = $"SELECT id_menu, nama_menu, harga_menu FROM menu WHERE kategori = '{currentselected}'";
                MySqlCommand cmd = new MySqlCommand(query, Connection.conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int yOffset = 0; // Vertical offset for placing panels

                    while (reader.Read())
                    {
                        // Retrieve data for each menu item
                        string id = reader["id_menu"].ToString();
                        string name = reader["nama_menu"].ToString();
                        decimal price = Convert.ToDecimal(reader["harga_menu"]);

                        // Create a panel for the menu item
                        Panel menuPanel = new Panel
                        {
                            Size = new Size(panel1.Width - 60, 60), // Adjust panel size
                            Location = new Point(10, yOffset),
                            BorderStyle = BorderStyle.FixedSingle,
                            BackColor = Color.LightGray
                        };

                        // Add a label for the menu name
                        Label nameLabel = new Label
                        {
                            Text = name,
                            Location = new Point(10, 10),
                            AutoSize = true,
                            Font = new Font("Arial", 10, FontStyle.Bold)
                        };

                        // Add a label for the menu price
                        Label priceLabel = new Label
                        {
                            Text = $"Rp {price:N0}",
                            Location = new Point(10, 30),
                            AutoSize = true,
                            Font = new Font("Arial", 9, FontStyle.Regular)
                        };

                        // Add a button to the panel
                        Button addToCartButton = new Button
                        {
                            Text = "Add to Cart",
                            Location = new Point(menuPanel.Width - 90, 15),
                            Size = new Size(80, 30)
                        };

                        // Optionally, add a click event to the button
                        addToCartButton.Click += (s, e) =>
                        {
                            MessageBox.Show($"Added {name} to cart!");
                        };

                        // Add controls to the panel
                        menuPanel.Controls.Add(nameLabel);
                        menuPanel.Controls.Add(priceLabel);
                        menuPanel.Controls.Add(addToCartButton);

                        // Add the panel to panel1
                        panel1.Controls.Add(menuPanel);

                        // Adjust the vertical offset for the next panel
                        yOffset += menuPanel.Height + 10;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu: {ex.Message}");
            }
            finally
            {
                // Close the database connection
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
    }
}