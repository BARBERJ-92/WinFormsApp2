
namespace WinFormsApp2
{
    partial class menuWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientPanel1 = new WinFormsApp2.gardientPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.colourBar = new System.Windows.Forms.PictureBox();
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.manButton = new System.Windows.Forms.Button();
            this.womanButton = new System.Windows.Forms.Button();
            this.boyButton = new System.Windows.Forms.Button();
            this.girlButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.brandButton = new System.Windows.Forms.Button();
            this.userControl11 = new WinFormsApp2.UserControl1();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.gradientPanel1.Controls.Add(this.logoutButton);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(200, 96);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.Control;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BackgroundImage = global::WinFormsApp2.Resource1.logout;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(12, 12);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(72, 65);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // colourBar
            // 
            this.colourBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.colourBar.Location = new System.Drawing.Point(0, 0);
            this.colourBar.Name = "colourBar";
            this.colourBar.Size = new System.Drawing.Size(700, 96);
            this.colourBar.TabIndex = 4;
            this.colourBar.TabStop = false;
            // 
            // logoBox1
            // 
            this.logoBox1.Image = global::WinFormsApp2.Resource1.StylishYou_Logo_Main;
            this.logoBox1.Location = new System.Drawing.Point(365, 0);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(175, 191);
            this.logoBox1.TabIndex = 5;
            this.logoBox1.TabStop = false;
            // 
            // manButton
            // 
            this.manButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.manButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manButton.ForeColor = System.Drawing.Color.Transparent;
            this.manButton.Location = new System.Drawing.Point(73, 247);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(226, 226);
            this.manButton.TabIndex = 6;
            this.manButton.Text = "Man";
            this.manButton.UseVisualStyleBackColor = false;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            this.manButton.MouseLeave += new System.EventHandler(this.manButton_MouseLeave);
            this.manButton.MouseHover += new System.EventHandler(this.manButton_MouseHover);
            // 
            // womanButton
            // 
            this.womanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.womanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.womanButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.womanButton.ForeColor = System.Drawing.Color.Transparent;
            this.womanButton.Location = new System.Drawing.Point(398, 247);
            this.womanButton.Name = "womanButton";
            this.womanButton.Size = new System.Drawing.Size(226, 226);
            this.womanButton.TabIndex = 7;
            this.womanButton.Text = "Woman";
            this.womanButton.UseVisualStyleBackColor = false;
            this.womanButton.Click += new System.EventHandler(this.womanButton_Click);
            this.womanButton.MouseLeave += new System.EventHandler(this.womanButton_MouseLeave);
            this.womanButton.MouseHover += new System.EventHandler(this.womanButton_MouseHover);
            // 
            // boyButton
            // 
            this.boyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.boyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boyButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boyButton.ForeColor = System.Drawing.Color.Transparent;
            this.boyButton.Location = new System.Drawing.Point(73, 540);
            this.boyButton.Name = "boyButton";
            this.boyButton.Size = new System.Drawing.Size(226, 226);
            this.boyButton.TabIndex = 8;
            this.boyButton.Text = "Boy";
            this.boyButton.UseVisualStyleBackColor = false;
            this.boyButton.Click += new System.EventHandler(this.boyButton_Click);
            this.boyButton.MouseLeave += new System.EventHandler(this.boyButton_MouseLeave);
            this.boyButton.MouseHover += new System.EventHandler(this.boyButton_MouseHover);
            // 
            // girlButton
            // 
            this.girlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.girlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girlButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girlButton.ForeColor = System.Drawing.Color.Transparent;
            this.girlButton.Location = new System.Drawing.Point(398, 540);
            this.girlButton.Name = "girlButton";
            this.girlButton.Size = new System.Drawing.Size(226, 226);
            this.girlButton.TabIndex = 9;
            this.girlButton.Text = "Girl";
            this.girlButton.UseVisualStyleBackColor = false;
            this.girlButton.Click += new System.EventHandler(this.girlButton_Click);
            this.girlButton.MouseLeave += new System.EventHandler(this.girlButton_MouseLeave);
            this.girlButton.MouseHover += new System.EventHandler(this.girlButton_MouseHover);
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productButton.ForeColor = System.Drawing.Color.Transparent;
            this.productButton.Location = new System.Drawing.Point(398, 836);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(226, 226);
            this.productButton.TabIndex = 10;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            this.productButton.MouseLeave += new System.EventHandler(this.productButton_MouseLeave);
            this.productButton.MouseHover += new System.EventHandler(this.productButton_MouseHover);
            // 
            // brandButton
            // 
            this.brandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.brandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandButton.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brandButton.ForeColor = System.Drawing.Color.Transparent;
            this.brandButton.Location = new System.Drawing.Point(73, 836);
            this.brandButton.Name = "brandButton";
            this.brandButton.Size = new System.Drawing.Size(226, 226);
            this.brandButton.TabIndex = 11;
            this.brandButton.Text = "Brand";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            this.brandButton.MouseLeave += new System.EventHandler(this.brandButton_MouseLeave);
            this.brandButton.MouseHover += new System.EventHandler(this.brandButton_MouseHover);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(700, 1200);
            this.userControl11.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.nameBox.Location = new System.Drawing.Point(12, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(188, 26);
            this.nameBox.TabIndex = 14;
            // 
            // menuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.brandButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.girlButton);
            this.Controls.Add(this.boyButton);
            this.Controls.Add(this.womanButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.colourBar);
            this.Controls.Add(this.userControl11);
            this.Name = "menuWindow";
            this.Size = new System.Drawing.Size(700, 1200);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gardientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox colourBar;
        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button womanButton;
        private System.Windows.Forms.Button boyButton;
        private System.Windows.Forms.Button girlButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button brandButton;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox nameBox;
    }
}
