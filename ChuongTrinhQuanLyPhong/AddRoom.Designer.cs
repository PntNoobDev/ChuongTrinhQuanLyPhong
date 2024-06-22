namespace ChuongTrinhQuanLyPhong
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomNo12 = new System.Windows.Forms.TextBox();
            this.txtRoomNo23 = new System.Windows.Forms.TextBox();
            this.LbRoomExist1 = new System.Windows.Forms.Label();
            this.LbRoom2 = new System.Windows.Forms.Label();
            this.checkbook12 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbook22 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvroom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(30, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "CẬP NHẬT HOẶC XÓA PHÒNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(30, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(338, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "THÊM PHÒNG";
            // 
            // txtRoomNo12
            // 
            this.txtRoomNo12.Location = new System.Drawing.Point(159, 94);
            this.txtRoomNo12.Multiline = true;
            this.txtRoomNo12.Name = "txtRoomNo12";
            this.txtRoomNo12.Size = new System.Drawing.Size(241, 41);
            this.txtRoomNo12.TabIndex = 6;
            // 
            // txtRoomNo23
            // 
            this.txtRoomNo23.Location = new System.Drawing.Point(158, 357);
            this.txtRoomNo23.Multiline = true;
            this.txtRoomNo23.Name = "txtRoomNo23";
            this.txtRoomNo23.Size = new System.Drawing.Size(241, 41);
            this.txtRoomNo23.TabIndex = 7;
            this.txtRoomNo23.TextChanged += new System.EventHandler(this.txtRoomNo23_TextChanged);
            // 
            // LbRoomExist1
            // 
            this.LbRoomExist1.AutoSize = true;
            this.LbRoomExist1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoomExist1.ForeColor = System.Drawing.SystemColors.Window;
            this.LbRoomExist1.Location = new System.Drawing.Point(203, 138);
            this.LbRoomExist1.Name = "LbRoomExist1";
            this.LbRoomExist1.Size = new System.Drawing.Size(93, 31);
            this.LbRoomExist1.TabIndex = 12;
            this.LbRoomExist1.Text = "SetText";
            // 
            // LbRoom2
            // 
            this.LbRoom2.AutoSize = true;
            this.LbRoom2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRoom2.ForeColor = System.Drawing.SystemColors.Window;
            this.LbRoom2.Location = new System.Drawing.Point(218, 402);
            this.LbRoom2.Name = "LbRoom2";
            this.LbRoom2.Size = new System.Drawing.Size(93, 31);
            this.LbRoom2.TabIndex = 13;
            this.LbRoom2.Text = "SetText";
            this.LbRoom2.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkbook12
            // 
            this.checkbook12.AutoSize = true;
            this.checkbook12.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbook12.CheckedState.BorderRadius = 0;
            this.checkbook12.CheckedState.BorderThickness = 0;
            this.checkbook12.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbook12.Location = new System.Drawing.Point(621, 147);
            this.checkbook12.Name = "checkbook12";
            this.checkbook12.Size = new System.Drawing.Size(18, 17);
            this.checkbook12.TabIndex = 14;
            this.checkbook12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbook12.UncheckedState.BorderRadius = 0;
            this.checkbook12.UncheckedState.BorderThickness = 0;
            this.checkbook12.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbook12.CheckedChanged += new System.EventHandler(this.checkbook1_CheckedChanged);
            // 
            // checkbook22
            // 
            this.checkbook22.AutoSize = true;
            this.checkbook22.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbook22.CheckedState.BorderRadius = 0;
            this.checkbook22.CheckedState.BorderThickness = 0;
            this.checkbook22.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkbook22.Location = new System.Drawing.Point(578, 370);
            this.checkbook22.Name = "checkbook22";
            this.checkbook22.Size = new System.Drawing.Size(18, 17);
            this.checkbook22.TabIndex = 15;
            this.checkbook22.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkbook22.UncheckedState.BorderRadius = 0;
            this.checkbook22.UncheckedState.BorderThickness = 0;
            this.checkbook22.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Có Chắc Muốn Thêm Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cập Nhật Phòng?";
            // 
            // dgvroom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvroom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvroom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvroom.ColumnHeadersHeight = 4;
            this.dgvroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvroom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvroom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvroom.Location = new System.Drawing.Point(19, 494);
            this.dgvroom.Name = "dgvroom";
            this.dgvroom.RowHeadersVisible = false;
            this.dgvroom.RowHeadersWidth = 51;
            this.dgvroom.RowTemplate.Height = 24;
            this.dgvroom.Size = new System.Drawing.Size(987, 357);
            this.dgvroom.TabIndex = 18;
            this.dgvroom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvroom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvroom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvroom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvroom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvroom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvroom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvroom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvroom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvroom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvroom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvroom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvroom.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvroom.ThemeStyle.ReadOnly = false;
            this.dgvroom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvroom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvroom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvroom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvroom.ThemeStyle.RowsStyle.Height = 24;
            this.dgvroom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvroom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 41);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Phòng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(13, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số giường:";
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Location = new System.Drawing.Point(913, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 76);
            this.btnExit.TabIndex = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BorderColor = System.Drawing.Color.White;
            this.btnUpdate1.BorderRadius = 13;
            this.btnUpdate1.BorderThickness = 1;
            this.btnUpdate1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate1.ForeColor = System.Drawing.Color.White;
            this.btnUpdate1.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate1.Image")));
            this.btnUpdate1.Location = new System.Drawing.Point(804, 339);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(170, 63);
            this.btnUpdate1.TabIndex = 9;
            this.btnUpdate1.Text = "Cập Nhật";
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.BorderColor = System.Drawing.Color.White;
            this.btnSearch1.BorderRadius = 13;
            this.btnSearch1.BorderThickness = 1;
            this.btnSearch1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch1.ForeColor = System.Drawing.Color.White;
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.Location = new System.Drawing.Point(619, 340);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(170, 63);
            this.btnSearch1.TabIndex = 8;
            this.btnSearch1.Text = "Tìm Phòng";
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddRoom1
            // 
            this.btnAddRoom1.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom1.BorderRadius = 13;
            this.btnAddRoom1.BorderThickness = 1;
            this.btnAddRoom1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom1.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom1.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom1.Image")));
            this.btnAddRoom1.Location = new System.Drawing.Point(665, 121);
            this.btnAddRoom1.Name = "btnAddRoom1";
            this.btnAddRoom1.Size = new System.Drawing.Size(170, 63);
            this.btnAddRoom1.TabIndex = 5;
            this.btnAddRoom1.Text = "Thêm Phòng";
            this.btnAddRoom1.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 863);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvroom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkbook22);
            this.Controls.Add(this.checkbook12);
            this.Controls.Add(this.LbRoom2);
            this.Controls.Add(this.LbRoomExist1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.txtRoomNo23);
            this.Controls.Add(this.txtRoomNo12);
            this.Controls.Add(this.btnAddRoom1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom1;
        private System.Windows.Forms.TextBox txtRoomNo12;
        private System.Windows.Forms.TextBox txtRoomNo23;
        private Guna.UI2.WinForms.Guna2Button btnSearch1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label LbRoomExist1;
        private System.Windows.Forms.Label LbRoom2;
        private Guna.UI2.WinForms.Guna2CheckBox checkbook12;
        private Guna.UI2.WinForms.Guna2CheckBox checkbook22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dgvroom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}