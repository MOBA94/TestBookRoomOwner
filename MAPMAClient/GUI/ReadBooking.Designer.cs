namespace MAPMAClient.GUI
{
    partial class ReadBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAllBookings = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCloseReadBooking = new System.Windows.Forms.Button();
            this.txbSerchReadBooking = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBookings.Location = new System.Drawing.Point(12, 38);
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.Size = new System.Drawing.Size(629, 487);
            this.dgvAllBookings.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(1311, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Afslut";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(MAPMAClient.BookRef.Booking);
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataSource = typeof(MAPMAClient.BookRef.Booking);
            // 
            // btnCloseReadBooking
            // 
            this.btnCloseReadBooking.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCloseReadBooking.Location = new System.Drawing.Point(566, 536);
            this.btnCloseReadBooking.Name = "btnCloseReadBooking";
            this.btnCloseReadBooking.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReadBooking.TabIndex = 2;
            this.btnCloseReadBooking.Text = "Afslut";
            this.btnCloseReadBooking.UseVisualStyleBackColor = false;
            this.btnCloseReadBooking.Click += new System.EventHandler(this.btnCloseReadBooking_Click);
            // 
            // txbSerchReadBooking
            // 
            this.txbSerchReadBooking.Location = new System.Drawing.Point(13, 12);
            this.txbSerchReadBooking.Name = "txbSerchReadBooking";
            this.txbSerchReadBooking.Size = new System.Drawing.Size(182, 20);
            this.txbSerchReadBooking.TabIndex = 3;
            this.txbSerchReadBooking.TextChanged += new System.EventHandler(this.txbSerchReadBooking_TextChanged);
            // 
            // ReadBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 571);
            this.Controls.Add(this.txbSerchReadBooking);
            this.Controls.Add(this.btnCloseReadBooking);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvAllBookings);
            this.Name = "ReadBooking";
            this.Text = "ReadBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllBookings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private System.Windows.Forms.Button btnCloseReadBooking;
        private System.Windows.Forms.TextBox txbSerchReadBooking;
    }
}