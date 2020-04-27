namespace MAPMAClient.GUI {
    partial class Form1 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbxEsc = new System.Windows.Forms.ListBox();
            this.lblEsc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            //this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbxEsc
            // 
            this.lbxEsc.FormattingEnabled = true;
            this.lbxEsc.Location = new System.Drawing.Point(59, 47);
            this.lbxEsc.Name = "lbxEsc";
            this.lbxEsc.Size = new System.Drawing.Size(294, 173);
            this.lbxEsc.TabIndex = 2;
            // 
            // lblEsc
            // 
            this.lblEsc.AutoSize = true;
            this.lblEsc.Location = new System.Drawing.Point(460, 105);
            this.lblEsc.Name = "lblEsc";
            this.lblEsc.Size = new System.Drawing.Size(35, 13);
            this.lblEsc.TabIndex = 3;
            this.lblEsc.Text = "label1";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(463, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblEsc);
            this.Controls.Add(this.lbxEsc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbxEsc;
        private System.Windows.Forms.Label lblEsc;
        private System.Windows.Forms.TextBox txtID;
    }
}

