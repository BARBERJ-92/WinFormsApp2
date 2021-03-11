
namespace WinFormsApp2
{
    partial class resultWindow
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
            this.colourBar = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new WinFormsApp2.gardientPanel();
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.logoBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // colourBar
            // 
            this.colourBar.Location = new System.Drawing.Point(0, 0);
            this.colourBar.Name = "colourBar";
            this.colourBar.Size = new System.Drawing.Size(700, 95);
            this.colourBar.TabIndex = 2;
            this.colourBar.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(200, 95);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.SystemColors.Control;
            // 
            // logoBox1
            // 
            this.logoBox1.Location = new System.Drawing.Point(365, 0);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(181, 95);
            this.logoBox1.TabIndex = 4;
            this.logoBox1.TabStop = false;
            // 
            // logoBox2
            // 
            this.logoBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox2.Location = new System.Drawing.Point(365, 95);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(70, 95);
            this.logoBox2.TabIndex = 5;
            this.logoBox2.TabStop = false;
            // 
            // resultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoBox2);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.colourBar);
            this.Name = "resultWindow";
            this.Size = new System.Drawing.Size(700, 1200);
            ((System.ComponentModel.ISupportInitialize)(this.colourBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colourBar;
        private gardientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.PictureBox logoBox2;
    }
}
