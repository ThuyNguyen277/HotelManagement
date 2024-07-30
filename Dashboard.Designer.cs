namespace HotelManegemantSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnEmploy = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCustomDetail = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCustomRes = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_Employee1 = new HotelManegemantSystem.All_User_Control.UC_Employee();
            this.uC_CustomerDetails1 = new HotelManegemantSystem.All_User_Control.UC_CustomerDetails();
            this.uC_Checkout1 = new HotelManegemantSystem.All_User_Control.UC_Checkout();
            this.uC_CustomRes1 = new HotelManegemantSystem.All_User_Control.UC_CustomRes();
            this.uC_AddRoom1 = new HotelManegemantSystem.All_User_Control.UC_AddRoom();
            this.PnlMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnExit.Location = new System.Drawing.Point(2, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 42);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnEmploy);
            this.guna2Panel1.Controls.Add(this.BtnCustomDetail);
            this.guna2Panel1.Controls.Add(this.BtnCheckOut);
            this.guna2Panel1.Controls.Add(this.BtnCustomRes);
            this.guna2Panel1.Controls.Add(this.BtnAddRoom);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1765, 130);
            this.guna2Panel1.TabIndex = 2;
            // 
            // BtnEmploy
            // 
            this.BtnEmploy.BorderRadius = 18;
            this.BtnEmploy.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnEmploy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmploy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEmploy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEmploy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEmploy.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnEmploy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmploy.ForeColor = System.Drawing.Color.White;
            this.BtnEmploy.Location = new System.Drawing.Point(1462, 7);
            this.BtnEmploy.Name = "BtnEmploy";
            this.BtnEmploy.Size = new System.Drawing.Size(284, 116);
            this.BtnEmploy.TabIndex = 4;
            this.BtnEmploy.Text = "スタッフ";
            this.BtnEmploy.Click += new System.EventHandler(this.BtnEmploy_Click);
            // 
            // BtnCustomDetail
            // 
            this.BtnCustomDetail.BorderRadius = 18;
            this.BtnCustomDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCustomDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomDetail.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnCustomDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomDetail.ForeColor = System.Drawing.Color.White;
            this.BtnCustomDetail.Location = new System.Drawing.Point(1105, 7);
            this.BtnCustomDetail.Name = "BtnCustomDetail";
            this.BtnCustomDetail.Size = new System.Drawing.Size(284, 116);
            this.BtnCustomDetail.TabIndex = 3;
            this.BtnCustomDetail.Text = "カスタム詳細";
            this.BtnCustomDetail.Click += new System.EventHandler(this.BtnCustomDetail_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.BorderRadius = 18;
            this.BtnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCheckOut.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.ForeColor = System.Drawing.Color.White;
            this.BtnCheckOut.Location = new System.Drawing.Point(743, 7);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(284, 116);
            this.BtnCheckOut.TabIndex = 2;
            this.BtnCheckOut.Text = "計算";
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCustomRes
            // 
            this.BtnCustomRes.BorderRadius = 18;
            this.BtnCustomRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCustomRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomRes.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnCustomRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomRes.ForeColor = System.Drawing.Color.White;
            this.BtnCustomRes.Location = new System.Drawing.Point(383, 7);
            this.BtnCustomRes.Name = "BtnCustomRes";
            this.BtnCustomRes.Size = new System.Drawing.Size(284, 116);
            this.BtnCustomRes.TabIndex = 1;
            this.BtnCustomRes.Text = "カスタム登録";
            this.BtnCustomRes.Click += new System.EventHandler(this.BtnCustomRes_Click);
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.BorderRadius = 18;
            this.BtnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddRoom.FillColor = System.Drawing.Color.SlateBlue;
            this.BtnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.Location = new System.Drawing.Point(23, 7);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.Size = new System.Drawing.Size(284, 116);
            this.BtnAddRoom.TabIndex = 0;
            this.BtnAddRoom.Text = "ルーム追加";
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.uC_Employee1);
            this.guna2Panel2.Controls.Add(this.uC_CustomerDetails1);
            this.guna2Panel2.Controls.Add(this.uC_Checkout1);
            this.guna2Panel2.Controls.Add(this.uC_CustomRes1);
            this.guna2Panel2.Controls.Add(this.uC_AddRoom1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 187);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1882, 852);
            this.guna2Panel2.TabIndex = 3;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Employee1.TabIndex = 4;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_Checkout1
            // 
            this.uC_Checkout1.BackColor = System.Drawing.Color.White;
            this.uC_Checkout1.Location = new System.Drawing.Point(0, 0);
            this.uC_Checkout1.Name = "uC_Checkout1";
            this.uC_Checkout1.Size = new System.Drawing.Size(1882, 852);
            this.uC_Checkout1.TabIndex = 2;
            // 
            // uC_CustomRes1
            // 
            this.uC_CustomRes1.BackColor = System.Drawing.Color.White;
            this.uC_CustomRes1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomRes1.Name = "uC_CustomRes1";
            this.uC_CustomRes1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomRes1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-3, 0);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1882, 852);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // PnlMoving
            // 
            this.PnlMoving.BackColor = System.Drawing.Color.Aqua;
            this.PnlMoving.Location = new System.Drawing.Point(69, 163);
            this.PnlMoving.Name = "PnlMoving";
            this.PnlMoving.Size = new System.Drawing.Size(284, 7);
            this.PnlMoving.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // BtnLogout
            // 
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnLogout.Location = new System.Drawing.Point(2, 49);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(39, 42);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.PnlMoving);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
        private Guna.UI2.WinForms.Guna2Button BtnCustomDetail;
        private Guna.UI2.WinForms.Guna2Button BtnCheckOut;
        private Guna.UI2.WinForms.Guna2Button BtnCustomRes;
        private Guna.UI2.WinForms.Guna2Button BtnEmploy;
        private Guna.UI2.WinForms.Guna2Panel PnlMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_CustomRes uC_CustomRes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_Checkout uC_Checkout1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_CustomerDetails uC_CustomerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
    }
}