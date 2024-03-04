using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExampleSQLAPP.Forms
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        //----------------------------------------------------------------------------------------------
        string logbasketTableName = (Application.OpenForms["LoginForm"] as LoginForm)?.lUsername + "basket";
        string regbasketTableName = (Application.OpenForms["RegisterForm"] as RegisterForm)?.rUsername + "basket";

        private SqlDataAdapter adapter = new SqlDataAdapter();

        private DataTable table = new DataTable();
        //----------------------------------------------------------------------------------------------

        private void Basket_Load(object sender, EventArgs e)
        {
            SqlConnection sqlco = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

            sqlco.Open();

            if (logbasketTableName == "basket")
            {
                adapter = new SqlDataAdapter($"select {regbasketTableName}.ProductID, products.ProductName, {regbasketTableName}.Number from {regbasketTableName} inner join products on {regbasketTableName}.ProductID = Products.productid", sqlco);
            }
            else
            {
                adapter = new SqlDataAdapter($"select {logbasketTableName}.ProductID, products.ProductName, {logbasketTableName}.Number from {logbasketTableName} inner join products on {logbasketTableName}.ProductID = Products.productid", sqlco);
            }

            table = new DataTable();

            adapter.Fill(table);
            Backet.DataSource = table;

            sqlco.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string tableNameWithoutBasket = logbasketTableName.Replace("basket", "");

            DB db = new DB();
            SqlCommand command = new SqlCommand($"INSERT INTO Orders VALUES ('{tableNameWithoutBasket}', GETDATE(), (SELECT address FROM customers WHERE login = '{tableNameWithoutBasket}'), 0);", db.GetConnection());

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Order Complete");
                this.Close();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

            db.CloseConnection();
        }
    }
}
