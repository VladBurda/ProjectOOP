using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleSQLAPP.Forms;
using Microsoft.Data.SqlClient;

namespace ExampleSQLAPP
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            ProductName.Text = "Name";
            ProductName.ForeColor = Color.LightGray;

            Number.Text = "Num";
            Number.ForeColor = Color.LightGray;

            Cost.Text = "Cost";
            Cost.ForeColor = Color.LightGray;

            ProductId.Text = "ID";
            ProductId.ForeColor = Color.LightGray;

            textBox1.Text = "ID";
            textBox1.ForeColor = Color.LightGray;

            textBox2.Text = "Num";
            textBox2.ForeColor = Color.LightGray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        private SqlDataAdapter adapter = new SqlDataAdapter();

        private DataTable table = new DataTable();
        private void AdminForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlco = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

            sqlco.Open();

            adapter = new SqlDataAdapter("select * from products", sqlco);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "Name")
            {
                MessageBox.Show("Enter Product Name");
                return;
            }

            if (Number.Text == "Num")
            {
                MessageBox.Show("Enter Number Of Products");
                return;
            }

            if (Cost.Text == "Cost")
            {
                MessageBox.Show("Enter Cost Of The Product");
                return;
            }

            if (isproductexists())
                return;

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO products VALUES(@name,@num,@cost)", db.GetConnection());

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = ProductName.Text;
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = Number.Text;
            command.Parameters.Add("@cost", SqlDbType.VarChar).Value = Cost.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Product Added");
            }

            else
                MessageBox.Show("error");

            db.CloseConnection();
        }
        public bool isproductexists()
        {
            DB db = new DB();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT ProductName FROM Products WHERE ProductName = @name", db.GetConnection());

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = ProductName.Text;

            sda.SelectCommand = command;
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Product Exists");
                return true;
            }

            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ProductId.Text, out _))
            {
                MessageBox.Show("Enter Product ID (Number)");
                return;
            }


            DB db = new DB();
            SqlCommand command = new SqlCommand("DELETE FROM PRODUCTS WHERE PRODUCTID = @ID", db.GetConnection());

            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = ProductId.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Product Deleted");
            }

            else
                MessageBox.Show("error");

            db.CloseConnection();
        }

        private void ProductName_Enter(object sender, EventArgs e)
        {
            if (ProductName.Text == "Name")
            {
                ProductName.Text = "";
                ProductName.ForeColor = Color.Black;
            }
        }

        private void ProductName_Leave(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                ProductName.Text = "Name";
                ProductName.ForeColor = Color.LightGray;
            }
        }

        private void Number_Enter(object sender, EventArgs e)
        {
            if (Number.Text == "Num")
            {
                Number.Text = "";
                Number.ForeColor = Color.Black;
            }
        }

        private void Number_Leave(object sender, EventArgs e)
        {
            if (Number.Text == "")
            {
                Number.Text = "Num";
                Number.ForeColor = Color.LightGray;
            }
        }

        private void Cost_Enter(object sender, EventArgs e)
        {
            if (Cost.Text == "Cost")
            {
                Cost.Text = "";
                Cost.ForeColor = Color.Black;
            }
        }

        private void Cost_Leave(object sender, EventArgs e)
        {
            if (Cost.Text == "")
            {
                Cost.Text = "Cost";
                Cost.ForeColor = Color.LightGray;
            }
        }

        private void ProductId_Enter(object sender, EventArgs e)
        {
            if (ProductId.Text == "ID")
            {
                ProductId.Text = "";
                ProductId.ForeColor = Color.Black;
            }
        }

        private void ProductId_Leave(object sender, EventArgs e)
        {
            if (ProductId.Text == "")
            {
                ProductId.Text = "ID";
                ProductId.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ID";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Num")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Num";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Select an Action");
                return;
            }

            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Select 1 Action");
                return;
            }


            DB db = new DB();
            SqlCommand command = new SqlCommand("UPDATE Products SET NumberOfProducts = NumberOfProducts " + (checkBox1.Checked ? "+ @amount" : "- @amount") + " WHERE productid = @prodid", db.GetConnection());

            command.Parameters.Add("@amount", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@prodid", SqlDbType.VarChar).Value = textBox1.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Succes");
            }

            else
                MessageBox.Show("error");

            db.CloseConnection();
        }

        private void SupplierF_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierForm supplierf = new SupplierForm();
            supplierf.Show();
        }

        private void EmployeeF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee emolf = new Employee();
            emolf.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void OrderInf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.Show();
        }
    }
}
