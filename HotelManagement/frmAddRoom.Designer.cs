namespace HotelManagement
{
    partial class frmAddRoom
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
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvAddRoom = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOneNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new HotelManagement.Hotel_ManagementDataSet();
            this.roomTableAdapter = new HotelManagement.Hotel_ManagementDataSetTableAdapters.RoomTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomCapacity);
            this.groupBox1.Controls.Add(this.txtRoomNo);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(594, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات اتاق ها";
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.Enabled = false;
            this.txtRoomCapacity.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRoomCapacity.Location = new System.Drawing.Point(45, 44);
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(143, 21);
            this.txtRoomCapacity.TabIndex = 1;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Enabled = false;
            this.txtRoomNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtRoomNo.Location = new System.Drawing.Point(330, 44);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(143, 21);
            this.txtRoomNo.TabIndex = 0;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Enabled = false;
            this.lblCapacity.Location = new System.Drawing.Point(210, 45);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 22);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "ظرفیت اتاق:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Enabled = false;
            this.lblNo.Location = new System.Drawing.Point(490, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(60, 22);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "شماره اتاق:";
            // 
            // lblError
            // 
            this.lblError.Enabled = false;
            this.lblError.Font = new System.Drawing.Font("B Roya", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(159, 19);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(428, 22);
            this.lblError.TabIndex = 0;
            this.lblError.Text = " ابتدا در قسمت «ثبت قیمت اتاق ها» اقدام به واردکردن اطلاعات موردنیاز نمایید!!\r\n";
            this.lblError.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(493, 83);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(51, 83);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(352, 83);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(206, 83);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف اتاق";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvAddRoom
            // 
            this.dgvAddRoom.AutoGenerateColumns = false;
            this.dgvAddRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.roomCapacityDataGridViewTextBoxColumn,
            this.roomPriceIDDataGridViewTextBoxColumn,
            this.priceOneNightDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewTextBoxColumn});
            this.dgvAddRoom.DataSource = this.roomBindingSource;
            this.dgvAddRoom.Enabled = false;
            this.dgvAddRoom.Location = new System.Drawing.Point(12, 118);
            this.dgvAddRoom.Name = "dgvAddRoom";
            this.dgvAddRoom.ReadOnly = true;
            this.dgvAddRoom.Size = new System.Drawing.Size(595, 357);
            this.dgvAddRoom.TabIndex = 6;
            this.dgvAddRoom.SelectionChanged += new System.EventHandler(this.dgvAddRoom_SelectionChanged);
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
            // 
            // roomCapacityDataGridViewTextBoxColumn
            // 
            this.roomCapacityDataGridViewTextBoxColumn.DataPropertyName = "RoomCapacity";
            this.roomCapacityDataGridViewTextBoxColumn.HeaderText = "ظرفیت اتاق";
            this.roomCapacityDataGridViewTextBoxColumn.Name = "roomCapacityDataGridViewTextBoxColumn";
            this.roomCapacityDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.priceOneNightDataGridViewTextBoxColumn.HeaderText = "قیمت یک شب";
            this.priceOneNightDataGridViewTextBoxColumn.Name = "priceOneNightDataGridViewTextBoxColumn";
            this.priceOneNightDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 487);
            this.Controls.Add(this.dgvAddRoom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Roya", 9.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAddRoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن اتاق ها";
            this.Load += new System.EventHandler(this.frmAddRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAddRoom;
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