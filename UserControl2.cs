using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class menuWindow : UserControl
    {
        public menuWindow()
        {
            InitializeComponent();
            userControl11.Visible = false;

        }

        public void refresh_name()
        {
            string welcome = string.Format("Hi, {0}.", Global.Name);
            nameBox.Text = welcome;
        }


        //
        // Man menu select and display options 
        //

        private void manButton_MouseHover(object sender, EventArgs e)
        {
            manButton.BackColor = Color.FromArgb(46, 180, 198);
        }

        private void manButton_MouseLeave(object sender, EventArgs e)
        {
            manButton.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "man";
            Global.Gender = "Mens";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
            
        }

        //
        //  Woman menu select and display options 
        //

        private void womanButton_MouseHover(object sender, EventArgs e)
        {
            womanButton.BackColor = Color.FromArgb(231, 29, 54);
        }

        private void womanButton_MouseLeave(object sender, EventArgs e)
        {
            womanButton.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "woman";
            Global.Gender = "Ladies";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
        }

        //
        //  Boy menu select and display options
        //

        private void boyButton_MouseHover(object sender, EventArgs e)
        {
            boyButton.BackColor = Color.FromArgb(255, 159, 28);
        }

        private void boyButton_MouseLeave(object sender, EventArgs e)
        {
            boyButton.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void boyButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "boy";
            Global.Gender = "Boys";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
        }

        //
        //  Girl menu select and display options
        //

        private void girlButton_MouseHover(object sender, EventArgs e)
        {
            girlButton.BackColor = Color.FromArgb(255, 159, 28);
        }

        private void girlButton_MouseLeave(object sender, EventArgs e)
        {
            girlButton.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void girlButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "girl";
            Global.Gender = "Girls";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
        }

        // 
        //  Brand button options 
        //

        private void brandButton_MouseHover(object sender, EventArgs e)
        {
            brandButton.BackColor = Color.FromArgb(25, 50, 70);
        }

        private void brandButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "brand";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
        }

        private void brandButton_MouseLeave(object sender, EventArgs e)
        {
            brandButton.BackColor = Color.FromArgb(1, 22, 39);
        }


        //
        // Product button 
        //

        private void productButton_MouseHover(object sender, EventArgs e)
        {
            productButton.BackColor = Color.FromArgb(25, 50, 70);
        }

        private void productButton_MouseLeave(object sender, EventArgs e)
        {
            productButton.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            Global.Selected = "product";
            userControl11.UserControl_update_display();
            userControl11.BringToFront();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.Name = "";
            userControl11.Hide();
            this.Hide();
        }
    }
}
