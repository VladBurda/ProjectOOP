using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLAPP.Forms
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        public string basketname => textBox1.Text;

        private SqlDataAdapter adapter = new SqlDataAdapter();

        private DataTable table = new DataTable();
        private void Orders_Load(object sender, EventArgs e)
        {
            SqlConnection sqlco = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

            sqlco.Open();

            adapter = new SqlDataAdapter("select * from orders", sqlco);

            table = new DataTable();

            adapter.Fill(table);
            ord.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            ord.DataSource = table;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.Show();
        }

        Point LastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand($"update orders set statusoforder = 1 where customer = @cust", db.GetConnection());

            command.Parameters.Add("@cust", SqlDbType.VarChar).Value = compord.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Completed");
            }
            else
            {
                MessageBox.Show("Error");
            }

            db.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                this.Hide();
                OrderDetails orderDetails = new OrderDetails();
                orderDetails.Show();
            }
            else
            {
                MessageBox.Show("Enter The BasketName");
            }
        }
    }
}
