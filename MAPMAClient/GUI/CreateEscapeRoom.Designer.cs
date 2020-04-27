namespace MAPMAClient.GUI
{
    partial class CreateEscapeRoom
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMaxClearTime = new System.Windows.Forms.Label();
            this.lblCleanTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShowEscapeRoomID = new System.Windows.Forms.Label();
            this.lblEscapeRoomID = new System.Windows.Forms.Label();
            this.btnDeleteEscapeRoom = new System.Windows.Forms.Button();
            this.btnCreateEscapeRoom = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCleanTime = new System.Windows.Forms.TextBox();
            this.txtMaxClearTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.escapeRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxClearTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escapeRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.escapeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDoneCreateEscapeRoom = new System.Windows.Forms.Button();
            this.btnBackCreateEscapeRoom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(6, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Navn :";
            this.lblName.UseMnemonic = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beskrivelse :";
            // 
            // lblMaxClearTime
            // 
            this.lblMaxClearTime.AutoSize = true;
            this.lblMaxClearTime.Location = new System.Drawing.Point(6, 196);
            this.lblMaxClearTime.Name = "lblMaxClearTime";
            this.lblMaxClearTime.Size = new System.Drawing.Size(118, 13);
            this.lblMaxClearTime.TabIndex = 3;
            this.lblMaxClearTime.Text = "Max gennemførsels tid :";
            // 
            // lblCleanTime
            // 
            this.lblCleanTime.AutoSize = true;
            this.lblCleanTime.Location = new System.Drawing.Point(6, 236);
            this.lblCleanTime.Name = "lblCleanTime";
            this.lblCleanTime.Size = new System.Drawing.Size(76, 13);
            this.lblCleanTime.TabIndex = 4;
            this.lblCleanTime.Text = "Klargøringstid :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 280);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Pris :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(6, 322);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(112, 13);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Medarbejder nummer :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowEscapeRoomID);
            this.groupBox1.Controls.Add(this.lblEscapeRoomID);
            this.groupBox1.Controls.Add(this.btnDeleteEscapeRoom);
            this.groupBox1.Controls.Add(this.btnCreateEscapeRoom);
            this.groupBox1.Controls.Add(this.txbDescription);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtCleanTime);
            this.groupBox1.Controls.Add(this.txtMaxClearTime);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblMaxClearTime);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.lblCleanTime);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 393);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblShowEscapeRoomID
            // 
            this.lblShowEscapeRoomID.AutoSize = true;
            this.lblShowEscapeRoomID.Location = new System.Drawing.Point(124, 19);
            this.lblShowEscapeRoomID.Name = "lblShowEscapeRoomID";
            this.lblShowEscapeRoomID.Size = new System.Drawing.Size(0, 13);
            this.lblShowEscapeRoomID.TabIndex = 17;
            // 
            // lblEscapeRoomID
            // 
            this.lblEscapeRoomID.AutoSize = true;
            this.lblEscapeRoomID.Location = new System.Drawing.Point(6, 19);
            this.lblEscapeRoomID.Name = "lblEscapeRoomID";
            this.lblEscapeRoomID.Size = new System.Drawing.Size(88, 13);
            this.lblEscapeRoomID.TabIndex = 16;
            this.lblEscapeRoomID.Text = "EscapeRoomID :";
            // 
            // btnDeleteEscapeRoom
            // 
            this.btnDeleteEscapeRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteEscapeRoom.Location = new System.Drawing.Point(127, 354);
            this.btnDeleteEscapeRoom.Name = "btnDeleteEscapeRoom";
            this.btnDeleteEscapeRoom.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteEscapeRoom.TabIndex = 1;
            this.btnDeleteEscapeRoom.Text = "Slet";
            this.btnDeleteEscapeRoom.UseVisualStyleBackColor = false;
            // 
            // btnCreateEscapeRoom
            // 
            this.btnCreateEscapeRoom.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCreateEscapeRoom.Location = new System.Drawing.Point(228, 354);
            this.btnCreateEscapeRoom.Name = "btnCreateEscapeRoom";
            this.btnCreateEscapeRoom.Size = new System.Drawing.Size(107, 23);
            this.btnCreateEscapeRoom.TabIndex = 15;
            this.btnCreateEscapeRoom.Text = "Opret";
            this.btnCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnCreateEscapeRoom.Click += new System.EventHandler(this.btnCreateEscapeRoom_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(127, 103);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(208, 78);
            this.txbDescription.TabIndex = 14;
            this.txbDescription.Text = "";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(127, 319);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(208, 20);
            this.txtEmployeeID.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtCleanTime
            // 
            this.txtCleanTime.Location = new System.Drawing.Point(127, 233);
            this.txtCleanTime.Name = "txtCleanTime";
            this.txtCleanTime.Size = new System.Drawing.Size(208, 20);
            this.txtCleanTime.TabIndex = 11;
            // 
            // txtMaxClearTime
            // 
            this.txtMaxClearTime.Location = new System.Drawing.Point(127, 193);
            this.txtMaxClearTime.Name = "txtMaxClearTime";
            this.txtMaxClearTime.Size = new System.Drawing.Size(208, 20);
            this.txtMaxClearTime.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(384, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 393);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.escapeRoomIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.maxClearTimeDataGridViewTextBoxColumn,
            this.cleanTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.escapeRoomBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // escapeRoomIDDataGridViewTextBoxColumn
            // 
            this.escapeRoomIDDataGridViewTextBoxColumn.DataPropertyName = "escapeRoomID";
            this.escapeRoomIDDataGridViewTextBoxColumn.HeaderText = "escapeRoomID";
            this.escapeRoomIDDataGridViewTextBoxColumn.Name = "escapeRoomIDDataGridViewTextBoxColumn";
            this.escapeRoomIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Navn";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Beskrivelse";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // maxClearTimeDataGridViewTextBoxColumn
            // 
            this.maxClearTimeDataGridViewTextBoxColumn.DataPropertyName = "maxClearTime";
            this.maxClearTimeDataGridViewTextBoxColumn.HeaderText = "Max gennemførsels tid";
            this.maxClearTimeDataGridViewTextBoxColumn.Name = "maxClearTimeDataGridViewTextBoxColumn";
            this.maxClearTimeDataGridViewTextBoxColumn.Width = 85;
            // 
            // cleanTimeDataGridViewTextBoxColumn
            // 
            this.cleanTimeDataGridViewTextBoxColumn.DataPropertyName = "cleanTime";
            this.cleanTimeDataGridViewTextBoxColumn.HeaderText = "Klargøringstid";
            this.cleanTimeDataGridViewTextBoxColumn.Name = "cleanTimeDataGridViewTextBoxColumn";
            this.cleanTimeDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // escapeRoomBindingSource1
            // 
            this.escapeRoomBindingSource1.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom);
            // 
            // escapeRoomBindingSource
            // 
            this.escapeRoomBindingSource.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom);
            // 
            // btnDoneCreateEscapeRoom
            // 
            this.btnDoneCreateEscapeRoom.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDoneCreateEscapeRoom.Location = new System.Drawing.Point(1082, 415);
            this.btnDoneCreateEscapeRoom.Name = "btnDoneCreateEscapeRoom";
            this.btnDoneCreateEscapeRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDoneCreateEscapeRoom.TabIndex = 11;
            this.btnDoneCreateEscapeRoom.Text = "Færdig";
            this.btnDoneCreateEscapeRoom.UseVisualStyleBackColor = false;
            // 
            // btnBackCreateEscapeRoom
            // 
            this.btnBackCreateEscapeRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackCreateEscapeRoom.Location = new System.Drawing.Point(1001, 415);
            this.btnBackCreateEscapeRoom.Name = "btnBackCreateEscapeRoom";
            this.btnBackCreateEscapeRoom.Size = new System.Drawing.Size(75, 23);
            this.btnBackCreateEscapeRoom.TabIndex = 12;
            this.btnBackCreateEscapeRoom.Text = "Tilbage";
            this.btnBackCreateEscapeRoom.UseVisualStyleBackColor = false;
            // 
            // CreateEscapeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.btnBackCreateEscapeRoom);
            this.Controls.Add(this.btnDoneCreateEscapeRoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateEscapeRoom";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CreateEscapeRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMaxClearTime;
        private System.Windows.Forms.Label lblCleanTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateEscapeRoom;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCleanTime;
        private System.Windows.Forms.TextBox txtMaxClearTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource escapeRoomBindingSource;
        private System.Windows.Forms.Button btnDoneCreateEscapeRoom;
        private System.Windows.Forms.Button btnBackCreateEscapeRoom;
        private System.Windows.Forms.BindingSource escapeRoomBindingSource1;
        private System.Windows.Forms.Button btnDeleteEscapeRoom;
        private System.Windows.Forms.Label lblShowEscapeRoomID;
        private System.Windows.Forms.Label lblEscapeRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn escapeRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxClearTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}