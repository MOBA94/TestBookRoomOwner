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
            this.SuspendLayout();
            // 
            // btnMMCreateBooking
            // 
            this.btnMMCreateBooking.Location = new System.Drawing.Point(30, 24);
            this.btnMMCreateBooking.Name = "btnMMCreateBooking";
            this.btnMMCreateBooking.Size = new System.Drawing.Size(166, 76);
            this.btnMMCreateBooking.TabIndex = 0;
            this.btnMMCreateBooking.Text = "Lave en booking";
            this.btnMMCreateBooking.UseVisualStyleBackColor = true;
            this.btnMMCreateBooking.Click += new System.EventHandler(this.btnMMCreateBooking_Click);
            // 
            // btnMMCreateEscapeRoom
            // 
            this.btnMMCreateEscapeRoom.Location = new System.Drawing.Point(30, 137);
            this.btnMMCreateEscapeRoom.Name = "btnMMCreateEscapeRoom";
            this.btnMMCreateEscapeRoom.Size = new System.Drawing.Size(166, 76);
            this.btnMMCreateEscapeRoom.TabIndex = 1;
            this.btnMMCreateEscapeRoom.Text = "Opret nyt EscapeRoom";
            this.btnMMCreateEscapeRoom.UseVisualStyleBackColor = true;
            this.btnMMCreateEscapeRoom.Click += new System.EventHandler(this.btnMMCreateEscapeRoom_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMMCreateEscapeRoom);
            this.Controls.Add(this.btnMMCreateBooking);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMMCreateBooking;
        private System.Windows.Forms.Button btnMMCreateEscapeRoom;
    }
}