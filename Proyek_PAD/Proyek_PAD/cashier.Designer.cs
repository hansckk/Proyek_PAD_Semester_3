
namespace Proyek_PAD
{
    partial class cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashier));
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.dayLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.minumButton = new System.Windows.Forms.Button();
            this.makanButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.cashierTextBox = new System.Windows.Forms.TextBox();
            this.clearDisplayButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchByIdButton = new System.Windows.Forms.Button();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.splitPaymentButton = new System.Windows.Forms.Button();
            this.buttonNo1 = new System.Windows.Forms.Button();
            this.buttonNo8 = new System.Windows.Forms.Button();
            this.buttonNo2 = new System.Windows.Forms.Button();
            this.buttonNo3 = new System.Windows.Forms.Button();
            this.buttonNo9 = new System.Windows.Forms.Button();
            this.buttonNo4 = new System.Windows.Forms.Button();
            this.buttonNo7 = new System.Windows.Forms.Button();
            this.buttonNo5 = new System.Windows.Forms.Button();
            this.buttonNo0 = new System.Windows.Forms.Button();
            this.buttonNo6 = new System.Windows.Forms.Button();
            this.snackButton = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.queueLabel = new System.Windows.Forms.Label();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.timePanel = new System.Windows.Forms.Panel();
            this.workerLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            this.totalPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Location = new System.Drawing.Point(11, 86);
            this.displayDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.ReadOnly = true;
            this.displayDataGridView.RowHeadersWidth = 51;
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.Size = new System.Drawing.Size(799, 733);
            this.displayDataGridView.TabIndex = 1;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(2, 1);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dayLabel.Size = new System.Drawing.Size(42, 18);
            this.dayLabel.TabIndex = 20;
            this.dayLabel.Text = "Day :";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(2, 29);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLabel.Size = new System.Drawing.Size(49, 18);
            this.timeLabel.TabIndex = 21;
            this.timeLabel.Text = "Time: ";
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.searchGroupBox.Controls.Add(this.menuDataGridView);
            this.searchGroupBox.Controls.Add(this.minumButton);
            this.searchGroupBox.Controls.Add(this.makanButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.clearTextButton);
            this.searchGroupBox.Controls.Add(this.cashierTextBox);
            this.searchGroupBox.Controls.Add(this.clearDisplayButton);
            this.searchGroupBox.Controls.Add(this.acceptButton);
            this.searchGroupBox.Controls.Add(this.deleteButton);
            this.searchGroupBox.Controls.Add(this.searchByIdButton);
            this.searchGroupBox.Controls.Add(this.searchByNameButton);
            this.searchGroupBox.Controls.Add(this.splitPaymentButton);
            this.searchGroupBox.Controls.Add(this.buttonNo1);
            this.searchGroupBox.Controls.Add(this.buttonNo8);
            this.searchGroupBox.Controls.Add(this.buttonNo2);
            this.searchGroupBox.Controls.Add(this.buttonNo3);
            this.searchGroupBox.Controls.Add(this.buttonNo9);
            this.searchGroupBox.Controls.Add(this.buttonNo4);
            this.searchGroupBox.Controls.Add(this.buttonNo7);
            this.searchGroupBox.Controls.Add(this.buttonNo5);
            this.searchGroupBox.Controls.Add(this.buttonNo0);
            this.searchGroupBox.Controls.Add(this.buttonNo6);
            this.searchGroupBox.Controls.Add(this.snackButton);
            this.searchGroupBox.Location = new System.Drawing.Point(815, 86);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(373, 733);
            this.searchGroupBox.TabIndex = 24;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search by ID";
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Location = new System.Drawing.Point(17, 80);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersWidth = 51;
            this.menuDataGridView.RowTemplate.Height = 24;
            this.menuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuDataGridView.Size = new System.Drawing.Size(335, 319);
            this.menuDataGridView.TabIndex = 25;
            this.menuDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDataGridView_CellDoubleClick);
            // 
            // minumButton
            // 
            this.minumButton.BackColor = System.Drawing.Color.GhostWhite;
            this.minumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minumButton.Location = new System.Drawing.Point(130, 80);
            this.minumButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.minumButton.Name = "minumButton";
            this.minumButton.Size = new System.Drawing.Size(109, 60);
            this.minumButton.TabIndex = 28;
            this.minumButton.Text = "MINUM";
            this.minumButton.UseVisualStyleBackColor = false;
            this.minumButton.Click += new System.EventHandler(this.minumButton_Click);
            // 
            // makanButton
            // 
            this.makanButton.BackColor = System.Drawing.Color.GhostWhite;
            this.makanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makanButton.Location = new System.Drawing.Point(17, 80);
            this.makanButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.makanButton.Name = "makanButton";
            this.makanButton.Size = new System.Drawing.Size(109, 60);
            this.makanButton.TabIndex = 27;
            this.makanButton.Text = "MAKAN";
            this.makanButton.UseVisualStyleBackColor = false;
            this.makanButton.Click += new System.EventHandler(this.makanButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.GhostWhite;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(302, 24);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(50, 50);
            this.searchButton.TabIndex = 26;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTextButton.Location = new System.Drawing.Point(17, 340);
            this.clearTextButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(109, 60);
            this.clearTextButton.TabIndex = 24;
            this.clearTextButton.Text = "CLEAR";
            this.clearTextButton.UseVisualStyleBackColor = false;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // cashierTextBox
            // 
            this.cashierTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.cashierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierTextBox.Location = new System.Drawing.Point(17, 29);
            this.cashierTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cashierTextBox.Name = "cashierTextBox";
            this.cashierTextBox.Size = new System.Drawing.Size(281, 45);
            this.cashierTextBox.TabIndex = 6;
            this.cashierTextBox.TextChanged += new System.EventHandler(this.cashierTextBox_TextChanged);
            // 
            // clearDisplayButton
            // 
            this.clearDisplayButton.BackColor = System.Drawing.Color.Red;
            this.clearDisplayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearDisplayButton.BackgroundImage")));
            this.clearDisplayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearDisplayButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearDisplayButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clearDisplayButton.Location = new System.Drawing.Point(17, 405);
            this.clearDisplayButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearDisplayButton.Name = "clearDisplayButton";
            this.clearDisplayButton.Size = new System.Drawing.Size(335, 75);
            this.clearDisplayButton.TabIndex = 2;
            this.clearDisplayButton.UseVisualStyleBackColor = false;
            this.clearDisplayButton.Click += new System.EventHandler(this.clearDisplayButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.LightGreen;
            this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
            this.acceptButton.Location = new System.Drawing.Point(17, 486);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(335, 75);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.GhostWhite;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(243, 340);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 60);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchByIdButton
            // 
            this.searchByIdButton.BackColor = System.Drawing.Color.GhostWhite;
            this.searchByIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdButton.Location = new System.Drawing.Point(17, 648);
            this.searchByIdButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchByIdButton.Name = "searchByIdButton";
            this.searchByIdButton.Size = new System.Drawing.Size(140, 75);
            this.searchByIdButton.TabIndex = 22;
            this.searchByIdButton.Text = "SEARCH BY ID";
            this.searchByIdButton.UseVisualStyleBackColor = false;
            this.searchByIdButton.Click += new System.EventHandler(this.searchByIdButton_Click);
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.BackColor = System.Drawing.Color.GhostWhite;
            this.searchByNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNameButton.Location = new System.Drawing.Point(212, 648);
            this.searchByNameButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(140, 75);
            this.searchByNameButton.TabIndex = 23;
            this.searchByNameButton.Text = "SEARCH BY NAME";
            this.searchByNameButton.UseVisualStyleBackColor = false;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // splitPaymentButton
            // 
            this.splitPaymentButton.BackColor = System.Drawing.Color.GhostWhite;
            this.splitPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitPaymentButton.Location = new System.Drawing.Point(17, 567);
            this.splitPaymentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitPaymentButton.Name = "splitPaymentButton";
            this.splitPaymentButton.Size = new System.Drawing.Size(335, 75);
            this.splitPaymentButton.TabIndex = 19;
            this.splitPaymentButton.Text = "SPLIT PAYMENT";
            this.splitPaymentButton.UseVisualStyleBackColor = false;
            this.splitPaymentButton.Click += new System.EventHandler(this.splitPaymentButton_Click);
            // 
            // buttonNo1
            // 
            this.buttonNo1.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo1.Location = new System.Drawing.Point(17, 142);
            this.buttonNo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo1.Name = "buttonNo1";
            this.buttonNo1.Size = new System.Drawing.Size(109, 60);
            this.buttonNo1.TabIndex = 7;
            this.buttonNo1.Text = "1";
            this.buttonNo1.UseVisualStyleBackColor = false;
            this.buttonNo1.Click += new System.EventHandler(this.buttonNo1_Click);
            // 
            // buttonNo8
            // 
            this.buttonNo8.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo8.Location = new System.Drawing.Point(130, 274);
            this.buttonNo8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo8.Name = "buttonNo8";
            this.buttonNo8.Size = new System.Drawing.Size(109, 60);
            this.buttonNo8.TabIndex = 18;
            this.buttonNo8.Text = "8";
            this.buttonNo8.UseVisualStyleBackColor = false;
            this.buttonNo8.Click += new System.EventHandler(this.buttonNo8_Click);
            // 
            // buttonNo2
            // 
            this.buttonNo2.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo2.Location = new System.Drawing.Point(130, 142);
            this.buttonNo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo2.Name = "buttonNo2";
            this.buttonNo2.Size = new System.Drawing.Size(109, 60);
            this.buttonNo2.TabIndex = 8;
            this.buttonNo2.Text = "2";
            this.buttonNo2.UseVisualStyleBackColor = false;
            this.buttonNo2.Click += new System.EventHandler(this.buttonNo2_Click);
            // 
            // buttonNo3
            // 
            this.buttonNo3.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo3.Location = new System.Drawing.Point(243, 142);
            this.buttonNo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo3.Name = "buttonNo3";
            this.buttonNo3.Size = new System.Drawing.Size(109, 60);
            this.buttonNo3.TabIndex = 9;
            this.buttonNo3.Text = "3";
            this.buttonNo3.UseVisualStyleBackColor = false;
            this.buttonNo3.Click += new System.EventHandler(this.buttonNo3_Click);
            // 
            // buttonNo9
            // 
            this.buttonNo9.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo9.Location = new System.Drawing.Point(243, 274);
            this.buttonNo9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo9.Name = "buttonNo9";
            this.buttonNo9.Size = new System.Drawing.Size(109, 60);
            this.buttonNo9.TabIndex = 15;
            this.buttonNo9.Text = "9";
            this.buttonNo9.UseVisualStyleBackColor = false;
            this.buttonNo9.Click += new System.EventHandler(this.buttonNo9_Click);
            // 
            // buttonNo4
            // 
            this.buttonNo4.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo4.Location = new System.Drawing.Point(17, 208);
            this.buttonNo4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo4.Name = "buttonNo4";
            this.buttonNo4.Size = new System.Drawing.Size(109, 60);
            this.buttonNo4.TabIndex = 10;
            this.buttonNo4.Text = "4";
            this.buttonNo4.UseVisualStyleBackColor = false;
            this.buttonNo4.Click += new System.EventHandler(this.buttonNo4_Click);
            // 
            // buttonNo7
            // 
            this.buttonNo7.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo7.Location = new System.Drawing.Point(17, 274);
            this.buttonNo7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo7.Name = "buttonNo7";
            this.buttonNo7.Size = new System.Drawing.Size(109, 60);
            this.buttonNo7.TabIndex = 14;
            this.buttonNo7.Text = "7";
            this.buttonNo7.UseVisualStyleBackColor = false;
            this.buttonNo7.Click += new System.EventHandler(this.buttonNo7_Click);
            // 
            // buttonNo5
            // 
            this.buttonNo5.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo5.Location = new System.Drawing.Point(130, 208);
            this.buttonNo5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo5.Name = "buttonNo5";
            this.buttonNo5.Size = new System.Drawing.Size(109, 60);
            this.buttonNo5.TabIndex = 11;
            this.buttonNo5.Text = "5";
            this.buttonNo5.UseVisualStyleBackColor = false;
            this.buttonNo5.Click += new System.EventHandler(this.buttonNo5_Click);
            // 
            // buttonNo0
            // 
            this.buttonNo0.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo0.Location = new System.Drawing.Point(130, 340);
            this.buttonNo0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo0.Name = "buttonNo0";
            this.buttonNo0.Size = new System.Drawing.Size(109, 60);
            this.buttonNo0.TabIndex = 13;
            this.buttonNo0.Text = "0";
            this.buttonNo0.UseVisualStyleBackColor = false;
            this.buttonNo0.Click += new System.EventHandler(this.buttonNo0_Click);
            // 
            // buttonNo6
            // 
            this.buttonNo6.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonNo6.Location = new System.Drawing.Point(243, 208);
            this.buttonNo6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo6.Name = "buttonNo6";
            this.buttonNo6.Size = new System.Drawing.Size(109, 60);
            this.buttonNo6.TabIndex = 12;
            this.buttonNo6.Text = "6";
            this.buttonNo6.UseVisualStyleBackColor = false;
            this.buttonNo6.Click += new System.EventHandler(this.buttonNo6_Click);
            // 
            // snackButton
            // 
            this.snackButton.BackColor = System.Drawing.Color.GhostWhite;
            this.snackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snackButton.Location = new System.Drawing.Point(243, 80);
            this.snackButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.snackButton.Name = "snackButton";
            this.snackButton.Size = new System.Drawing.Size(109, 60);
            this.snackButton.TabIndex = 29;
            this.snackButton.Text = "SNACK";
            this.snackButton.UseVisualStyleBackColor = false;
            this.snackButton.Click += new System.EventHandler(this.snackButton_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(4, 9);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(91, 29);
            this.taxLabel.TabIndex = 25;
            this.taxLabel.Text = "Pajak: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 49);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(104, 36);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total: ";
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueLabel.Location = new System.Drawing.Point(619, 54);
            this.queueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(101, 29);
            this.queueLabel.TabIndex = 26;
            this.queueLabel.Text = "Queue:";
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.totalPanel.Controls.Add(this.queueLabel);
            this.totalPanel.Controls.Add(this.taxLabel);
            this.totalPanel.Controls.Add(this.totalLabel);
            this.totalPanel.Location = new System.Drawing.Point(11, 732);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(816, 87);
            this.totalPanel.TabIndex = 27;
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.Silver;
            this.timePanel.Controls.Add(this.dayLabel);
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(815, 32);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(186, 48);
            this.timePanel.TabIndex = 28;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerLabel.Location = new System.Drawing.Point(62, 43);
            this.workerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(154, 36);
            this.workerLabel.TabIndex = 29;
            this.workerLabel.Text = "Welcome,";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.GhostWhite;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1048, 33);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 48);
            this.logoutButton.TabIndex = 30;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 33);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(47, 48);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 831);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.totalPanel);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button clearDisplayButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button splitPaymentButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.Button minumButton;
        private System.Windows.Forms.Button makanButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.TextBox cashierTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchByIdButton;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Button buttonNo1;
        private System.Windows.Forms.Button buttonNo8;
        private System.Windows.Forms.Button buttonNo2;
        private System.Windows.Forms.Button buttonNo3;
        private System.Windows.Forms.Button buttonNo9;
        private System.Windows.Forms.Button buttonNo4;
        private System.Windows.Forms.Button buttonNo7;
        private System.Windows.Forms.Button buttonNo5;
        private System.Windows.Forms.Button buttonNo0;
        private System.Windows.Forms.Button buttonNo6;
        private System.Windows.Forms.Button snackButton;
    }
}

