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
        decimal totalPrice = 0;
        private Dictionary<string, int> itemQuantities = new Dictionary<string, int>();
        private List<OrderedItem> orderedItems = new List<OrderedItem>();

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

                        // Get the saved quantity or default to 0
                        int qty = itemQuantities.ContainsKey(id) ? itemQuantities[id] : 0;

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
                            Text = qty.ToString(),
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
                            Size = new Size(120, 120),
                            Location = new Point(40, 0),
                            Image = Properties.Resources.bone,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        increaseQty.Click += (s, e) =>
                        {
                            qty++; // Increment the quantity
                            qtyLabel.Text = qty.ToString();

                            if (!itemQuantities.ContainsKey(id))
                            {
                                itemQuantities[id] = 0;
                            }

                            itemQuantities[id] = qty;

                            totalPrice += price;
                            UpdateTotalLabel();

                            // Check if the item already exists in orderedItems
                            var existingItem = orderedItems.FirstOrDefault(i => i.MenuId == id);
                            if (existingItem != null)
                            {
                                // If item already exists, update the quantity
                                existingItem.Quantity = qty;
                            }
                            else
                            {
                                // If item doesn't exist, add it to the orderedItems list
                                AddItemToOrder(id, name, price, qty);
                            }

                            // Update the ListBox
                            UpdateListBox();
                        };

                        decreaseQty.Click += (s, e) =>
                        {
                            if (qty > 0)
                            {
                                qty--;
                                qtyLabel.Text = qty.ToString();
                                itemQuantities[id] = qty;

                                // Update or remove the item from orderedItems
                                var orderedItem = orderedItems.FirstOrDefault(i => i.MenuId == id);
                                if (orderedItem != null)
                                {
                                    orderedItem.Quantity = qty;
                                    if (qty == 0)
                                    {
                                        orderedItems.Remove(orderedItem);
                                    }
                                }

                                totalPrice -= price;
                                UpdateTotalLabel();

                                // Update the ListBox
                                UpdateListBox();
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



        private void PlaceOrderToDatabase()
        {
            try
            {
                string customerName = ORDER_NUMBER.Text;  // Use the generated order number as the customer name

                Connection.open();
                foreach (var item in orderedItems) // Assuming orderedItems is a list of OrderedItem
                {
                    // Check if the item already exists in the database by customer name (order number) and menu name
                    string checkQuery = "SELECT COUNT(*) FROM pending_transactions WHERE customer_name = @customerName AND menu_name = @menuName";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, Connection.conn);
                    checkCmd.Parameters.AddWithValue("@customerName", customerName); // Use actual customer name (order number)
                    checkCmd.Parameters.AddWithValue("@menuName", item.MenuName);

                    int itemCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (itemCount == 0) // If item does not exist in the table, insert it
                    {
                        string insertQuery = "INSERT INTO pending_transactions (customer_name, menu_name, quantity, price, total_price) " +
                                             "VALUES (@customerName, @menuName, @quantity, @price, @totalPrice)";
                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, Connection.conn);
                        insertCmd.Parameters.AddWithValue("@customerName", customerName); // Use actual customer name (order number)
                        insertCmd.Parameters.AddWithValue("@menuName", item.MenuName);
                        insertCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        insertCmd.Parameters.AddWithValue("@price", item.Price);
                        insertCmd.Parameters.AddWithValue("@totalPrice", item.Price * item.Quantity);
                        insertCmd.ExecuteNonQuery();
                    }
                    else // If item exists, update the quantity and total price
                    {
                        string updateQuery = "UPDATE pending_transactions SET quantity = quantity + @quantity, total_price = total_price + @totalPrice " +
                                             "WHERE customer_name = @customerName AND menu_name = @menuName";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, Connection.conn);
                        updateCmd.Parameters.AddWithValue("@customerName", customerName); // Use actual customer name (order number)
                        updateCmd.Parameters.AddWithValue("@menuName", item.MenuName);
                        updateCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        updateCmd.Parameters.AddWithValue("@totalPrice", item.Price * item.Quantity);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order placed successfully!");
                orderedItems.Clear(); // Clear the in-memory list
                LoadMenus(); // Refresh the UI
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}");
            }
            finally
            {
                Connection.close();
            }
        }





        private void AddItemToOrder(string menuId, string menuName, decimal price, int quantity)
        {
            OrderedItem item = new OrderedItem
            {
                MenuId = menuId,
                MenuName = menuName,
                Price = price,
                Quantity = quantity
            };

            orderedItems.Add(item);
        }





        private void UpdateTotalLabel()
        {
            Total_label.Text = $"{totalPrice:N0}";
        }

        public class OrderedItem
        {
            public string MenuId { get; set; }
            public string MenuName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice => Price * Quantity;
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear(); // Clear existing items

            foreach (var item in orderedItems)
            {
                string listItem = $"{item.MenuName} x{item.Quantity}";
                listBox1.Items.Add(listItem);
            }
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            GenerateOrderNumber();
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

        private void pictureBox1_Click(object sender, EventArgs e) // logo mcd ne
        {
            loginForm logform = new loginForm();
            this.Dispose();
            logform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Total_label_Click(object sender, EventArgs e)
        {
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {

        

            if (orderedItems.Count > 0)
            {
                // PlaceOrderToDatabase();
                Form7 form7 = new Form7();
                foreach (var item in orderedItems)
                {
                    form7.textBox2.Text += $"{item.MenuName}\r\n";
                }
                this.Hide();
                form7.Show();
                
            }
            else
            {
                MessageBox.Show("No items in the order!");
            }
        }

        private void ORDER_NUMBER_Click(object sender, EventArgs e)
        {

        }

        private void GenerateOrderNumber()
        {
            Random random = new Random();
            int orderNumber = random.Next(1000, 9999); // Generate a 4-digit random number
            ORDER_NUMBER.Text = orderNumber.ToString(); // Display it in the ORDER_NUMBER label
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
