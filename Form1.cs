using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;


namespace WinFormsApp2
{
    public partial class logInForm : Form
    {
        private const bool V = true;

        public logInForm()
        {
            InitializeComponent();
            userControl11.Visible = false;
            menuWindow1.Visible = false;
        }

        private void refresh_text()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 180, 198);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 22, 39);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int user = Int32.Parse(textBox4.Text);
            string pw = textBox5.Text;

            // SQL connection
            
            string myconnect = @"Data Source=UKMANNB10409\SQLEXPRESS;Initial Catalog=style;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnn;
            cnn = new SqlConnection(myconnect);

            // SQL query

            string query = string.Format("SELECT * from Users where EmployeeID = '{0}' and Password = '{1}';", user, pw);
            //string query = string.Format("SELECT * from Users where EmployeeID = '1234' and Password = 'test';");

            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                
                Global.Name = (string) read.GetValue(2);
                 
            }
            cnn.Close();

            if (Global.Name == "")
            {
                this.Close();
            }
            else
            {
                refresh_text();
                menuWindow1.refresh_name();
                menuWindow1.BringToFront();
                menuWindow1.Visible = true;
                userControl11.SendToBack();

            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
