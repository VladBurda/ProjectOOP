using ExampleSQLAPP.Forms;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLAPP
{
    public partial class MainForm : Form
    {
        private readonly string _connectionString = "Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False";
        private readonly string _basketTableName;

        public MainForm()
        {
            InitializeComponent();

            InitializeTextBox(textBox1, "ID");
            InitializeTextBox(textBox2, "Num");

            _basketTableName = GetBasketTableName();
        }

        private void InitializeTextBox(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.LightGray;
        }

        private string GetBasketTableName()
        {
            if (Application.OpenForms["LoginForm"] is LoginForm loginForm)
                return loginForm.lUsername + "basket";
            else if (Application.OpenForms["RegisterForm"] is RegisterForm registerForm)
                return registerForm.rUsername + "basket";
            return "basket";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM products", connection);
                DataTable table = new DataTable();

                adapter.Fill(table);
                ProductsC.DataSource = table;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM products", connection);
                DataTable table = new DataTable();

                adapter.Fill(table);
                ProductsC.DataSource = table;
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
                MessageBox.Show("Select only one Action");
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                if (!int.TryParse(textBox1.Text, out int productId))
                {
                    MessageBox.Show("Invalid product ID");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity");
                    return;
                }

                string commandText = checkBox1.Checked
                    ? $"INSERT INTO {_basketTableName} (number, productID) VALUES (@amount, @prodid)"
                    : $"UPDATE {_basketTableName} SET number = (number {(checkBox2.Checked ? "-" : "+")} @amount) WHERE productid = @prodid";

                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@amount", quantity);
                command.Parameters.AddWithValue("@prodid", productId);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show(rowsAffected == 1 ? "Success" : "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Basket().Show();
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
    }
}

