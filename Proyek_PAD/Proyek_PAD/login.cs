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
        private Timer loadingTimer; 
        private int loadingDuration = 3000;
        MySqlConnection con;
        string query;

        public loginForm()
        {
            con = new MySqlConnection(connectionString);
            query = "";
            InitializeComponent();
            AssignButtonTagsAndEvents();
            AddTextBoxFocusEvents();
            pictureBox2.Visible = false;
            loadingTimer = new Timer();
            loadingTimer.Interval = 100; 
            loadingTimer.Tick += LoadingTimer_Tick;

        }

        private void clear()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private bool checkManager(string u, string p)
        {
            bool c = false;
            using(MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    query = "SELECT * FROM karyawan k JOIN ROLE r ON k.role_id = r.role_id WHERE nama = @username AND PASSWORD = @password AND r.role_name = 'manager'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@username", u);
                    cmd.Parameters.AddWithValue("@password", p);
                    MySqlDataReader r = cmd.ExecuteReader();
                    c = r.HasRows;
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return c;
        }

        private void checkLogin()
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            //if (username == "admin" && password == "admin")
            //{
            //    manager form4 = new manager();
            //    form4.Show();
            //    this.Hide();
            //    return;
            //}
            try
            {
                query = "SELECT* FROM karyawan WHERE nama = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    r.Close();
                    bool isManager = checkManager(username, password);
                    if (isManager)
                    {
                        manager f4 = new manager();
                        clear();
                        this.Hide();
                        DialogResult res = f4.ShowDialog();
                        if(res == DialogResult.OK)
                        {
                            this.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                        return;
                    }
                    else
                    {
                        pictureBox2.Visible = true;
                        loadingDuration = 3000;
                        loadingTimer.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Username / Password salah!");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }

        private void InsertCheckLog(int crewId)
        {
            string dayPrefix = DateTime.Now.ToString("ddd").ToUpper();
            DateTime now = DateTime.Now;
            string timeNow = now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = $"SELECT COUNT(*) FROM checklog WHERE log_id LIKE '{dayPrefix}%'";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection);
                    int logCount = Convert.ToInt32(selectCmd.ExecuteScalar());

                    string logId = $"{dayPrefix}{logCount + 1}";

                    string insertQuery = "INSERT INTO checklog (log_id, crew_id, start_time) VALUES (@log_id, @crew_id, @start_time)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@log_id", logId);
                    insertCmd.Parameters.AddWithValue("@crew_id", crewId);
                    insertCmd.Parameters.AddWithValue("@start_time", timeNow);

                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            loadingDuration -= loadingTimer.Interval;

            if (loadingDuration <= 0)
            {
                loadingTimer.Stop();
                pictureBox2.Visible = false;

                // Dapatkan crew_id dari username
                int crewId = GetCrewId(usernameTextBox.Text.Trim());
                if (crewId > 0)
                {
                    InsertCheckLog(crewId); // Insert log ke tabel checklog
                }

                cashier form1 = new cashier(usernameTextBox.Text.Trim(),crewId);
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
        }

        private int GetCrewId(string username)
        {
            int crewId = -1;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT crew_id FROM karyawan WHERE nama = @username";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        crewId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat mengambil crew_id: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return crewId;
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
            
        }

        private void AddTextBoxFocusEvents()
        {
            usernameTextBox.GotFocus += (s, e) =>
            {
                activeTextBox = usernameTextBox;
                panel1.Visible = true;

            };

            passwordTextBox.GotFocus += (s, e) =>
            {
                activeTextBox = passwordTextBox;
                panel1.Visible = true;

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
            panel1.Visible = false;
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

        

    }
}
