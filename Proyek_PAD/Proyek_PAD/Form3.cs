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
    public partial class loginForm : Form
    {
        private string connectionString = "Server=localhost;Database=mcd_pad;Uid=root;Pwd=;";
        private TextBox activeTextBox;
        private bool isCapsLockActive = false;
        private bool isShiftActive = false;

        public loginForm()
        {
            InitializeComponent();
            AssignButtonTagsAndEvents();
            AddTextBoxFocusEvents();

            
        }

        private void clear()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void checkLogin()
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
                return; 
            }

            string query = "SELECT COUNT(1) FROM kasir WHERE nama_kasir = @username AND password_kasir = @password";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cashier form1 = new Cashier(username);
                            clear();
                            this.Hide();
                            DialogResult res = form1.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                this.Show();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void AssignButtonTagsAndEvents()
        {
            button2.Tag = "q";
            button3.Tag = "w";
            button4.Tag = "e";
            button5.Tag = "r";
            button6.Tag = "t";
            button7.Tag = "y";
            button8.Tag = "u";
            button9.Tag = "i";
            button10.Tag = "o";
            button11.Tag = "p";
            button14.Tag = "a";
            button15.Tag = "s";
            button16.Tag = "d";
            button17.Tag = "f";
            button18.Tag = "g";
            button19.Tag = "h";
            button20.Tag = "j";
            button21.Tag = "k";
            button22.Tag = "l";
            button23.Tag = ";";
            button26.Tag = "z";
            button27.Tag = "x";
            button28.Tag = "c";
            button29.Tag = "v";
            button30.Tag = "b";
            button31.Tag = "n";
            button32.Tag = "m";
            button33.Tag = ",";
            button34.Tag = ".";
            button35.Tag = "/";
            button36.Tag = "?";
            button41.Tag = "(";
            button42.Tag = ")";
            button43.Tag = "<";
            button44.Tag = ">";

            button12.Click += Button12_Click; // <- buat Backspace
            button40.Click += Button40_Click; // <- buat Space

            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
            button10.Click += Button_Click;
            button11.Click += Button_Click;

            button14.Click += Button_Click;
            button15.Click += Button_Click;
            button16.Click += Button_Click;
            button17.Click += Button_Click;
            button18.Click += Button_Click;
            button19.Click += Button_Click;
            button20.Click += Button_Click;
            button21.Click += Button_Click;
            button22.Click += Button_Click;
            button23.Click += Button_Click;
            button26.Click += Button_Click;
            button27.Click += Button_Click;
            button28.Click += Button_Click;
            button29.Click += Button_Click;
            button30.Click += Button_Click;
            button31.Click += Button_Click;
            button32.Click += Button_Click;
            button33.Click += Button_Click;
            button34.Click += Button_Click;
            button35.Click += Button_Click;
            button36.Click += Button_Click;
            button41.Click += Button_Click;
            button42.Click += Button_Click;
            button43.Click += Button_Click;
            button44.Click += Button_Click;
            button13.Click += Button13_Click;
            button25.MouseDown += Button25_MouseDown;
            button25.MouseUp += Button25_MouseUp;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag != null && activeTextBox != null)
            {
                string character = button.Tag.ToString();

                if (isCapsLockActive || isShiftActive)
                {
                    character = character.ToUpper();
                }

                activeTextBox.Text += character;
                activeTextBox.Focus();

                isShiftActive = false;
                Button shiftButton = button25;
                shiftButton.BackColor = SystemColors.Control;
                shiftButton.ForeColor = SystemColors.ControlText;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && activeTextBox.Text.Length > 0)
            {
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
                activeTextBox.Focus();
            }
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
            {
                activeTextBox.Text += " ";
                activeTextBox.Focus();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            isCapsLockActive = !isCapsLockActive;
            Button button = sender as Button;
            if (button != null)
            {
                if (isCapsLockActive)
                {
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private void Button25_MouseDown(object sender, MouseEventArgs e)
        {
            isShiftActive = true;
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.Gray;
                button.ForeColor = Color.White;
            }
        }

        private void Button25_MouseUp(object sender, MouseEventArgs e)
        {
            // salah pencet hehe
        }

        private void AddTextBoxFocusEvents()
        {
            usernameTextBox.GotFocus += (s, e) =>
            {
                activeTextBox = usernameTextBox;
               
            };

            passwordTextBox.GotFocus += (s, e) =>
            {
                activeTextBox = passwordTextBox;
               
            };

            usernameTextBox.LostFocus += (s, e) =>
            {
                
                    
            };

            passwordTextBox.LostFocus += (s, e) =>
            {
               
                 
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '\0')
            {
                passwordTextBox.PasswordChar = '•'; 
            }
            else
            {
                passwordTextBox.PasswordChar = '\0'; 
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
