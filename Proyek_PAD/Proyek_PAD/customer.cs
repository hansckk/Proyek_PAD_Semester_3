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
        private cashier _cashierform;
        string currentselected = "Makanan"; // DEFAULT
        decimal totalPrice = 0;
        private Dictionary<string, int> itemQuantities = new Dictionary<string, int>();
        private List<orderedItem> orderedItems = new List<orderedItem>();

        private int counter = 1; // Counter for tracking the image sequence
        Dictionary<string, string> categoryToPrefix = new Dictionary<string, string>
        {
            { "makanan", "MAKAN" },
            { "minuman", "MINUM" },
            { "snack", "SNACK" }
        };

        public customer(cashier cashierform)
        {
            _cashierform = cashierform;
            InitializeComponent();
            LoadMenus();
        }

        private void LoadMenus()
        {
            panel1.Controls.Clear();
            counter = 1; // Reset the counter whenever the menu is reloaded

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

                    // Remove this redundant categoryToPrefix definition
                    // Dictionary<string, string> categoryToPrefix = new Dictionary<string, string>
                    // {
                    //     { "makanan", "MAKAN" },
                    //     { "minuman", "MINUM" },
                    //     { "snack", "SNACK" }
                    // };

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
                            SizeMode = PictureBoxSizeMode.Zoom
                        };

                        // Use the class-level categoryToPrefix
                        string resourcePrefix = categoryToPrefix.ContainsKey(currentselected.ToLower())
                            ? categoryToPrefix[currentselected.ToLower()]
                            : "DEFAULT";

                        string resourceName = $"{resourcePrefix}{counter:D3}"; // Construct the resource name
                        Image img = (Image)Properties.Resources.ResourceManager.GetObject(resourceName); // Get the image from resources
                        if (img != null)
                        {
                            Thumbnail.Image = img; // Set the image if found
                        }
                        else
                        {
                            Thumbnail.Image = Properties.Resources.bone; // Default image if not found
                        }

                        counter++; // Increment the counter for the next menu item

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
                            var existingItem = orderedItems.FirstOrDefault(i => i.MenuItem.Id == id); // Use MenuItem.Id
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
                                var orderedItem = orderedItems.FirstOrDefault(i => i.MenuItem.Id == id); // Use MenuItem.Id here
                                if (orderedItem != null)
                                {
                                    if (qty == 0)
                                    {
                                        orderedItems.Remove(orderedItem); // Remove the item if quantity is zero
                                    }
                                    else
                                    {
                                        orderedItem.Quantity = qty; // Update the quantity
                                    }
                                }

                                // Recalculate total price from orderedItems instead of incrementally adjusting
                                totalPrice = orderedItems.Sum(item => item.Quantity * item.Price);
                                UpdateTotalLabel(); // Update the label with the new total price
                                UpdateListBox();    // Update the order list
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


        private void AddItemToOrder(string menuId, string menuName, decimal price, int quantity)
        {
            var menuItem = new menuItem(menuId, menuName); // Create MenuItem object
            var existingItem = orderedItems.FirstOrDefault(item => item.MenuItem.Id == menuId); // Compare by MenuItem.Id

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                orderedItems.Add(new orderedItem(menuItem, quantity, price)); // Use OrderedItem constructor with MenuItem
            }

            totalPrice += price * quantity; // Update total price
            UpdateTotalLabel();
            UpdateListBox();
        }

        private void UpdateTotalLabel()
        {
            Total_label.Text = $"{totalPrice:N0}";
        }


        private void UpdateListBox()
        {
            listBox1.Items.Clear(); // Clear existing items

            foreach (var item in orderedItems)
            {
                listBox1.Items.Add(item.ToString());
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
                try
                {
                    Form7 form7 = new Form7(this); // Pass customer form reference
                    form7.orderedItems = new List<orderedItem>(orderedItems);
                    form7.updateOrderList();
                    this.Hide(); // Hide customer form
                    DialogResult res = form7.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        orderedItems.Clear();
                        listBox1.Items.Clear();
                        GenerateOrderNumber();
                        totalPrice = 0;
                        UpdateTotalLabel();
                    }
                    this.Show(); // Show customer form again after Form7 closes
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            orderedItems.Clear();
            listBox1.Items.Clear();
            totalPrice = 0;
            UpdateTotalLabel();

            foreach (var key in itemQuantities.Keys.ToList())
            {
                itemQuantities[key] = 0;
            }

            foreach (Control control in panel1.Controls)
            {
                if (control is Panel menuPanel)
                {
                    Label qtyLabel = menuPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Font.Size == 12);
                    if (qtyLabel != null)
                    {
                        qtyLabel.Text = "0";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            _cashierform.Show();
            // buat back, masih blm gatau error apao
        }
    }


}
