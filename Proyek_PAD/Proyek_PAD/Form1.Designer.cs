
namespace Proyek_PAD
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.displayView = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dayLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.searchByIdButton = new System.Windows.Forms.Button();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.queueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayView
            // 
            this.displayView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayView.Location = new System.Drawing.Point(11, 109);
            this.displayView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.displayView.Name = "displayView";
            this.displayView.RowHeadersWidth = 51;
            this.displayView.RowTemplate.Height = 24;
            this.displayView.Size = new System.Drawing.Size(799, 579);
            this.displayView.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(80, 80);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(977, 9);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(58, 25);
            this.dayLabel.TabIndex = 20;
            this.dayLabel.Text = "Day :";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(977, 34);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(67, 25);
            this.timeLabel.TabIndex = 21;
            this.timeLabel.Text = "Time: ";
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchByIdButton
            // 
            this.searchByIdButton.BackColor = System.Drawing.Color.GhostWhite;
            this.searchByIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIdButton.Location = new System.Drawing.Point(815, 694);
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
            this.searchByNameButton.Location = new System.Drawing.Point(1049, 694);
            this.searchByNameButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(140, 75);
            this.searchByNameButton.TabIndex = 23;
            this.searchByNameButton.Text = "SEARCH BY NAME";
            this.searchByNameButton.UseVisualStyleBackColor = false;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.idTextBox);
            this.searchGroupBox.Controls.Add(this.clearButton);
            this.searchGroupBox.Controls.Add(this.acceptButton);
            this.searchGroupBox.Controls.Add(this.deleteButton);
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
            this.searchGroupBox.Location = new System.Drawing.Point(815, 109);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(373, 579);
            this.searchGroupBox.TabIndex = 24;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search by ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(17, 29);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(335, 45);
            this.idTextBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clearButton.Location = new System.Drawing.Point(17, 323);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 75);
            this.clearButton.TabIndex = 2;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.LightGreen;
            this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
            this.acceptButton.Location = new System.Drawing.Point(17, 404);
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
            this.deleteButton.Location = new System.Drawing.Point(243, 323);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 75);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // splitPaymentButton
            // 
            this.splitPaymentButton.BackColor = System.Drawing.Color.GhostWhite;
            this.splitPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitPaymentButton.Location = new System.Drawing.Point(17, 485);
            this.splitPaymentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitPaymentButton.Name = "splitPaymentButton";
            this.splitPaymentButton.Size = new System.Drawing.Size(335, 75);
            this.splitPaymentButton.TabIndex = 19;
            this.splitPaymentButton.Text = "SPLIT PAYMENT";
            this.splitPaymentButton.UseVisualStyleBackColor = false;
            // 
            // buttonNo1
            // 
            this.buttonNo1.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo1.Location = new System.Drawing.Point(17, 80);
            this.buttonNo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo1.Name = "buttonNo1";
            this.buttonNo1.Size = new System.Drawing.Size(109, 75);
            this.buttonNo1.TabIndex = 7;
            this.buttonNo1.Text = "1";
            this.buttonNo1.UseVisualStyleBackColor = false;
            this.buttonNo1.Click += new System.EventHandler(this.buttonNo1_Click);
            // 
            // buttonNo8
            // 
            this.buttonNo8.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo8.Location = new System.Drawing.Point(130, 242);
            this.buttonNo8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo8.Name = "buttonNo8";
            this.buttonNo8.Size = new System.Drawing.Size(109, 75);
            this.buttonNo8.TabIndex = 18;
            this.buttonNo8.Text = "8";
            this.buttonNo8.UseVisualStyleBackColor = false;
            this.buttonNo8.Click += new System.EventHandler(this.buttonNo8_Click);
            // 
            // buttonNo2
            // 
            this.buttonNo2.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo2.Location = new System.Drawing.Point(130, 80);
            this.buttonNo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo2.Name = "buttonNo2";
            this.buttonNo2.Size = new System.Drawing.Size(109, 75);
            this.buttonNo2.TabIndex = 8;
            this.buttonNo2.Text = "2";
            this.buttonNo2.UseVisualStyleBackColor = false;
            this.buttonNo2.Click += new System.EventHandler(this.buttonNo2_Click);
            // 
            // buttonNo3
            // 
            this.buttonNo3.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo3.Location = new System.Drawing.Point(243, 80);
            this.buttonNo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo3.Name = "buttonNo3";
            this.buttonNo3.Size = new System.Drawing.Size(109, 75);
            this.buttonNo3.TabIndex = 9;
            this.buttonNo3.Text = "3";
            this.buttonNo3.UseVisualStyleBackColor = false;
            this.buttonNo3.Click += new System.EventHandler(this.buttonNo3_Click);
            // 
            // buttonNo9
            // 
            this.buttonNo9.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo9.Location = new System.Drawing.Point(243, 242);
            this.buttonNo9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo9.Name = "buttonNo9";
            this.buttonNo9.Size = new System.Drawing.Size(109, 75);
            this.buttonNo9.TabIndex = 15;
            this.buttonNo9.Text = "9";
            this.buttonNo9.UseVisualStyleBackColor = false;
            this.buttonNo9.Click += new System.EventHandler(this.buttonNo9_Click);
            // 
            // buttonNo4
            // 
            this.buttonNo4.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo4.Location = new System.Drawing.Point(17, 161);
            this.buttonNo4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo4.Name = "buttonNo4";
            this.buttonNo4.Size = new System.Drawing.Size(109, 75);
            this.buttonNo4.TabIndex = 10;
            this.buttonNo4.Text = "4";
            this.buttonNo4.UseVisualStyleBackColor = false;
            this.buttonNo4.Click += new System.EventHandler(this.buttonNo4_Click);
            // 
            // buttonNo7
            // 
            this.buttonNo7.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo7.Location = new System.Drawing.Point(17, 242);
            this.buttonNo7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo7.Name = "buttonNo7";
            this.buttonNo7.Size = new System.Drawing.Size(109, 75);
            this.buttonNo7.TabIndex = 14;
            this.buttonNo7.Text = "7";
            this.buttonNo7.UseVisualStyleBackColor = false;
            this.buttonNo7.Click += new System.EventHandler(this.buttonNo7_Click);
            // 
            // buttonNo5
            // 
            this.buttonNo5.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo5.Location = new System.Drawing.Point(130, 161);
            this.buttonNo5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo5.Name = "buttonNo5";
            this.buttonNo5.Size = new System.Drawing.Size(109, 75);
            this.buttonNo5.TabIndex = 11;
            this.buttonNo5.Text = "5";
            this.buttonNo5.UseVisualStyleBackColor = false;
            this.buttonNo5.Click += new System.EventHandler(this.buttonNo5_Click);
            // 
            // buttonNo0
            // 
            this.buttonNo0.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo0.Location = new System.Drawing.Point(130, 323);
            this.buttonNo0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo0.Name = "buttonNo0";
            this.buttonNo0.Size = new System.Drawing.Size(109, 75);
            this.buttonNo0.TabIndex = 13;
            this.buttonNo0.Text = "0";
            this.buttonNo0.UseVisualStyleBackColor = false;
            this.buttonNo0.Click += new System.EventHandler(this.buttonNo0_Click);
            // 
            // buttonNo6
            // 
            this.buttonNo6.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo6.Location = new System.Drawing.Point(243, 161);
            this.buttonNo6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo6.Name = "buttonNo6";
            this.buttonNo6.Size = new System.Drawing.Size(109, 75);
            this.buttonNo6.TabIndex = 12;
            this.buttonNo6.Text = "6";
            this.buttonNo6.UseVisualStyleBackColor = false;
            this.buttonNo6.Click += new System.EventHandler(this.buttonNo6_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(7, 694);
            this.taxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(91, 29);
            this.taxLabel.TabIndex = 25;
            this.taxLabel.Text = "Pajak: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(5, 734);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(125, 38);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total: 0";
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueLabel.Location = new System.Drawing.Point(134, 705);
            this.queueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(245, 74);
            this.queueLabel.TabIndex = 26;
            this.queueLabel.Text = "Queue:";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 781);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.displayView);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchByIdButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.totalLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.displayView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView displayView;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Button searchByIdButton;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button splitPaymentButton;
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
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label queueLabel;
    }
}

