
namespace Proyek_PAD
{
    partial class details_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(details_form));
            this.menuLabel = new System.Windows.Forms.Label();
            this.diskonLabel = new System.Windows.Forms.Label();
            this.ppnLabel = new System.Windows.Forms.Label();
            this.totalMenuLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.extraChargeLabel = new System.Windows.Forms.Label();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.paymentMethod2Label = new System.Windows.Forms.Label();
            this.totalPaymentMethod1Label = new System.Windows.Forms.Label();
            this.totalPaymentMethod2Label = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.menuDataGridView = new System.Windows.Forms.DataGridView();
            this.extraChargeDataGridView = new System.Windows.Forms.DataGridView();
            this.detailOrderLabel = new System.Windows.Forms.Label();
            this.totalOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraChargeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(7, 81);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(68, 25);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Menu:";
            // 
            // diskonLabel
            // 
            this.diskonLabel.AutoSize = true;
            this.diskonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diskonLabel.Location = new System.Drawing.Point(477, 159);
            this.diskonLabel.Name = "diskonLabel";
            this.diskonLabel.Size = new System.Drawing.Size(83, 25);
            this.diskonLabel.TabIndex = 3;
            this.diskonLabel.Text = "Diskon: ";
            this.diskonLabel.Visible = false;
            // 
            // ppnLabel
            // 
            this.ppnLabel.AutoSize = true;
            this.ppnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppnLabel.Location = new System.Drawing.Point(477, 134);
            this.ppnLabel.Name = "ppnLabel";
            this.ppnLabel.Size = new System.Drawing.Size(103, 25);
            this.ppnLabel.TabIndex = 4;
            this.ppnLabel.Text = "PPN 12%:";
            // 
            // totalMenuLabel
            // 
            this.totalMenuLabel.AutoSize = true;
            this.totalMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMenuLabel.Location = new System.Drawing.Point(477, 109);
            this.totalMenuLabel.Name = "totalMenuLabel";
            this.totalMenuLabel.Size = new System.Drawing.Size(122, 25);
            this.totalMenuLabel.TabIndex = 5;
            this.totalMenuLabel.Text = "Total Menu: ";
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Green;
            this.acceptButton.Image = ((System.Drawing.Image)(resources.GetObject("acceptButton.Image")));
            this.acceptButton.Location = new System.Drawing.Point(12, 483);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(144, 87);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(520, 483);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(144, 87);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // extraChargeLabel
            // 
            this.extraChargeLabel.AutoSize = true;
            this.extraChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraChargeLabel.Location = new System.Drawing.Point(7, 241);
            this.extraChargeLabel.Name = "extraChargeLabel";
            this.extraChargeLabel.Size = new System.Drawing.Size(133, 25);
            this.extraChargeLabel.TabIndex = 9;
            this.extraChargeLabel.Text = "Extra Charge:";
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodLabel.Location = new System.Drawing.Point(477, 269);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(171, 25);
            this.paymentMethodLabel.TabIndex = 10;
            this.paymentMethodLabel.Text = "Payment Method: ";
            // 
            // paymentMethod2Label
            // 
            this.paymentMethod2Label.AutoSize = true;
            this.paymentMethod2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethod2Label.Location = new System.Drawing.Point(477, 319);
            this.paymentMethod2Label.Name = "paymentMethod2Label";
            this.paymentMethod2Label.Size = new System.Drawing.Size(187, 25);
            this.paymentMethod2Label.TabIndex = 11;
            this.paymentMethod2Label.Text = "Payment Method 2: ";
            this.paymentMethod2Label.Visible = false;
            // 
            // totalPaymentMethod1Label
            // 
            this.totalPaymentMethod1Label.AutoSize = true;
            this.totalPaymentMethod1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaymentMethod1Label.Location = new System.Drawing.Point(477, 294);
            this.totalPaymentMethod1Label.Name = "totalPaymentMethod1Label";
            this.totalPaymentMethod1Label.Size = new System.Drawing.Size(62, 25);
            this.totalPaymentMethod1Label.TabIndex = 12;
            this.totalPaymentMethod1Label.Text = "Total:";
            this.totalPaymentMethod1Label.Visible = false;
            // 
            // totalPaymentMethod2Label
            // 
            this.totalPaymentMethod2Label.AutoSize = true;
            this.totalPaymentMethod2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaymentMethod2Label.Location = new System.Drawing.Point(477, 344);
            this.totalPaymentMethod2Label.Name = "totalPaymentMethod2Label";
            this.totalPaymentMethod2Label.Size = new System.Drawing.Size(62, 25);
            this.totalPaymentMethod2Label.TabIndex = 13;
            this.totalPaymentMethod2Label.Text = "Total:";
            this.totalPaymentMethod2Label.Visible = false;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(13, 41);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(70, 25);
            this.memberNameLabel.TabIndex = 14;
            this.memberNameLabel.Text = "Name:";
            this.memberNameLabel.Visible = false;
            // 
            // menuDataGridView
            // 
            this.menuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuDataGridView.Location = new System.Drawing.Point(12, 109);
            this.menuDataGridView.Name = "menuDataGridView";
            this.menuDataGridView.ReadOnly = true;
            this.menuDataGridView.RowHeadersWidth = 51;
            this.menuDataGridView.RowTemplate.Height = 24;
            this.menuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuDataGridView.Size = new System.Drawing.Size(459, 129);
            this.menuDataGridView.TabIndex = 15;
            // 
            // extraChargeDataGridView
            // 
            this.extraChargeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extraChargeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extraChargeDataGridView.Location = new System.Drawing.Point(12, 269);
            this.extraChargeDataGridView.Name = "extraChargeDataGridView";
            this.extraChargeDataGridView.ReadOnly = true;
            this.extraChargeDataGridView.RowHeadersWidth = 51;
            this.extraChargeDataGridView.RowTemplate.Height = 24;
            this.extraChargeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extraChargeDataGridView.Size = new System.Drawing.Size(459, 129);
            this.extraChargeDataGridView.TabIndex = 16;
            // 
            // detailOrderLabel
            // 
            this.detailOrderLabel.AutoSize = true;
            this.detailOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailOrderLabel.Location = new System.Drawing.Point(12, 9);
            this.detailOrderLabel.Name = "detailOrderLabel";
            this.detailOrderLabel.Size = new System.Drawing.Size(168, 32);
            this.detailOrderLabel.TabIndex = 0;
            this.detailOrderLabel.Text = "Detail Order";
            // 
            // totalOrderLabel
            // 
            this.totalOrderLabel.AutoSize = true;
            this.totalOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderLabel.Location = new System.Drawing.Point(6, 401);
            this.totalOrderLabel.Name = "totalOrderLabel";
            this.totalOrderLabel.Size = new System.Drawing.Size(114, 32);
            this.totalOrderLabel.TabIndex = 17;
            this.totalOrderLabel.Text = "TOTAL:";
            // 
            // details_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(673, 582);
            this.Controls.Add(this.totalOrderLabel);
            this.Controls.Add(this.extraChargeDataGridView);
            this.Controls.Add(this.menuDataGridView);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.totalPaymentMethod2Label);
            this.Controls.Add(this.totalPaymentMethod1Label);
            this.Controls.Add(this.paymentMethod2Label);
            this.Controls.Add(this.paymentMethodLabel);
            this.Controls.Add(this.extraChargeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.totalMenuLabel);
            this.Controls.Add(this.ppnLabel);
            this.Controls.Add(this.diskonLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.detailOrderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "details_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.details_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraChargeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label diskonLabel;
        private System.Windows.Forms.Label ppnLabel;
        private System.Windows.Forms.Label totalMenuLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label extraChargeLabel;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.Label paymentMethod2Label;
        private System.Windows.Forms.Label totalPaymentMethod1Label;
        private System.Windows.Forms.Label totalPaymentMethod2Label;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.DataGridView menuDataGridView;
        private System.Windows.Forms.DataGridView extraChargeDataGridView;
        private System.Windows.Forms.Label detailOrderLabel;
        private System.Windows.Forms.Label totalOrderLabel;
    }
}