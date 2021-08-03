namespace HotelManagement
{
    partial class frmRoomList
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOneNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new HotelManagement.Hotel_ManagementDataSet();
            this.roomTableAdapter = new HotelManagement.Hotel_ManagementDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "نمایش اتاق ها براساس:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Items.AddRange(new object[] {
            "همه",
            "آماده",
            "پُر"});
            this.cmbOrder.Location = new System.Drawing.Point(162, 16);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 0;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(62, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AutoGenerateColumns = false;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.roomCapacityDataGridViewTextBoxColumn,
            this.roomPriceIDDataGridViewTextBoxColumn,
            this.priceOneNightDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewTextBoxColumn});
            this.dgvRoomList.DataSource = this.roomBindingSource;
            this.dgvRoomList.Location = new System.Drawing.Point(12, 48);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.Size = new System.Drawing.Size(440, 476);
            this.dgvRoomList.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "شماره اتاق";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNoDataGridViewTextBoxColumn.Width = 85;
            // 
            // roomCapacityDataGridViewTextBoxColumn
            // 
            this.roomCapacityDataGridViewTextBoxColumn.DataPropertyName = "RoomCapacity";
            this.roomCapacityDataGridViewTextBoxColumn.HeaderText = "ظرفیت اتاق";
            this.roomCapacityDataGridViewTextBoxColumn.Name = "roomCapacityDataGridViewTextBoxColumn";
            this.roomCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomCapacityDataGridViewTextBoxColumn.Width = 85;
            // 
            // roomPriceIDDataGridViewTextBoxColumn
            // 
            this.roomPriceIDDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice_ID";
            this.roomPriceIDDataGridViewTextBoxColumn.HeaderText = "RoomPrice_ID";
            this.roomPriceIDDataGridViewTextBoxColumn.Name = "roomPriceIDDataGridViewTextBoxColumn";
            this.roomPriceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomPriceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceOneNightDataGridViewTextBoxColumn
            // 
            this.priceOneNightDataGridViewTextBoxColumn.DataPropertyName = "PriceOneNight";
            this.priceOneNightDataGridViewTextBoxColumn.HeaderText = "قیمت هر شب (ریال)";
            this.priceOneNightDataGridViewTextBoxColumn.Name = "priceOneNightDataGridViewTextBoxColumn";
            this.priceOneNightDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceOneNightDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomStatusDataGridViewTextBoxColumn
            // 
            this.roomStatusDataGridViewTextBoxColumn.DataPropertyName = "RoomStatus";
            this.roomStatusDataGridViewTextBoxColumn.HeaderText = "وضعیت اتاق";
            this.roomStatusDataGridViewTextBoxColumn.Name = "roomStatusDataGridViewTextBoxColumn";
            this.roomStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // frmRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 536);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmRoomList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست اتاق ها";
            this.Load += new System.EventHandler(this.frmRoomList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Hotel_ManagementDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOneNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewTextBoxColumn;
    }
}