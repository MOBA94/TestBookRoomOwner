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
            this.btnFindPicture = new System.Windows.Forms.Button();
            this.pbEscaperoom = new System.Windows.Forms.PictureBox();
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
            this.cleanTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escapeRoomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxClearTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escapeRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.escapeRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDoneCreateEscapeRoom = new System.Windows.Forms.Button();
            this.btnBackCreateEscapeRoom = new System.Windows.Forms.Button();
            this.escapeRoomServicesClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscaperoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomServicesClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(8, 76);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Navn :";
            this.lblName.UseMnemonic = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 127);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Beskrivelse :";
            // 
            // lblMaxClearTime
            // 
            this.lblMaxClearTime.AutoSize = true;
            this.lblMaxClearTime.Location = new System.Drawing.Point(8, 241);
            this.lblMaxClearTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxClearTime.Name = "lblMaxClearTime";
            this.lblMaxClearTime.Size = new System.Drawing.Size(157, 17);
            this.lblMaxClearTime.TabIndex = 3;
            this.lblMaxClearTime.Text = "Max gennemførsels tid :";
            // 
            // lblCleanTime
            // 
            this.lblCleanTime.AutoSize = true;
            this.lblCleanTime.Location = new System.Drawing.Point(8, 290);
            this.lblCleanTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCleanTime.Name = "lblCleanTime";
            this.lblCleanTime.Size = new System.Drawing.Size(103, 17);
            this.lblCleanTime.TabIndex = 4;
            this.lblCleanTime.Text = "Klargøringstid :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 345);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Pris :";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(8, 396);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(151, 17);
            this.lblEmployeeID.TabIndex = 6;
            this.lblEmployeeID.Text = "Medarbejder nummer :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 22);
            this.txtName.TabIndex = 8;
            this.txtName.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindPicture);
            this.groupBox1.Controls.Add(this.pbEscaperoom);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(480, 740);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnFindPicture
            // 
            this.btnFindPicture.Location = new System.Drawing.Point(304, 450);
            this.btnFindPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindPicture.Name = "btnFindPicture";
            this.btnFindPicture.Size = new System.Drawing.Size(143, 28);
            this.btnFindPicture.TabIndex = 19;
            this.btnFindPicture.Text = "Find billede";
            this.btnFindPicture.UseVisualStyleBackColor = true;
            this.btnFindPicture.Click += new System.EventHandler(this.btnFindPicture_Click);
            // 
            // pbEscaperoom
            // 
            this.pbEscaperoom.Location = new System.Drawing.Point(8, 450);
            this.pbEscaperoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEscaperoom.Name = "pbEscaperoom";
            this.pbEscaperoom.Size = new System.Drawing.Size(267, 246);
            this.pbEscaperoom.TabIndex = 18;
            this.pbEscaperoom.TabStop = false;
            // 
            // lblShowEscapeRoomID
            // 
            this.lblShowEscapeRoomID.AutoSize = true;
            this.lblShowEscapeRoomID.Location = new System.Drawing.Point(165, 23);
            this.lblShowEscapeRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowEscapeRoomID.Name = "lblShowEscapeRoomID";
            this.lblShowEscapeRoomID.Size = new System.Drawing.Size(0, 17);
            this.lblShowEscapeRoomID.TabIndex = 17;
            // 
            // lblEscapeRoomID
            // 
            this.lblEscapeRoomID.AutoSize = true;
            this.lblEscapeRoomID.Location = new System.Drawing.Point(8, 23);
            this.lblEscapeRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscapeRoomID.Name = "lblEscapeRoomID";
            this.lblEscapeRoomID.Size = new System.Drawing.Size(113, 17);
            this.lblEscapeRoomID.TabIndex = 16;
            this.lblEscapeRoomID.Text = "EscapeRoomID :";
            // 
            // btnDeleteEscapeRoom
            // 
            this.btnDeleteEscapeRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteEscapeRoom.Location = new System.Drawing.Point(169, 704);
            this.btnDeleteEscapeRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEscapeRoom.Name = "btnDeleteEscapeRoom";
            this.btnDeleteEscapeRoom.Size = new System.Drawing.Size(127, 28);
            this.btnDeleteEscapeRoom.TabIndex = 1;
            this.btnDeleteEscapeRoom.Text = "Slet";
            this.btnDeleteEscapeRoom.UseVisualStyleBackColor = false;
            this.btnDeleteEscapeRoom.Click += new System.EventHandler(this.btnDeleteEscapeRoom_Click);
            // 
            // btnCreateEscapeRoom
            // 
            this.btnCreateEscapeRoom.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCreateEscapeRoom.Location = new System.Drawing.Point(304, 704);
            this.btnCreateEscapeRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateEscapeRoom.Name = "btnCreateEscapeRoom";
            this.btnCreateEscapeRoom.Size = new System.Drawing.Size(143, 28);
            this.btnCreateEscapeRoom.TabIndex = 15;
            this.btnCreateEscapeRoom.Text = "Opret";
            this.btnCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnCreateEscapeRoom.Click += new System.EventHandler(this.btnCreateEscapeRoom_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(169, 127);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(276, 95);
            this.txbDescription.TabIndex = 14;
            this.txbDescription.Text = "";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(169, 393);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(276, 22);
            this.txtEmployeeID.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(169, 341);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(276, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtCleanTime
            // 
            this.txtCleanTime.Location = new System.Drawing.Point(169, 287);
            this.txtCleanTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCleanTime.Name = "txtCleanTime";
            this.txtCleanTime.Size = new System.Drawing.Size(276, 22);
            this.txtCleanTime.TabIndex = 11;
            // 
            // txtMaxClearTime
            // 
            this.txtMaxClearTime.Location = new System.Drawing.Point(169, 238);
            this.txtMaxClearTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxClearTime.Name = "txtMaxClearTime";
            this.txtMaxClearTime.Size = new System.Drawing.Size(276, 22);
            this.txtMaxClearTime.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(512, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1031, 697);
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
            this.cleanTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.empDataGridViewTextBoxColumn,
            this.escapeRoomIDDataGridViewTextBoxColumn,
            this.maxClearTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.escapeRoomBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 666);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cleanTimeDataGridViewTextBoxColumn
            // 
            this.cleanTimeDataGridViewTextBoxColumn.DataPropertyName = "cleanTime";
            this.cleanTimeDataGridViewTextBoxColumn.HeaderText = "cleanTime";
            this.cleanTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cleanTimeDataGridViewTextBoxColumn.Name = "cleanTimeDataGridViewTextBoxColumn";
            this.cleanTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleanTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // empDataGridViewTextBoxColumn
            // 
            this.empDataGridViewTextBoxColumn.DataPropertyName = "emp";
            this.empDataGridViewTextBoxColumn.HeaderText = "emp";
            this.empDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empDataGridViewTextBoxColumn.Name = "empDataGridViewTextBoxColumn";
            this.empDataGridViewTextBoxColumn.ReadOnly = true;
            this.empDataGridViewTextBoxColumn.Width = 125;
            // 
            // escapeRoomIDDataGridViewTextBoxColumn
            // 
            this.escapeRoomIDDataGridViewTextBoxColumn.DataPropertyName = "escapeRoomID";
            this.escapeRoomIDDataGridViewTextBoxColumn.HeaderText = "escapeRoomID";
            this.escapeRoomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.escapeRoomIDDataGridViewTextBoxColumn.Name = "escapeRoomIDDataGridViewTextBoxColumn";
            this.escapeRoomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.escapeRoomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxClearTimeDataGridViewTextBoxColumn
            // 
            this.maxClearTimeDataGridViewTextBoxColumn.DataPropertyName = "maxClearTime";
            this.maxClearTimeDataGridViewTextBoxColumn.HeaderText = "maxClearTime";
            this.maxClearTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxClearTimeDataGridViewTextBoxColumn.Name = "maxClearTimeDataGridViewTextBoxColumn";
            this.maxClearTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxClearTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Width = 125;
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
            this.btnDoneCreateEscapeRoom.Location = new System.Drawing.Point(1431, 719);
            this.btnDoneCreateEscapeRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoneCreateEscapeRoom.Name = "btnDoneCreateEscapeRoom";
            this.btnDoneCreateEscapeRoom.Size = new System.Drawing.Size(100, 28);
            this.btnDoneCreateEscapeRoom.TabIndex = 11;
            this.btnDoneCreateEscapeRoom.Text = "Færdig";
            this.btnDoneCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnDoneCreateEscapeRoom.Click += new System.EventHandler(this.btnDoneCreateEscapeRoom_Click);
            // 
            // btnBackCreateEscapeRoom
            // 
            this.btnBackCreateEscapeRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackCreateEscapeRoom.Location = new System.Drawing.Point(1293, 719);
            this.btnBackCreateEscapeRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackCreateEscapeRoom.Name = "btnBackCreateEscapeRoom";
            this.btnBackCreateEscapeRoom.Size = new System.Drawing.Size(100, 28);
            this.btnBackCreateEscapeRoom.TabIndex = 12;
            this.btnBackCreateEscapeRoom.Text = "Tilbage";
            this.btnBackCreateEscapeRoom.UseVisualStyleBackColor = false;
            this.btnBackCreateEscapeRoom.Click += new System.EventHandler(this.btnBackCreateEscapeRoom_Click);
            // 
            // escapeRoomServicesClientBindingSource
            // 
            this.escapeRoomServicesClientBindingSource.DataSource = typeof(MAPMAClient.EscRef.EscapeRoom_ServicesClient);
            // 
            // checkListBindingSource
            // 
            this.checkListBindingSource.DataMember = "checkList";
            this.checkListBindingSource.DataSource = this.escapeRoomBindingSource1;
            // 
            // CreateEscapeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 804);
            this.Controls.Add(this.btnBackCreateEscapeRoom);
            this.Controls.Add(this.btnDoneCreateEscapeRoom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateEscapeRoom";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CreateEscapeRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscaperoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escapeRoomServicesClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escapeRoomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxClearTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource escapeRoomServicesClientBindingSource;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private System.Windows.Forms.Button btnFindPicture;
        private System.Windows.Forms.PictureBox pbEscaperoom;
    }
}