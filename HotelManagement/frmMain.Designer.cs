namespace HotelManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRoomList = new System.Windows.Forms.Button();
            this.btnAddRooms = new System.Windows.Forms.Button();
            this.btnPriceSubmit = new System.Windows.Forms.Button();
            this.btnAddNewPassenger = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(1182, 488);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(143, 61);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "تهیه گزارش";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(1182, 416);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 61);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRoomList
            // 
            this.btnRoomList.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRoomList.Location = new System.Drawing.Point(1182, 344);
            this.btnRoomList.Name = "btnRoomList";
            this.btnRoomList.Size = new System.Drawing.Size(143, 61);
            this.btnRoomList.TabIndex = 9;
            this.btnRoomList.Text = "لیست اتاق ها";
            this.btnRoomList.UseVisualStyleBackColor = true;
            this.btnRoomList.Click += new System.EventHandler(this.btnRoomList_Click);
            // 
            // btnAddRooms
            // 
            this.btnAddRooms.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddRooms.Location = new System.Drawing.Point(1182, 272);
            this.btnAddRooms.Name = "btnAddRooms";
            this.btnAddRooms.Size = new System.Drawing.Size(143, 61);
            this.btnAddRooms.TabIndex = 8;
            this.btnAddRooms.Text = "افزودن اتاق";
            this.btnAddRooms.UseVisualStyleBackColor = true;
            this.btnAddRooms.Click += new System.EventHandler(this.btnAddRooms_Click);
            // 
            // btnPriceSubmit
            // 
            this.btnPriceSubmit.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPriceSubmit.Location = new System.Drawing.Point(1182, 200);
            this.btnPriceSubmit.Name = "btnPriceSubmit";
            this.btnPriceSubmit.Size = new System.Drawing.Size(143, 61);
            this.btnPriceSubmit.TabIndex = 7;
            this.btnPriceSubmit.Text = "ثبت قیمت اتاق ها";
            this.btnPriceSubmit.UseVisualStyleBackColor = true;
            this.btnPriceSubmit.Click += new System.EventHandler(this.btnPriceSubmit_Click);
            // 
            // btnAddNewPassenger
            // 
            this.btnAddNewPassenger.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewPassenger.Location = new System.Drawing.Point(1182, 128);
            this.btnAddNewPassenger.Name = "btnAddNewPassenger";
            this.btnAddNewPassenger.Size = new System.Drawing.Size(143, 61);
            this.btnAddNewPassenger.TabIndex = 6;
            this.btnAddNewPassenger.Text = "ثبت مهمان جدید";
            this.btnAddNewPassenger.UseVisualStyleBackColor = true;
            this.btnAddNewPassenger.Click += new System.EventHandler(this.btnAddNewPassenger_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(1182, 631);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 61);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(92, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "ساعت:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "تاریخ امروز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(86, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Roya", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(1077, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 58);
            this.label1.TabIndex = 18;
            this.label1.Text = "سیستم مدیریت هتل";
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("B Roya", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Location = new System.Drawing.Point(1182, 560);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(143, 61);
            this.btnUsers.TabIndex = 19;
            this.btnUsers.Text = "بخش کاربری";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 728);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRoomList);
            this.Controls.Add(this.btnAddRooms);
            this.Controls.Add(this.btnPriceSubmit);
            this.Controls.Add(this.btnAddNewPassenger);
            this.Font = new System.Drawing.Font("B Traffic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت هتل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRoomList;
        private System.Windows.Forms.Button btnAddRooms;
        private System.Windows.Forms.Button btnPriceSubmit;
        private System.Windows.Forms.Button btnAddNewPassenger;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsers;
    }
}