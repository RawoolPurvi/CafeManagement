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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public void populate()
        {
            //con.Open();
            string query = "select * from OrderTbl";
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
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private int currentPrintRowIndex = 0; // Move this variable to the class level

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("                    My Cafe", new Font("Century", 30, FontStyle.Bold), Brushes.Red, new Point(100, 10));
            e.Graphics.DrawString("                       ORDER SUMMARY", new Font("Century", 20), Brushes.Red, new Point(100, 60));

            if (currentPrintRowIndex < dataGridView1.Rows.Count)
            {
                e.Graphics.DrawString("Order Number : " + dataGridView1.Rows[currentPrintRowIndex].Cells[0].Value?.ToString(), new Font("Microsoft JhengHei UI", 20, FontStyle.Regular), Brushes.Black, new Point(100, 110));
                e.Graphics.DrawString("Date : " + dataGridView1.Rows[currentPrintRowIndex].Cells[1].Value?.ToString(), new Font("Microsoft JhengHei UI", 20, FontStyle.Regular), Brushes.Black, new Point(100, 160));
                e.Graphics.DrawString("Name : " + dataGridView1.Rows[currentPrintRowIndex].Cells[2].Value?.ToString(), new Font("Microsoft JhengHei UI", 20, FontStyle.Regular), Brushes.Black, new Point(100, 210));
                e.Graphics.DrawString("Amount : " + dataGridView1.Rows[currentPrintRowIndex].Cells[3].Value?.ToString(), new Font("Microsoft JhengHei UI", 20, FontStyle.Regular), Brushes.Black, new Point(100, 260));

                currentPrintRowIndex++;
                e.HasMorePages = currentPrintRowIndex < dataGridView1.Rows.Count;
            }
            else
            {
                e.HasMorePages = false;   // No more pages to print
                currentPrintRowIndex = 0; // Reset the index for the next print job
            }

            e.Graphics.DrawString("                ------ THANK YOU ------", new Font("Century", 20), Brushes.Red, new Point(100, 350));
        }


    }
}
