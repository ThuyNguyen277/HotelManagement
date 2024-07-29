namespace HotelManegemantSystem.All_User_Control
{
    partial class UC_CustomerDetails
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
            this.TxtSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CustomerDetailsView = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.label14.Size = new System.Drawing.Size(135, 34);
            this.label14.TabIndex = 28;
            this.label14.Text = "顧客情報";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(667, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "検索";
            // 
            // TxtSearchBy
            // 
            this.TxtSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.TxtSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtSearchBy.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchBy.ItemHeight = 30;
            this.TxtSearchBy.Items.AddRange(new object[] {
            "すべての顧客情報",
            "ホテルに泊まっている顧客",
            "すでに計算済みの顧客"});
            this.TxtSearchBy.Location = new System.Drawing.Point(669, 140);
            this.TxtSearchBy.Name = "TxtSearchBy";
            this.TxtSearchBy.Size = new System.Drawing.Size(481, 36);
            this.TxtSearchBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSearchBy.TabIndex = 30;
            this.TxtSearchBy.SelectedIndexChanged += new System.EventHandler(this.TxtSearchBy_SelectedIndexChanged);
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
            this.CustomerDetailsView.Location = new System.Drawing.Point(63, 302);
            this.CustomerDetailsView.Name = "CustomerDetailsView";
            this.CustomerDetailsView.RowHeadersVisible = false;
            this.CustomerDetailsView.RowTemplate.Height = 21;
            this.CustomerDetailsView.Size = new System.Drawing.Size(1763, 490);
            this.CustomerDetailsView.TabIndex = 31;
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
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomerDetailsView);
            this.Controls.Add(this.TxtSearchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "UC_CustomerDetails";
            this.Size = new System.Drawing.Size(1882, 852);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox TxtSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDetailsView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
