
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
            this.timePanel = new System.Windows.Forms.Panel();
            this.workerLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.CrystalReport11 = new Proyek_PAD.CrystalReport1();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AllowUserToAddRows = false;
            this.displayDataGridView.AllowUserToDeleteRows = false;
            this.displayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Location = new System.Drawing.Point(11, 97);
            this.displayDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.ReadOnly = true;
            this.displayDataGridView.RowHeadersWidth = 51;
            this.displayDataGridView.RowTemplate.Height = 24;
            this.displayDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayDataGridView.Size = new System.Drawing.Size(1178, 552);
            this.displayDataGridView.TabIndex = 1;
            this.displayDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGridView_CellDoubleClick);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(2, 1);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dayLabel.Size = new System.Drawing.Size(34, 15);
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
            this.timeLabel.Size = new System.Drawing.Size(41, 15);
            this.timeLabel.TabIndex = 21;
            this.timeLabel.Text = "Time: ";
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.Gold;
            this.timePanel.Controls.Add(this.dayLabel);
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePanel.Location = new System.Drawing.Point(787, 25);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(221, 47);
            this.timePanel.TabIndex = 28;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerLabel.Location = new System.Drawing.Point(85, 25);
            this.workerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(142, 31);
            this.workerLabel.TabIndex = 29;
            this.workerLabel.Text = "Welcome,";
            this.workerLabel.Click += new System.EventHandler(this.workerLabel_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1013, 25);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(176, 51);
            this.logoutButton.TabIndex = 30;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1012, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 77);
            this.button1.TabIndex = 31;
            this.button1.Text = "Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(814, 661);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 77);
            this.button2.TabIndex = 32;
            this.button2.Text = "Member";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(11, 11);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.displayDataGridView);
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
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CrystalReport1 CrystalReport11;
    }
}

