using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        DataTable dataTable = new DataTable();

        public UserControl1()
        {
            InitializeComponent();
        }

        public void UserControl1_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=UKMANNB10409\SQLEXPRESS;Initial Catalog=style;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            cmd = new SqlCommand(@"select a.[Item Code], a.Brands, a.[Product Type], a.Gender, a.Colour, a.Price, a.Quantity as 'Avaliable', b.Size, b.Quantity from style.dbo.OurProducts a inner join style.dbo.Sizes b on a.[Item Code] = b.[Item Code]; ", cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cnn.Open();
            
            da.Fill(dataTable);
            cnn.Close();
            da.Dispose();

            foreach (DataRow row in dataTable.Rows)
            {
                // Debug.WriteLine(row["Product Type"].ToString());
                
                if(row["Gender"].ToString() == Global.Gender)
                {
                    dropBox1.Items.Add(row["Product Type"].ToString());
                }
            }

            this.Visible = true;
        }

        public void UserControl_update_display( )
        {
            switch (Global.Selected)
            {
                case "man":

                    //
                    //  Set up colour and logo
                    //

                    gradientPanel1.BottomColor = Color.FromArgb(46, 180, 198);
                    colourBar.BackColor = Color.FromArgb(46, 180, 198);
                    findButton.BackColor = Color.FromArgb(46, 180, 198);
                    logoBox1.BackgroundImage = Resource1.stylishGreen;
                    logoBox2.BackgroundImage = Resource1.hangerGreen;
                    titleBox1.ForeColor = Color.FromArgb(46, 180, 198);

                    titleBox1.Text = "Man";

                    //
                    //  Set up avaliable drop down menus
                    //

                    dropBox1Label.Text = "Product Type";
                    dropBox1Label.ForeColor = Color.FromArgb(46, 180, 198);

                    dropBox2Label.Text = "Size";
                    dropBox2Label.ForeColor = Color.FromArgb(46, 180, 198);

                    dropBox3Label.Text = "Colour";
                    dropBox3Label.ForeColor = Color.FromArgb(46, 180, 198);

                    dropBox4Label.Text = "Brand";
                    dropBox4Label.ForeColor = Color.FromArgb(46, 180, 198);

                    minPriceLabel.ForeColor = Color.FromArgb(46, 180, 198);
                    maxPriceLabel.ForeColor = Color.FromArgb(46, 180, 198);

                    this.Visible = true;

                    //
                    //  Set Global Variables
                    // 



                    break;

                case "woman":
                    gradientPanel1.BottomColor = Color.FromArgb(231, 29, 54);
                    colourBar.BackColor = Color.FromArgb(231, 29, 54);
                    findButton.BackColor = Color.FromArgb(231, 29, 54);
                    logoBox1.BackgroundImage = Resource1.stylishRed;
                    logoBox2.BackgroundImage = Resource1.hangerRed;
                    titleBox1.ForeColor = Color.FromArgb(231, 29, 54);
                    titleBox1.Text = "Woman";

                    dropBox1Label.Text = "Product Type";
                    dropBox1Label.ForeColor = Color.FromArgb(231, 29, 54);

                    dropBox2Label.Text = "Size";
                    dropBox2Label.ForeColor = Color.FromArgb(231, 29, 54);

                    dropBox3Label.Text = "Colour";
                    dropBox3Label.ForeColor = Color.FromArgb(231, 29, 54);

                    dropBox4Label.Text = "Brand";
                    dropBox4Label.ForeColor = Color.FromArgb(231, 29, 54);

                    minPriceLabel.ForeColor = Color.FromArgb(231, 29, 54);
                    maxPriceLabel.ForeColor = Color.FromArgb(231, 29, 54);

                    this.Visible = true;
                    break;

                case "boy":
                    gradientPanel1.BottomColor = Color.FromArgb(255, 159, 28);
                    colourBar.BackColor = Color.FromArgb(255, 159, 28);
                    findButton.BackColor = Color.FromArgb(255, 159, 28);
                    logoBox1.BackgroundImage = Resource1.stylishOrange;
                    logoBox2.BackgroundImage = Resource1.hangerOrange;
                    titleBox1.ForeColor = Color.FromArgb(255, 159, 28);
                    titleBox1.Text = "Boy";

                    dropBox1Label.Text = "Product Type";
                    dropBox1Label.ForeColor = Color.FromArgb(255, 159, 28);

                    dropBox2Label.Text = "Size";
                    dropBox2Label.ForeColor = Color.FromArgb(255, 159, 28);

                    dropBox3Label.Text = "Colour";
                    dropBox3Label.ForeColor = Color.FromArgb(255, 159, 28);

                    dropBox4Label.Text = "Brand";
                    dropBox4Label.ForeColor = Color.FromArgb(255, 159, 28);

                    minPriceLabel.ForeColor = Color.FromArgb(255,159, 28);
                    maxPriceLabel.ForeColor = Color.FromArgb(255,159, 28);

                    this.Visible = true;
                    break;

                case "girl":
                    gradientPanel1.BottomColor = Color.FromArgb(255, 159, 28);
                    colourBar.BackColor = Color.FromArgb(255, 159, 28);
                    findButton.BackColor = Color.FromArgb(255, 159, 28);
                    logoBox1.BackgroundImage = Resource1.stylishOrange;
                    logoBox2.BackgroundImage = Resource1.hangerOrange;
                    titleBox1.ForeColor = Color.FromArgb(255, 159, 28);
                    titleBox1.Text = "Girl";

                    dropBox1Label.Text = "Product Type";
                    dropBox1Label.ForeColor = Color.FromArgb(255, 159, 28);

                    dropBox2Label.Text = "Size";
                    dropBox2Label.ForeColor = Color.FromArgb(255, 159, 28);
                    
                    dropBox3Label.Text = "Colour";
                    dropBox3Label.ForeColor = Color.FromArgb(255, 159, 28);

                    dropBox4Label.Text = "Brand";
                    dropBox4Label.ForeColor = Color.FromArgb(255, 159, 28);

                    minPriceLabel.ForeColor = Color.FromArgb(255, 159, 28);
                    maxPriceLabel.ForeColor = Color.FromArgb(255, 159, 28);

                    this.Visible = true;
                    break;

                case "brand":
                    gradientPanel1.BottomColor = Color.FromArgb(1, 22, 39);
                    colourBar.BackColor = Color.FromArgb(1, 22, 39);
                    findButton.BackColor = Color.FromArgb(1, 22, 39);
                    logoBox1.BackgroundImage = Resource1.stylishMain;
                    logoBox2.BackgroundImage = Resource1.hangerMain;
                    titleBox1.ForeColor = Color.FromArgb(1, 22, 39);
                    titleBox1.Text = "Brand";
                    dropBox1Label.Text = "Gender";
                    dropBox1Label.ForeColor = Color.FromArgb(1, 22, 39);

                    dropBox2Label.Text = "Product type";
                    dropBox2Label.ForeColor = Color.FromArgb(1, 22, 39);
                    
                    dropBox3Label.Text = "Size";
                    dropBox3Label.ForeColor = Color.FromArgb(1, 22, 39);
                    
                    dropBox4Label.Text = "Colour";
                    dropBox4Label.ForeColor = Color.FromArgb(1, 22, 39);

                    minPriceLabel.ForeColor = Color.FromArgb(1, 22, 39);
                    maxPriceLabel.ForeColor = Color.FromArgb(1, 22, 39);

                    this.Visible = true;
                    break;

                case "product":
                    gradientPanel1.BottomColor = Color.FromArgb(1, 22, 39);
                    colourBar.BackColor = Color.FromArgb(1, 22, 39);
                    findButton.BackColor = Color.FromArgb(1, 22, 39);
                    logoBox1.BackgroundImage = Resource1.stylishMain;
                    logoBox2.BackgroundImage = Resource1.hangerMain;
                    titleBox1.ForeColor = Color.FromArgb(1, 22, 39);
                    titleBox1.Text = "Product";
                    
                    dropBox1Label.Text = "Gender";
                    dropBox1Label.ForeColor = Color.FromArgb(1, 22, 39);
                    
                    dropBox2Label.Text = "Brand";
                    dropBox2Label.ForeColor = Color.FromArgb(1, 22, 39);
                    
                    dropBox3Label.Text = "Size";
                    dropBox3Label.ForeColor = Color.FromArgb(1, 22, 39);

                    dropBox4Label.Text = "Colour";
                    dropBox4Label.ForeColor = Color.FromArgb(1, 22, 39);

                    minPriceLabel.ForeColor = Color.FromArgb(1, 22, 39);
                    maxPriceLabel.ForeColor = Color.FromArgb(1, 22, 39);

                    this.Visible = true;
                    break;

                default:
                    break;
            }
        }

 
        public void clearGlobal()
        {
            Global.Gender = "";
            Global.Brand = "";
            Global.ProductType = "";
            Global.Colour = "";
            Global.Location = "";
            Global.Price = '0';
            Global.Quantity = '0';
            Global.Size = "";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
            clearGlobal();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
            clearGlobal();
        }

        private void dropBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ProductType = (string)dropBox1.SelectedItem;
            Debug.WriteLine("Selected dropBox1 - " + Global.ProductType);

            dropBox2.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                if(row["Product Type"].ToString() == (string)dropBox1.SelectedItem)
                {
                    dropBox2.Items.Add(row["Size"].ToString());
                }
            }
        }

        public void dropBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.Size = (string)dropBox2.SelectedItem;
            Debug.WriteLine("Selected dropBox2 - " + Global.Size);

            dropBox3.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                if( (row["Product Type"].ToString() == (string)dropBox1.SelectedItem) &&
                    (row["Size"].ToString() == (string)dropBox2.SelectedItem))
                {
                    dropBox3.Items.Add(row["Colour"].ToString());
                }
            }
        }

        private void dropBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.Colour = (string)dropBox3.SelectedItem;
            Debug.WriteLine("Selected dropBox3 - " + Global.Colour);

            dropBox4.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                if ((row["Product Type"].ToString() == (string)dropBox1.SelectedItem) &&
                    (row["Size"].ToString() == (string)dropBox2.SelectedItem) &&
                    (row["Colour"].ToString() == (string)dropBox3.SelectedItem))
                {
                    dropBox4.Items.Add(row["Brands"].ToString());
                }
            }
        }

        private void minPriceLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void minPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // SQL connection

            string myconnect = @"Data Source=UKMANNB10409\SQLEXPRESS;Initial Catalog=style;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn;
            cnn = new SqlConnection(myconnect);

            // SQL query

            string query = string.Format("SELECT * from OurProducts where Gender = '{0}' and [Product Type] = '{1}' and Size = '{2}' and Colour = '{3}' and Brands = '{4}';", Global.Gender, Global.ProductType, Global.Size, Global.Colour, Global.Brand);

            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {

                Debug.WriteLine(read.GetValue(2));

            }
            cnn.Close();
        }
    }
}
