namespace MAPMAClient.GUI {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnMMCreateBooking = new System.Windows.Forms.Button();
            this.btnMMCreateEscapeRoom = new System.Windows.Forms.Button();
            this.btnReadBookings = new System.Windows.Forms.Button();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.txbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMMCreateBooking
            // 
            this.btnMMCreateBooking.Location = new System.Drawing.Point(30, 57);
            this.btnMMCreateBooking.Name = "btnMMCreateBooking";
            this.btnMMCreateBooking.Size = new System.Drawing.Size(166, 76);
            this.btnMMCreateBooking.TabIndex = 0;
            this.btnMMCreateBooking.Text = "Lave en booking";
            this.btnMMCreateBooking.UseVisualStyleBackColor = true;
            this.btnMMCreateBooking.Click += new System.EventHandler(this.btnMMCreateBooking_Click);
            // 
            // btnMMCreateEscapeRoom
            // 
            this.btnMMCreateEscapeRoom.Location = new System.Drawing.Point(30, 170);
            this.btnMMCreateEscapeRoom.Name = "btnMMCreateEscapeRoom";
            this.btnMMCreateEscapeRoom.Size = new System.Drawing.Size(166, 76);
            this.btnMMCreateEscapeRoom.TabIndex = 1;
            this.btnMMCreateEscapeRoom.Text = "Escaperooms";
            this.btnMMCreateEscapeRoom.UseVisualStyleBackColor = true;
            this.btnMMCreateEscapeRoom.Click += new System.EventHandler(this.btnMMCreateEscapeRoom_Click);
            // 
            // btnReadBookings
            // 
            this.btnReadBookings.Location = new System.Drawing.Point(30, 285);
            this.btnReadBookings.Name = "btnReadBookings";
            this.btnReadBookings.Size = new System.Drawing.Size(166, 76);
            this.btnReadBookings.TabIndex = 2;
            this.btnReadBookings.Text = "Bookinger";
            this.btnReadBookings.UseVisualStyleBackColor = true;
            this.btnReadBookings.Click += new System.EventHandler(this.btnReadBookings_Click);
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(214, 57);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.ReadOnly = true;
            this.dgvStatistic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStatistic.Size = new System.Drawing.Size(655, 304);
            this.dgvStatistic.TabIndex = 3;
            // 
            // txbSearch
            // 
            this.txbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbSearch.Location = new System.Drawing.Point(214, 22);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(245, 20);
            this.txbSearch.TabIndex = 4;
            this.txbSearch.Text = "søg";
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSearch_MouseClick);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 392);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.btnReadBookings);
            this.Controls.Add(this.btnMMCreateEscapeRoom);
            this.Controls.Add(this.btnMMCreateBooking);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMMCreateBooking;
        private System.Windows.Forms.Button btnMMCreateEscapeRoom;
        private System.Windows.Forms.Button btnReadBookings;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.TextBox txbSearch;
    }
}