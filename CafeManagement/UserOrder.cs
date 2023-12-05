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
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

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
        public void filterbycategory()
        {
            //con.Open();
            string query = "select * from ItemTbl where ItemCat = '" + comboBox1.SelectedItem.ToString() + "'";
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm2 item = new ItemsForm2();
            item.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm2 user = new UserForm2();
            user.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                item = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                cat = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString());
                flag = 1;
                populate();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int num = 0;
        int price, total;
        string item, cat;
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            dataGridView2.DataSource = table;
            label10.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            textBox2.Text = Form1.user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("What is the quantity of the item ? ");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(textBox3.Text);
                table.Rows.Add(num, item, cat, price, total);
                dataGridView2.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            label2.Text = "" + sum;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            // Generate a unique OrderNum manually (you can modify this logic based on your requirements)
            int uniqueOrderNum = GetUniqueOrderNum();

            string query = "INSERT INTO OrderTbl VALUES(@OrderNum, @Date, @User, @Amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@OrderNum", uniqueOrderNum);
            cmd.Parameters.AddWithValue("@Date", label10.Text);
            cmd.Parameters.AddWithValue("@User", textBox2.Text);
            cmd.Parameters.AddWithValue("@Amount", label2.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Order successfully created with OrderNum: " + uniqueOrderNum);

            con.Close();
            populate();
        }

        private int GetUniqueOrderNum()
        {
            // Logic to generate a unique OrderNum
            // You can fetch the maximum existing OrderNum and increment it
            // or use a timestamp-based approach, depending on your requirements
            int maxOrderNum = GetMaxOrderNumFromDatabase(); // Implement this function
            return maxOrderNum + 1;
        }

        private int GetMaxOrderNumFromDatabase()
        {
            // Implement logic to fetch the maximum OrderNum from the OrderTbl
            // For example:
            using (SqlCommand cmd = new SqlCommand("SELECT MAX(OrderNum) FROM OrderTbl", con))
            {
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0; // If there are no existing OrderNum values
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }
    }

}

