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

namespace CafeManagement
{
    public partial class UserForm2 : Form
    {
        public UserForm2()
        {
            InitializeComponent();
            populate();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlCommand query;
        SqlDataAdapter adpt;
        DataTable dt;
        public void populate()
        {
            //con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            dataGridView1.DataSource = ds;
            //con.Close();

            //adpt = new SqlDataAdapter("select * from UsersTbl", con);
            //dt = new DataTable();
            //adpt.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemsForm2 item = new ItemsForm2();
            item.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO UsersTbl VALUES(@Name, @Phone, @Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", UnameTb.Text);
            cmd.Parameters.AddWithValue("@Phone", UphoneTb.Text);
            cmd.Parameters.AddWithValue("@Password", UpassTb.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("User successfully created");
            con.Close();
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridVeiw1_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                UnameTb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                UphoneTb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                UpassTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Select the user to be deleted");
            }
            else
            {
                con.Open();
                string query = "DELETE FROM UsersTbl WHERE Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted");
                con.Close();
                populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "" || UpassTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show("Fill All the fields");
            }
            else
            {
                con.Open();
                string query = "UPDATE UsersTbl SET Uname='" + UnameTb.Text + "',Upassword='" + UpassTb.Text + "' WHERE Uphone ='" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully updated");
                con.Close();
                populate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}


