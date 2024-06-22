namespace ChuongTrinhQuanLyPhong
{
    partial class ShowRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRoom));
            this.showrooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btndeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchRoom = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // showrooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.showrooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showrooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showrooms.ColumnHeadersHeight = 4;
            this.showrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showrooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.showrooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.showrooms.Location = new System.Drawing.Point(85, 244);
            this.showrooms.Name = "showrooms";
            this.showrooms.RowHeadersVisible = false;
            this.showrooms.RowHeadersWidth = 51;
            this.showrooms.RowTemplate.Height = 24;
            this.showrooms.Size = new System.Drawing.Size(947, 363);
            this.showrooms.TabIndex = 18;
            this.showrooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.showrooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showrooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showrooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showrooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showrooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.showrooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.showrooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showrooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showrooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showrooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showrooms.ThemeStyle.HeaderStyle.Height = 4;
            this.showrooms.ThemeStyle.ReadOnly = false;
            this.showrooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.showrooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showrooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showrooms.ThemeStyle.RowsStyle.Height = 24;
            this.showrooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.showrooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.showrooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showrooms_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(419, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh Sách Phòng";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::ChuongTrinhQuanLyPhong.Properties.Resources.Close;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1141, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 60);
            this.btnExit.TabIndex = 17;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BorderRadius = 10;
            this.btnUpdateRoom.BorderThickness = 2;
            this.btnUpdateRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Image = global::ChuongTrinhQuanLyPhong.Properties.Resources.Update___Delete_Student;
            this.btnUpdateRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUpdateRoom.Location = new System.Drawing.Point(749, 651);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(223, 72);
            this.btnUpdateRoom.TabIndex = 16;
            this.btnUpdateRoom.Text = "Cập nhật";
            // 
            // btndeleteRoom
            // 
            this.btndeleteRoom.BorderColor = System.Drawing.Color.Transparent;
            this.btndeleteRoom.BorderRadius = 10;
            this.btndeleteRoom.BorderThickness = 2;
            this.btndeleteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeleteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeleteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeleteRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btndeleteRoom.Image = global::ChuongTrinhQuanLyPhong.Properties.Resources.delete;
            this.btndeleteRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btndeleteRoom.Location = new System.Drawing.Point(440, 651);
            this.btndeleteRoom.Name = "btndeleteRoom";
            this.btndeleteRoom.Size = new System.Drawing.Size(223, 72);
            this.btndeleteRoom.TabIndex = 15;
            this.btndeleteRoom.Text = "Xóa Phòng";
            this.btndeleteRoom.Click += new System.EventHandler(this.btndeleteRoom_Click);
            // 
            // btnAddroom
            // 
            this.btnAddroom.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddroom.BorderRadius = 10;
            this.btnAddroom.BorderThickness = 2;
            this.btnAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddroom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddroom.ForeColor = System.Drawing.Color.White;
            this.btnAddroom.Image = global::ChuongTrinhQuanLyPhong.Properties.Resources.addroom;
            this.btnAddroom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddroom.Location = new System.Drawing.Point(129, 651);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.Size = new System.Drawing.Size(223, 72);
            this.btnAddroom.TabIndex = 14;
            this.btnAddroom.Text = "Thêm Phòng";
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BorderRadius = 12;
            this.btnSearchRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSearchRoom.DefaultText = "";
            this.btnSearchRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearchRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnSearchRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearchRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearchRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearchRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearchRoom.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnSearchRoom.IconLeft")));
            this.btnSearchRoom.Location = new System.Drawing.Point(730, 171);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.PasswordChar = '\0';
            this.btnSearchRoom.PlaceholderText = "Nhập Từ Khóa Tìm Kiếm";
            this.btnSearchRoom.SelectedText = "";
            this.btnSearchRoom.Size = new System.Drawing.Size(302, 46);
            this.btnSearchRoom.TabIndex = 13;
            this.btnSearchRoom.TextChanged += new System.EventHandler(this.btnSearchRoom_TextChanged);
            // 
            // ShowRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 736);
            this.Controls.Add(this.showrooms);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btndeleteRoom);
            this.Controls.Add(this.btnAddroom);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRoom";
            this.Load += new System.EventHandler(this.ShowRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView showrooms;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private Guna.UI2.WinForms.Guna2Button btndeleteRoom;
        private Guna.UI2.WinForms.Guna2Button btnAddroom;
        private Guna.UI2.WinForms.Guna2TextBox btnSearchRoom;
        private System.Windows.Forms.Label label1;
    }
}