using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExampleSQLAPP.Forms
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            EmployeeID.Text = "ID";
            EmployeeID.ForeColor = Color.LightGray;

            FirstName.Text = "FirstName";
            FirstName.ForeColor = Color.LightGray;

            LastName.Text = "LastName";
            LastName.ForeColor = Color.LightGray;

            Salary.Text = "Salary";
            Salary.ForeColor = Color.LightGray;

            ContactNum.Text = "Contact";
            ContactNum.ForeColor = Color.LightGray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void Panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            EmployeeInfo.DataSource = table;
        }
        private SqlDataAdapter adapter = new SqlDataAdapter();

        private DataTable table = new DataTable();
        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection sqlco = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

            sqlco.Open();

            adapter = new SqlDataAdapter("select * from employees", sqlco);

            table = new DataTable();

            adapter.Fill(table);
            EmployeeInfo.DataSource = table;

            sqlco.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(EmployeeID.Text, out int employeeID))
            {
                MessageBox.Show("EmployeeID Must Be an Integer");
                return;
            }

            try
            {
                DB db = new DB();
                SqlCommand command = new SqlCommand("update Employees set LastWorkDate = @dtp1 where EmployeeID = @id", db.GetConnection());

                // Format the date from dateTimePicker1
                string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                command.Parameters.Add("@dtp1", SqlDbType.DateTime).Value = formattedDate;
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = EmployeeID.Text;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Fired!");
                }
                else
                {
                    MessageBox.Show("No employee with the specified ID found!");
                }

                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        static bool CheckPhoneNumberFormat(string phoneNumber)
        {
            // Define the regex pattern for the phone number format
            string pattern = @"^\+\d{2} \d{3} \d{3} \d{3}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "FirstName" || FirstName.Text == "FirstName" || Salary.Text == "Salary" || ContactNum.Text == "Contact")
            {
                MessageBox.Show("Text Box Is Empty");
                return;
            }

            if (CheckPhoneNumberFormat(ContactNum.Text) == false)
            {
                MessageBox.Show("Incorrect Phone Number"); return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Employees VALUES(@fname,@lname,@cont,@fwd,null,@sal)", db.GetConnection());

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FirstName.Text;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = LastName.Text;
            command.Parameters.Add("@cont", SqlDbType.VarChar).Value = ContactNum.Text;
            string formattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            command.Parameters.Add("@fwd", SqlDbType.DateTime).Value = formattedDate;
            command.Parameters.Add("@sal", SqlDbType.VarChar).Value = Salary.Text;
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Product Added");
            }

            else
                MessageBox.Show("error");

            db.CloseConnection();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.Show();
        }

        private void EmployeeID_Enter(object sender, EventArgs e)
        {
            if (EmployeeID.Text == "ID")
            {
                EmployeeID.Text = "";
                EmployeeID.ForeColor = Color.Black;
            }
        }

        private void EmployeeID_Leave(object sender, EventArgs e)
        {
            if (EmployeeID.Text == "")
            {
                EmployeeID.Text = "ID";
                EmployeeID.ForeColor = Color.LightGray;
            }
        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "FirstName")
            {
                FirstName.Text = "";
                FirstName.ForeColor = Color.Black;
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "FirstName";
                FirstName.ForeColor = Color.LightGray;
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "LastName")
            {
                LastName.Text = "";
                LastName.ForeColor = Color.Black;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                LastName.Text = "LastName";
                LastName.ForeColor = Color.LightGray;
            }
        }

        private void ContactNum_Enter(object sender, EventArgs e)
        {
            if (ContactNum.Text == "Contact")
            {
                ContactNum.Text = "";
                ContactNum.ForeColor = Color.Black;
            }
        }

        private void ContactNum_Leave(object sender, EventArgs e)
        {
            if (ContactNum.Text == "")
            {
                ContactNum.Text = "Contact";
                ContactNum.ForeColor = Color.LightGray;
            }
        }

        private void Salary_Enter(object sender, EventArgs e)
        {
            if (Salary.Text == "Salary")
            {
                Salary.Text = "";
                Salary.ForeColor = Color.Black;
            }
        }

        private void Salary_Leave(object sender, EventArgs e)
        {
            if (Salary.Text == "")
            {
                Salary.Text = "Salary";
                Salary.ForeColor = Color.LightGray;
            }
        }
    }
}
