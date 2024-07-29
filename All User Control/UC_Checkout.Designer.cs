namespace HotelManegemantSystem.All_User_Control
{
    partial class UC_Checkout
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerDetailsView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtCName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCheckoutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(55, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 34);
            this.label14.TabIndex = 27;
            this.label14.Text = "計算";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(640, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "検索";
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.Location = new System.Drawing.Point(643, 99);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "名前を入力してください。";
            this.TxtName.SelectedText = "";
            this.TxtName.Size = new System.Drawing.Size(523, 85);
            this.TxtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtName.TabIndex = 29;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // CustomerDetailsView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerDetailsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDetailsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDetailsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDetailsView.ColumnHeadersHeight = 4;
            this.CustomerDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDetailsView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDetailsView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDetailsView.Location = new System.Drawing.Point(71, 233);
            this.CustomerDetailsView.Name = "CustomerDetailsView";
            this.CustomerDetailsView.RowHeadersVisible = false;
            this.CustomerDetailsView.RowTemplate.Height = 21;
            this.CustomerDetailsView.Size = new System.Drawing.Size(1732, 336);
            this.CustomerDetailsView.TabIndex = 30;
            this.CustomerDetailsView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDetailsView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDetailsView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDetailsView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDetailsView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDetailsView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDetailsView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDetailsView.ThemeStyle.HeaderStyle.Height = 4;
            this.CustomerDetailsView.ThemeStyle.ReadOnly = false;
            this.CustomerDetailsView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDetailsView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDetailsView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerDetailsView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDetailsView.ThemeStyle.RowsStyle.Height = 21;
            this.CustomerDetailsView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDetailsView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerDetailsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDetailsView_CellContentClick);
            // 
            // TxtCName
            // 
            this.TxtCName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCName.DefaultText = "";
            this.TxtCName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCName.Location = new System.Drawing.Point(71, 691);
            this.TxtCName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCName.Name = "TxtCName";
            this.TxtCName.PasswordChar = '\0';
            this.TxtCName.PlaceholderText = "名前を入力してください。";
            this.TxtCName.ReadOnly = true;
            this.TxtCName.SelectedText = "";
            this.TxtCName.Size = new System.Drawing.Size(523, 85);
            this.TxtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "名前";
            // 
            // TxtRoom
            // 
            this.TxtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRoom.DefaultText = "";
            this.TxtRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TxtRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRoom.Location = new System.Drawing.Point(643, 691);
            this.TxtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRoom.Name = "TxtRoom";
            this.TxtRoom.PasswordChar = '\0';
            this.TxtRoom.PlaceholderText = "部屋番号を入力してください。";
            this.TxtRoom.ReadOnly = true;
            this.TxtRoom.SelectedText = "";
            this.TxtRoom.Size = new System.Drawing.Size(523, 85);
            this.TxtRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtRoom.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(640, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "部屋番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1208, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "チェックアウト日";
            // 
            // TxtCheckoutDate
            // 
            this.TxtCheckoutDate.Checked = true;
            this.TxtCheckoutDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCheckoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtCheckoutDate.Location = new System.Drawing.Point(1211, 691);
            this.TxtCheckoutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TxtCheckoutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TxtCheckoutDate.Name = "TxtCheckoutDate";
            this.TxtCheckoutDate.Size = new System.Drawing.Size(346, 85);
            this.TxtCheckoutDate.TabIndex = 36;
            this.TxtCheckoutDate.Value = new System.DateTime(2024, 7, 25, 17, 44, 58, 66);
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.BorderRadius = 18;
            this.BtnCheckout.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.BtnCheckout.BorderThickness = 1;
            this.BtnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnCheckout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.BtnCheckout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCheckout.FillColor = System.Drawing.Color.White;
            this.BtnCheckout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckout.Location = new System.Drawing.Point(1623, 691);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(180, 85);
            this.BtnCheckout.TabIndex = 37;
            this.BtnCheckout.TabStop = false;
            this.BtnCheckout.Text = "計算";
            this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCheckout);
            this.Controls.Add(this.TxtCheckoutDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerDetailsView);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "UC_Checkout";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_Checkout_Load);
            this.Leave += new System.EventHandler(this.UC_Checkout_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDetailsView;
        private Guna.UI2.WinForms.Guna2TextBox TxtCName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker TxtCheckoutDate;
        private Guna.UI2.WinForms.Guna2Button BtnCheckout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
