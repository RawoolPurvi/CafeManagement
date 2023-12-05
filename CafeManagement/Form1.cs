using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemForm item = new itemForm();
            item.Show();
        }
        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {
            user =textBox1.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter a username or password");
            }
            else
            {
                con.Open();
                string query = "select count(*) from UsersTbl where Uname=@Uname and Upassword=@Upassword";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Uname", textBox1.Text);
                sda.SelectCommand.Parameters.AddWithValue("@Upassword", textBox2.Text);

                DataTable ds = new DataTable();
                sda.Fill(ds);

                con.Close();

                if (ds.Rows.Count > 0 && Convert.ToInt32(ds.Rows[0][0]) > 0)
                {
                    UserOrder uorder = new UserOrder();
                    uorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
