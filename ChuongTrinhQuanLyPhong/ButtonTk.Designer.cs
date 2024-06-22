namespace ChuongTrinhQuanLyPhong
{
    partial class ButtonTk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonTk));
            this.tkRoom = new Guna.UI2.WinForms.Guna2Button();
            this.tkNv = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tkRoom
            // 
            this.tkRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tkRoom.BorderRadius = 20;
            this.tkRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tkRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tkRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tkRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tkRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkRoom.ForeColor = System.Drawing.Color.Blue;
            this.tkRoom.Location = new System.Drawing.Point(98, 203);
            this.tkRoom.Name = "tkRoom";
            this.tkRoom.Size = new System.Drawing.Size(207, 87);
            this.tkRoom.TabIndex = 0;
            this.tkRoom.Text = "Thống Kê Phòng";
            this.tkRoom.Click += new System.EventHandler(this.tkRoom_Click);
            // 
            // tkNv
            // 
            this.tkNv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tkNv.BorderRadius = 20;
            this.tkNv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tkNv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tkNv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tkNv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tkNv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkNv.ForeColor = System.Drawing.Color.Blue;
            this.tkNv.Location = new System.Drawing.Point(453, 203);
            this.tkNv.Name = "tkNv";
            this.tkNv.Size = new System.Drawing.Size(207, 87);
            this.tkNv.TabIndex = 1;
            this.tkNv.Text = "Thống Kê Nhân Viên";
            this.tkNv.Click += new System.EventHandler(this.tkNv_Click);
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
            this.btnExit.Location = new System.Drawing.Point(739, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 76);
            this.btnExit.TabIndex = 42;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ButtonTk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tkNv);
            this.Controls.Add(this.tkRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonTk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ButtonTk";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button tkRoom;
        private Guna.UI2.WinForms.Guna2Button tkNv;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}