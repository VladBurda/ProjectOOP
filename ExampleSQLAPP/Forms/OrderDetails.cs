using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExampleSQLAPP.Forms
{
    public partial class OrderDetails : Form
    {
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        private string basketName;

        public OrderDetails()
        {
            InitializeComponent();
            basketName = (Application.OpenForms["Orders"] as Orders)?.basketname + "basket";
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False"))
                {
                    sqlConn.Open();

                    SqlCommand cmd = new SqlCommand($"SELECT * FROM {basketName}", sqlConn);

                    adapter.SelectCommand = cmd;

                    table.Clear();
                    adapter.Fill(table);
                    ord.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Orders orders = new Orders();
            orders.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                table.Clear();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
