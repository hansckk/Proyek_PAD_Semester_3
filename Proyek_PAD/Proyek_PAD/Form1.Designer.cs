
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.buttonNo1 = new System.Windows.Forms.Button();
            this.buttonNo2 = new System.Windows.Forms.Button();
            this.buttonNo3 = new System.Windows.Forms.Button();
            this.buttonNo6 = new System.Windows.Forms.Button();
            this.buttonNo5 = new System.Windows.Forms.Button();
            this.buttonNo4 = new System.Windows.Forms.Button();
            this.buttonNo9 = new System.Windows.Forms.Button();
            this.buttonNo7 = new System.Windows.Forms.Button();
            this.buttonNo0 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttonNo8 = new System.Windows.Forms.Button();
            this.splitPaymentButton = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(859, 531);
            this.dataGridView1.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clearButton.Location = new System.Drawing.Point(876, 392);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 75);
            this.clearButton.TabIndex = 2;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.LightGreen;
            this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
            this.acceptButton.Location = new System.Drawing.Point(876, 473);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(312, 75);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(1088, 392);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 75);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(5, 634);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(125, 38);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total: 0";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(876, 98);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(312, 45);
            this.idTextBox.TabIndex = 6;
            // 
            // buttonNo1
            // 
            this.buttonNo1.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo1.Location = new System.Drawing.Point(876, 149);
            this.buttonNo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo1.Name = "buttonNo1";
            this.buttonNo1.Size = new System.Drawing.Size(100, 75);
            this.buttonNo1.TabIndex = 7;
            this.buttonNo1.Text = "1";
            this.buttonNo1.UseVisualStyleBackColor = false;
            this.buttonNo1.Click += new System.EventHandler(this.buttonNo1_Click);
            // 
            // buttonNo2
            // 
            this.buttonNo2.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo2.Location = new System.Drawing.Point(982, 149);
            this.buttonNo2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo2.Name = "buttonNo2";
            this.buttonNo2.Size = new System.Drawing.Size(100, 75);
            this.buttonNo2.TabIndex = 8;
            this.buttonNo2.Text = "2";
            this.buttonNo2.UseVisualStyleBackColor = false;
            this.buttonNo2.Click += new System.EventHandler(this.buttonNo2_Click);
            // 
            // buttonNo3
            // 
            this.buttonNo3.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo3.Location = new System.Drawing.Point(1088, 149);
            this.buttonNo3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo3.Name = "buttonNo3";
            this.buttonNo3.Size = new System.Drawing.Size(100, 75);
            this.buttonNo3.TabIndex = 9;
            this.buttonNo3.Text = "3";
            this.buttonNo3.UseVisualStyleBackColor = false;
            this.buttonNo3.Click += new System.EventHandler(this.buttonNo3_Click);
            // 
            // buttonNo6
            // 
            this.buttonNo6.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo6.Location = new System.Drawing.Point(1088, 230);
            this.buttonNo6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo6.Name = "buttonNo6";
            this.buttonNo6.Size = new System.Drawing.Size(100, 75);
            this.buttonNo6.TabIndex = 12;
            this.buttonNo6.Text = "6";
            this.buttonNo6.UseVisualStyleBackColor = false;
            this.buttonNo6.Click += new System.EventHandler(this.buttonNo6_Click);
            // 
            // buttonNo5
            // 
            this.buttonNo5.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo5.Location = new System.Drawing.Point(982, 230);
            this.buttonNo5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo5.Name = "buttonNo5";
            this.buttonNo5.Size = new System.Drawing.Size(100, 75);
            this.buttonNo5.TabIndex = 11;
            this.buttonNo5.Text = "5";
            this.buttonNo5.UseVisualStyleBackColor = false;
            this.buttonNo5.Click += new System.EventHandler(this.buttonNo5_Click);
            // 
            // buttonNo4
            // 
            this.buttonNo4.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo4.Location = new System.Drawing.Point(876, 230);
            this.buttonNo4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo4.Name = "buttonNo4";
            this.buttonNo4.Size = new System.Drawing.Size(100, 75);
            this.buttonNo4.TabIndex = 10;
            this.buttonNo4.Text = "4";
            this.buttonNo4.UseVisualStyleBackColor = false;
            this.buttonNo4.Click += new System.EventHandler(this.buttonNo4_Click);
            // 
            // buttonNo9
            // 
            this.buttonNo9.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo9.Location = new System.Drawing.Point(1088, 311);
            this.buttonNo9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo9.Name = "buttonNo9";
            this.buttonNo9.Size = new System.Drawing.Size(100, 75);
            this.buttonNo9.TabIndex = 15;
            this.buttonNo9.Text = "9";
            this.buttonNo9.UseVisualStyleBackColor = false;
            this.buttonNo9.Click += new System.EventHandler(this.buttonNo9_Click);
            // 
            // buttonNo7
            // 
            this.buttonNo7.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo7.Location = new System.Drawing.Point(876, 311);
            this.buttonNo7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo7.Name = "buttonNo7";
            this.buttonNo7.Size = new System.Drawing.Size(100, 75);
            this.buttonNo7.TabIndex = 14;
            this.buttonNo7.Text = "7";
            this.buttonNo7.UseVisualStyleBackColor = false;
            this.buttonNo7.Click += new System.EventHandler(this.buttonNo7_Click);
            // 
            // buttonNo0
            // 
            this.buttonNo0.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo0.Location = new System.Drawing.Point(982, 392);
            this.buttonNo0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo0.Name = "buttonNo0";
            this.buttonNo0.Size = new System.Drawing.Size(100, 75);
            this.buttonNo0.TabIndex = 13;
            this.buttonNo0.Text = "0";
            this.buttonNo0.UseVisualStyleBackColor = false;
            this.buttonNo0.Click += new System.EventHandler(this.buttonNo0_Click);
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
            // buttonNo8
            // 
            this.buttonNo8.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNo8.Location = new System.Drawing.Point(982, 311);
            this.buttonNo8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonNo8.Name = "buttonNo8";
            this.buttonNo8.Size = new System.Drawing.Size(100, 75);
            this.buttonNo8.TabIndex = 18;
            this.buttonNo8.Text = "8";
            this.buttonNo8.UseVisualStyleBackColor = false;
            this.buttonNo8.Click += new System.EventHandler(this.buttonNo8_Click);
            // 
            // splitPaymentButton
            // 
            this.splitPaymentButton.BackColor = System.Drawing.Color.GhostWhite;
            this.splitPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitPaymentButton.Location = new System.Drawing.Point(876, 554);
            this.splitPaymentButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitPaymentButton.Name = "splitPaymentButton";
            this.splitPaymentButton.Size = new System.Drawing.Size(312, 75);
            this.splitPaymentButton.TabIndex = 19;
            this.splitPaymentButton.Text = "SPLIT PAYMENT";
            this.splitPaymentButton.UseVisualStyleBackColor = false;
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 688);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.splitPaymentButton);
            this.Controls.Add(this.buttonNo8);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.buttonNo9);
            this.Controls.Add(this.buttonNo7);
            this.Controls.Add(this.buttonNo0);
            this.Controls.Add(this.buttonNo6);
            this.Controls.Add(this.buttonNo5);
            this.Controls.Add(this.buttonNo4);
            this.Controls.Add(this.buttonNo3);
            this.Controls.Add(this.buttonNo2);
            this.Controls.Add(this.buttonNo1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button buttonNo1;
        private System.Windows.Forms.Button buttonNo2;
        private System.Windows.Forms.Button buttonNo3;
        private System.Windows.Forms.Button buttonNo6;
        private System.Windows.Forms.Button buttonNo5;
        private System.Windows.Forms.Button buttonNo4;
        private System.Windows.Forms.Button buttonNo9;
        private System.Windows.Forms.Button buttonNo7;
        private System.Windows.Forms.Button buttonNo0;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button buttonNo8;
        private System.Windows.Forms.Button splitPaymentButton;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

