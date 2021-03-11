
namespace WinFormsApp2
{
    partial class UserControl1
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
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.colourBar = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new WinFormsApp2.gardientPanel();
            this.logoBox2 = new System.Windows.Forms.PictureBox();
            this.titleBox1 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.dropBox1 = new System.Windows.Forms.ComboBox();
            this.dropBox2 = new System.Windows.Forms.ComboBox();
            this.dropBox3 = new System.Windows.Forms.ComboBox();
            this.dropBox4 = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.dropBox1Label = new System.Windows.Forms.TextBox();
            this.dropBox2Label = new System.Windows.Forms.TextBox();
            this.dropBox3Label = new System.Windows.Forms.TextBox();
            this.dropBox4Label = new System.Windows.Forms.TextBox();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.minPriceBox = new System.Windows.Forms.TextBox();
            this.minPriceLabel = new System.Windows.Forms.TextBox();
            this.maxPriceLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox1
            // 
            this.logoBox1.Location = new System.Drawing.Point(365, 0);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(181, 95);
            this.logoBox1.TabIndex = 0;
            this.logoBox1.TabStop = false;
            // 
            // colourBar
            // 
            this.colourBar.Location = new System.Drawing.Point(0, 0);
            this.colourBar.Name = "colourBar";
            this.colourBar.Size = new System.Drawing.Size(700, 95);
            this.colourBar.TabIndex = 1;
            this.colourBar.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(200, 95);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.Control;
            // 
            // logoBox2
            // 
            this.logoBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox2.Location = new System.Drawing.Point(365, 95);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(70, 95);
            this.logoBox2.TabIndex = 3;
            this.logoBox2.TabStop = false;
            // 
            // titleBox1
            // 
            this.titleBox1.BackColor = System.Drawing.SystemColors.Control;
            this.titleBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleBox1.Location = new System.Drawing.Point(457, 113);
            this.titleBox1.Name = "titleBox1";
            this.titleBox1.Size = new System.Drawing.Size(198, 59);
            this.titleBox1.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.AutoEllipsis = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::WinFormsApp2.Resource1.back_arrow;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(158, 942);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 95);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = global::WinFormsApp2.Resource1.iconfinder_home_126572;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(411, 942);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(95, 95);
            this.homeButton.TabIndex = 6;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // dropBox1
            // 
            this.dropBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox1.FormattingEnabled = true;
            this.dropBox1.Location = new System.Drawing.Point(67, 298);
            this.dropBox1.Name = "dropBox1";
            this.dropBox1.Size = new System.Drawing.Size(588, 33);
            this.dropBox1.TabIndex = 7;
            this.dropBox1.SelectedIndexChanged += new System.EventHandler(this.dropBox1_SelectedIndexChanged);
            // 
            // dropBox2
            // 
            this.dropBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox2.FormattingEnabled = true;
            this.dropBox2.Location = new System.Drawing.Point(67, 384);
            this.dropBox2.Name = "dropBox2";
            this.dropBox2.Size = new System.Drawing.Size(588, 33);
            this.dropBox2.TabIndex = 8;
            this.dropBox2.SelectedIndexChanged += new System.EventHandler(this.dropBox2_SelectedIndexChanged);
            // 
            // dropBox3
            // 
            this.dropBox3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox3.FormattingEnabled = true;
            this.dropBox3.Location = new System.Drawing.Point(67, 474);
            this.dropBox3.Name = "dropBox3";
            this.dropBox3.Size = new System.Drawing.Size(588, 33);
            this.dropBox3.TabIndex = 9;
            this.dropBox3.SelectedIndexChanged += new System.EventHandler(this.dropBox3_SelectedIndexChanged);
            // 
            // dropBox4
            // 
            this.dropBox4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox4.FormattingEnabled = true;
            this.dropBox4.Location = new System.Drawing.Point(67, 565);
            this.dropBox4.Name = "dropBox4";
            this.dropBox4.Size = new System.Drawing.Size(588, 33);
            this.dropBox4.TabIndex = 11;
            // 
            // findButton
            // 
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findButton.ForeColor = System.Drawing.Color.Transparent;
            this.findButton.Location = new System.Drawing.Point(67, 747);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(588, 104);
            this.findButton.TabIndex = 13;
            this.findButton.Text = "FIND";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dropBox1Label
            // 
            this.dropBox1Label.BackColor = System.Drawing.SystemColors.Control;
            this.dropBox1Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dropBox1Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox1Label.Location = new System.Drawing.Point(67, 266);
            this.dropBox1Label.Name = "dropBox1Label";
            this.dropBox1Label.Size = new System.Drawing.Size(100, 26);
            this.dropBox1Label.TabIndex = 14;
            // 
            // dropBox2Label
            // 
            this.dropBox2Label.BackColor = System.Drawing.SystemColors.Control;
            this.dropBox2Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dropBox2Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox2Label.Location = new System.Drawing.Point(67, 352);
            this.dropBox2Label.Name = "dropBox2Label";
            this.dropBox2Label.Size = new System.Drawing.Size(100, 26);
            this.dropBox2Label.TabIndex = 15;
            // 
            // dropBox3Label
            // 
            this.dropBox3Label.BackColor = System.Drawing.SystemColors.Control;
            this.dropBox3Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dropBox3Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox3Label.Location = new System.Drawing.Point(67, 442);
            this.dropBox3Label.Name = "dropBox3Label";
            this.dropBox3Label.Size = new System.Drawing.Size(100, 26);
            this.dropBox3Label.TabIndex = 16;
            // 
            // dropBox4Label
            // 
            this.dropBox4Label.BackColor = System.Drawing.SystemColors.Control;
            this.dropBox4Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dropBox4Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropBox4Label.Location = new System.Drawing.Point(67, 533);
            this.dropBox4Label.Name = "dropBox4Label";
            this.dropBox4Label.Size = new System.Drawing.Size(100, 26);
            this.dropBox4Label.TabIndex = 17;
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.BackColor = System.Drawing.SystemColors.Window;
            this.maxPriceBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxPriceBox.Location = new System.Drawing.Point(406, 652);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(249, 33);
            this.maxPriceBox.TabIndex = 19;
            // 
            // minPriceBox
            // 
            this.minPriceBox.BackColor = System.Drawing.SystemColors.Window;
            this.minPriceBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minPriceBox.Location = new System.Drawing.Point(67, 652);
            this.minPriceBox.Name = "minPriceBox";
            this.minPriceBox.Size = new System.Drawing.Size(249, 33);
            this.minPriceBox.TabIndex = 20;
            this.minPriceBox.TextChanged += new System.EventHandler(this.minPriceBox_TextChanged);
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.minPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minPriceLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minPriceLabel.Location = new System.Drawing.Point(67, 620);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(121, 26);
            this.minPriceLabel.TabIndex = 21;
            this.minPriceLabel.Text = "Min Price";
            this.minPriceLabel.TextChanged += new System.EventHandler(this.minPriceLabel_TextChanged);
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxPriceLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxPriceLabel.Location = new System.Drawing.Point(406, 620);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(121, 26);
            this.maxPriceLabel.TabIndex = 22;
            this.maxPriceLabel.Text = "Max Price";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.minPriceBox);
            this.Controls.Add(this.maxPriceBox);
            this.Controls.Add(this.dropBox4Label);
            this.Controls.Add(this.dropBox3Label);
            this.Controls.Add(this.dropBox2Label);
            this.Controls.Add(this.dropBox1Label);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.dropBox4);
            this.Controls.Add(this.dropBox3);
            this.Controls.Add(this.dropBox2);
            this.Controls.Add(this.dropBox1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleBox1);
            this.Controls.Add(this.logoBox2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.colourBar);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(700, 1200);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.PictureBox colourBar;
        private gardientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox logoBox2;
        private System.Windows.Forms.TextBox titleBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ComboBox dropBox1;
        private System.Windows.Forms.ComboBox dropBox2;
        private System.Windows.Forms.ComboBox dropBox3;
        private System.Windows.Forms.ComboBox dropBox4;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox dropBox1Label;
        private System.Windows.Forms.TextBox dropBox2Label;
        private System.Windows.Forms.TextBox dropBox3Label;
        private System.Windows.Forms.TextBox dropBox4Label;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.TextBox minPriceBox;
        private System.Windows.Forms.TextBox minPriceLabel;
        private System.Windows.Forms.TextBox maxPriceLabel;
    }
}
