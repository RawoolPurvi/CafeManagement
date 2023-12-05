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
    public partial class ItemsForm2 : Form
    {
        public ItemsForm2()
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
            string query = "select * from ItemTbl";
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Fill all the boxes");
            }
            else
            {
                //con.Open();
                //string query = "INSERT INTO ItemTbl VALUES(" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text + "')'";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("User Successfully created");
                //con.Close();
                //populate();
                con.Open();
                string query = "INSERT INTO ItemTbl VALUES(@ItemNum, @ItemName, @ItemCat, @ItemPrice)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItemNum", textBox1.Text);
                cmd.Parameters.AddWithValue("@ItemName", textBox2.Text);
                cmd.Parameters.AddWithValue("@ItemCat", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ItemPrice", textBox3.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully created");
                con.Close();
                populate();
            }
        }

        private void ItemsForm2_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Select the user to be deleted");
            }
            else
            {
                con.Open();
                string query = "DELETE FROM ItemTbl WHERE ItemNum = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully deleted");
                con.Close();
                populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Fill All the fields");
            }
            else
            {
                con.Open();
                string query = "UPDATE ItemTbl SET ItemName=@ItemName, ItemPrice=@ItemPrice WHERE ItemNum=@ItemNum";
                SqlCommand cmd = new SqlCommand(query, con);

                // Assuming ItemPrice and ItemNum are of type int in the database
                // If they are decimal or another numeric type, adjust SqlDbType accordingly
                cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = textBox2.Text;

                // Convert the string to a numeric type before setting the parameter
                if (int.TryParse(textBox3.Text, out int itemPrice))
                {
                    cmd.Parameters.Add("@ItemPrice", SqlDbType.Int).Value = itemPrice;
                }
                else
                {
                    // Handle the case where the conversion fails (e.g., show an error message)
                    MessageBox.Show("Invalid Item Price. Please enter a valid number.");
                    con.Close();
                    return; // Exit the method without executing the query
                }

                // Convert the string to an int before setting the parameter
                if (int.TryParse(textBox1.Text, out int itemNum))
                {
                    cmd.Parameters.Add("@ItemNum", SqlDbType.Int).Value = itemNum;
                }
                else
                {
                    // Handle the case where the conversion fails (e.g., show an error message)
                    MessageBox.Show("Invalid Item Number. Please enter a valid number.");
                    con.Close();
                    return; // Exit the method without executing the query
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Item successfully updated");
                con.Close();
                populate();
            }

        }
    }
}
