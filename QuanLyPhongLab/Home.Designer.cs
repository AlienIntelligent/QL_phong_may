namespace QuanLyPhongLab
{
    partial class Home
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
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.btn_A = new FontAwesome.Sharp.IconButton();
            this.btn_B = new FontAwesome.Sharp.IconButton();
            this.btn_C = new FontAwesome.Sharp.IconButton();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CurrIcon = new FontAwesome.Sharp.IconButton();
            this.pnl_none = new System.Windows.Forms.Panel();
            this.pnl_desktop = new System.Windows.Forms.Panel();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnl_Menu.Controls.Add(this.btn_C);
            this.pnl_Menu.Controls.Add(this.btn_B);
            this.pnl_Menu.Controls.Add(this.btn_A);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 669);
            this.pnl_Menu.TabIndex = 0;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Logo.Controls.Add(this.pictureBox1);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(200, 130);
            this.pnl_Logo.TabIndex = 0;
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_A.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_A.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_A.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btn_A.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btn_A.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_A.IconSize = 40;
            this.btn_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_A.Location = new System.Drawing.Point(0, 130);
            this.btn_A.Margin = new System.Windows.Forms.Padding(0);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(200, 60);
            this.btn_A.TabIndex = 1;
            this.btn_A.Text = "Music";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_B.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_B.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_B.IconChar = FontAwesome.Sharp.IconChar.PhoneVolume;
            this.btn_B.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btn_B.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_B.IconSize = 40;
            this.btn_B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_B.Location = new System.Drawing.Point(0, 190);
            this.btn_B.Margin = new System.Windows.Forms.Padding(0);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(200, 60);
            this.btn_B.TabIndex = 2;
            this.btn_B.Text = "Phone";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btn_C.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_C.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_C.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btn_C.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btn_C.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_C.IconSize = 40;
            this.btn_C.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_C.Location = new System.Drawing.Point(0, 250);
            this.btn_C.Margin = new System.Windows.Forms.Padding(0);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(200, 60);
            this.btn_C.TabIndex = 3;
            this.btn_C.Text = "Draw";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click_1);
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnl_Title.Controls.Add(this.btn_CurrIcon);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(200, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(863, 70);
            this.pnl_Title.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyPhongLab.Properties.Resources.Huy_Hiệu_Đoàn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_CurrIcon
            // 
            this.btn_CurrIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CurrIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btn_CurrIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_CurrIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CurrIcon.IconSize = 40;
            this.btn_CurrIcon.Location = new System.Drawing.Point(6, 12);
            this.btn_CurrIcon.Name = "btn_CurrIcon";
            this.btn_CurrIcon.Size = new System.Drawing.Size(45, 45);
            this.btn_CurrIcon.TabIndex = 0;
            this.btn_CurrIcon.UseVisualStyleBackColor = true;
            // 
            // pnl_none
            // 
            this.pnl_none.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnl_none.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_none.Location = new System.Drawing.Point(200, 70);
            this.pnl_none.Name = "pnl_none";
            this.pnl_none.Size = new System.Drawing.Size(863, 20);
            this.pnl_none.TabIndex = 2;
            // 
            // pnl_desktop
            // 
            this.pnl_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.pnl_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_desktop.Location = new System.Drawing.Point(200, 90);
            this.pnl_desktop.Name = "pnl_desktop";
            this.pnl_desktop.Size = new System.Drawing.Size(863, 579);
            this.pnl_desktop.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 669);
            this.Controls.Add(this.pnl_desktop);
            this.Controls.Add(this.pnl_none);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private FontAwesome.Sharp.IconButton btn_A;
        private System.Windows.Forms.Panel pnl_Logo;
        private FontAwesome.Sharp.IconButton btn_C;
        private FontAwesome.Sharp.IconButton btn_B;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_CurrIcon;
        private System.Windows.Forms.Panel pnl_none;
        private System.Windows.Forms.Panel pnl_desktop;
    }
}