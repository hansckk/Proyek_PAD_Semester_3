
namespace Proyek_PAD
{
    partial class laporan
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
            this.laporan_label = new System.Windows.Forms.Label();
            this.laporan_transaksi_btn = new System.Windows.Forms.Button();
            this.selled_menu_btn = new System.Windows.Forms.Button();
            this.best_seller_btn = new System.Windows.Forms.Button();
            this.laporan_btn = new System.Windows.Forms.Button();
            this.checklog_btn = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laporan_label
            // 
            this.laporan_label.AutoSize = true;
            this.laporan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporan_label.Location = new System.Drawing.Point(255, 9);
            this.laporan_label.Name = "laporan_label";
            this.laporan_label.Size = new System.Drawing.Size(182, 38);
            this.laporan_label.TabIndex = 0;
            this.laporan_label.Text = "LAPORAN";
            // 
            // laporan_transaksi_btn
            // 
            this.laporan_transaksi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.laporan_transaksi_btn.Location = new System.Drawing.Point(476, 157);
            this.laporan_transaksi_btn.Name = "laporan_transaksi_btn";
            this.laporan_transaksi_btn.Size = new System.Drawing.Size(225, 100);
            this.laporan_transaksi_btn.TabIndex = 1;
            this.laporan_transaksi_btn.Text = "LAPORAN TRANSAKSI";
            this.laporan_transaksi_btn.UseVisualStyleBackColor = true;
            // 
            // selled_menu_btn
            // 
            this.selled_menu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.selled_menu_btn.Location = new System.Drawing.Point(243, 157);
            this.selled_menu_btn.Name = "selled_menu_btn";
            this.selled_menu_btn.Size = new System.Drawing.Size(225, 100);
            this.selled_menu_btn.TabIndex = 2;
            this.selled_menu_btn.Text = "LAPORAN STOK MAKANAN";
            this.selled_menu_btn.UseVisualStyleBackColor = true;
            // 
            // best_seller_btn
            // 
            this.best_seller_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_seller_btn.Location = new System.Drawing.Point(12, 51);
            this.best_seller_btn.Name = "best_seller_btn";
            this.best_seller_btn.Size = new System.Drawing.Size(225, 100);
            this.best_seller_btn.TabIndex = 3;
            this.best_seller_btn.Text = "BEST SELLER OF THE MONTH";
            this.best_seller_btn.UseVisualStyleBackColor = true;
            // 
            // laporan_btn
            // 
            this.laporan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.laporan_btn.Location = new System.Drawing.Point(12, 157);
            this.laporan_btn.Name = "laporan_btn";
            this.laporan_btn.Size = new System.Drawing.Size(225, 100);
            this.laporan_btn.TabIndex = 4;
            this.laporan_btn.Text = "LAPORAN PENJUALAN HARIAN";
            this.laporan_btn.UseVisualStyleBackColor = true;
            // 
            // checklog_btn
            // 
            this.checklog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checklog_btn.Location = new System.Drawing.Point(243, 51);
            this.checklog_btn.Name = "checklog_btn";
            this.checklog_btn.Size = new System.Drawing.Size(225, 100);
            this.checklog_btn.TabIndex = 5;
            this.checklog_btn.Text = "CHECKLOG";
            this.checklog_btn.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.back_button.Location = new System.Drawing.Point(619, 9);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(80, 30);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 273);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.checklog_btn);
            this.Controls.Add(this.laporan_btn);
            this.Controls.Add(this.best_seller_btn);
            this.Controls.Add(this.selled_menu_btn);
            this.Controls.Add(this.laporan_transaksi_btn);
            this.Controls.Add(this.laporan_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laporan_label;
        private System.Windows.Forms.Button laporan_transaksi_btn;
        private System.Windows.Forms.Button selled_menu_btn;
        private System.Windows.Forms.Button best_seller_btn;
        private System.Windows.Forms.Button laporan_btn;
        private System.Windows.Forms.Button checklog_btn;
        private System.Windows.Forms.Button back_button;
    }
}