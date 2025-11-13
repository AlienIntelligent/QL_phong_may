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
            this.pnl_Menu = new MetroFramework.Controls.MetroPanel();
            this.pnl_Logo = new MetroFramework.Controls.MetroPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Menu.Controls.Add(this.iconButton2);
            this.pnl_Menu.Controls.Add(this.iconButton1);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.CustomBackground = true;
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.HorizontalScrollbarBarColor = true;
            this.pnl_Menu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Menu.HorizontalScrollbarSize = 10;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(280, 720);
            this.pnl_Menu.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnl_Menu.TabIndex = 0;
            this.pnl_Menu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnl_Menu.VerticalScrollbarBarColor = true;
            this.pnl_Menu.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Menu.VerticalScrollbarSize = 10;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.CustomBackground = true;
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.HorizontalScrollbarBarColor = true;
            this.pnl_Logo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Logo.HorizontalScrollbarSize = 10;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(280, 220);
            this.pnl_Logo.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnl_Logo.TabIndex = 2;
            this.pnl_Logo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnl_Logo.VerticalScrollbarBarColor = true;
            this.pnl_Logo.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Logo.VerticalScrollbarSize = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Cyan;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ubuntu;
            this.iconButton1.IconColor = System.Drawing.Color.Cyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 55;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 220);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(280, 75);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Ubuntu";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Yellow;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Unity;
            this.iconButton2.IconColor = System.Drawing.Color.Yellow;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 295);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(280, 75);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Unity";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.pnl_Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl_Menu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MetroFramework.Controls.MetroPanel pnl_Logo;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

