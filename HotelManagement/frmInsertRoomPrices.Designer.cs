namespace HotelManagement
{
    partial class frmInsertRoomPrices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCapacity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvRoomPrice = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsPricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new HotelManagement.Hotel_ManagementDataSet();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passengerTableAdapter = new HotelManagement.Hotel_ManagementDataSetTableAdapters.PassengerTableAdapter();
            this.roomsPricesTableAdapter = new HotelManagement.Hotel_ManagementDataSetTableAdapters.RoomsPricesTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCapacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(347, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات قیمت ها";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCapacity.Location = new System.Drawing.Point(217, 48);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(46, 21);
            this.cmbCapacity.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "قیمت اتاق:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(18, 48);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(208, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "قیمت ها به ریال وارد شود!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ظرفیت اتاق:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(28, 81);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(262, 81);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvRoomPrice
            // 
            this.dgvRoomPrice.AutoGenerateColumns = false;
            this.dgvRoomPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn});
            this.dgvRoomPrice.DataSource = this.roomsPricesBindingSource;
            this.dgvRoomPrice.Location = new System.Drawing.Point(10, 115);
            this.dgvRoomPrice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoomPrice.Name = "dgvRoomPrice";
            this.dgvRoomPrice.ReadOnly = true;
            this.dgvRoomPrice.Size = new System.Drawing.Size(347, 305);
            this.dgvRoomPrice.TabIndex = 15;
            this.dgvRoomPrice.SelectionChanged += new System.EventHandler(this.dgvRoomPrice_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "ظرفیت اتاق";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "قیمت برای هر شب";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            this.roomPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomsPricesBindingSource
            // 
            this.roomsPricesBindingSource.DataMember = "RoomsPrices";
            this.roomsPricesBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "Passenger";
            this.passengerBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // roomsPricesTableAdapter
            // 
            this.roomsPricesTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(146, 81);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmInsertRoomPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 431);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvRoomPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInsertRoomPrices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت قیمت اتاق ها";
            this.Load += new System.EventHandler(this.frmInsertRoomPrices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvRoomPrice;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private Hotel_ManagementDataSetTableAdapters.PassengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.BindingSource roomsPricesBindingSource;
        private Hotel_ManagementDataSetTableAdapters.RoomsPricesTableAdapter roomsPricesTableAdapter;
        private System.Windows.Forms.ComboBox cmbCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;

    }
}