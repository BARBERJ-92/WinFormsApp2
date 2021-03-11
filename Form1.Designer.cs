
namespace WinFormsApp2
{
    partial class logInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colourBar = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new WinFormsApp2.gardientPanel();
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gardientPanel1 = new WinFormsApp2.gardientPanel();
            this.userControl11 = new WinFormsApp2.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuWindow1 = new WinFormsApp2.menuWindow();
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gardientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colourBar
            // 
            this.colourBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.colourBar.Location = new System.Drawing.Point(0, 0);
            this.colourBar.Name = "colourBar";
            this.colourBar.Size = new System.Drawing.Size(700, 96);
            this.colourBar.TabIndex = 5;
            this.colourBar.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(200, 96);
            this.gradientPanel1.TabIndex = 6;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // logoBox1
            // 
            this.logoBox1.Image = global::WinFormsApp2.Resource1.StylishYou_Logo_Main;
            this.logoBox1.Location = new System.Drawing.Point(365, 0);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(169, 191);
            this.logoBox1.TabIndex = 7;
            this.logoBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp2.Resource1.WeDevelopNow_logo;
            this.pictureBox1.Location = new System.Drawing.Point(147, 1077);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gardientPanel1
            // 
            this.gardientPanel1.Angle = 90F;
            this.gardientPanel1.BottomColor = System.Drawing.Color.White;
            this.gardientPanel1.Controls.Add(this.button1);
            this.gardientPanel1.Controls.Add(this.textBox5);
            this.gardientPanel1.Controls.Add(this.textBox4);
            this.gardientPanel1.Controls.Add(this.textBox3);
            this.gardientPanel1.Controls.Add(this.textBox2);
            this.gardientPanel1.Controls.Add(this.textBox1);
            this.gardientPanel1.Controls.Add(this.userControl11);
            this.gardientPanel1.Location = new System.Drawing.Point(0, 95);
            this.gardientPanel1.Name = "gardientPanel1";
            this.gardientPanel1.Size = new System.Drawing.Size(700, 1105);
            this.gardientPanel1.TabIndex = 9;
            this.gardientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(700, 1200);
            this.userControl11.TabIndex = 6;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(292, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(325, 418);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '●';
            this.textBox5.Size = new System.Drawing.Size(221, 33);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(325, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 33);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(153, 415);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(166, 36);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(94, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(225, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Employee No.";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(147, 961);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Developed by";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuWindow1
            // 
            this.menuWindow1.Location = new System.Drawing.Point(0, 0);
            this.menuWindow1.Name = "menuWindow1";
            this.menuWindow1.Size = new System.Drawing.Size(700, 1200);
            this.menuWindow1.TabIndex = 10;
            this.menuWindow1.Visible = false;
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 1161);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.colourBar);
            this.Controls.Add(this.gardientPanel1);
            this.Controls.Add(this.menuWindow1);
            this.Name = "logInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gardientPanel1.ResumeLayout(false);
            this.gardientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colourBar;
        private gardientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private gardientPanel gardientPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private menuWindow menuWindow1;
        private UserControl1 userControl11;
    }
}

