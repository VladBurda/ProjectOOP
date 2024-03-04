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
using System.Text.RegularExpressions;

namespace ExampleSQLAPP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            loginField.Text = "Username";
            loginField.ForeColor = Color.LightGray;

            passwordField.Text = "Password";
            passwordField.ForeColor = Color.LightGray;

            repasswordField.Text = "Password";
            repasswordField.ForeColor = Color.LightGray;

            namebox.Text = "Name";
            namebox.ForeColor = Color.LightGray;

            surnamebox.Text = "Surname";
            surnamebox.ForeColor = Color.LightGray;

            adressbox.Text = "Adress";
            adressbox.ForeColor = Color.LightGray;
        }

        public string rUsername => loginField.Text;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "Username")
            {
                MessageBox.Show("Enter Login");
                return;
            }

            if (isuserexists())
                return;

            if (namebox.Text == "Name")
            {
                MessageBox.Show("Enter Your Name");
                return;
            }

            if (surnamebox.Text == "Surname")
            {
                MessageBox.Show("Enter Your Surname");
                return;
            }

            if (passwordField.Text == "")
            {
                MessageBox.Show("Enter Password");
                return;
            }

            if (passwordField.Text != repasswordField.Text)
            {
                MessageBox.Show("Incorrect Password");
                return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Customers VALUES(@login,@password,0,@name,@surname,@adress)", db.GetConnection());

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = namebox.Text;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = surnamebox.Text;
            command.Parameters.Add("@adress", SqlDbType.VarChar).Value = adressbox.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                string regbasketTableName = loginField.Text + "basket";
                SqlCommand basketcommand = new SqlCommand($"CREATE TABLE {regbasketTableName} (Basketid int identity primary key, ProductID int, number int, foreign key (ProductID) references products(productid))", db.GetConnection());
                basketcommand.ExecuteNonQuery(); // Execute the create table command

                MessageBox.Show("Registration Complete");
                this.Close();
                regbasketTableName = loginField.Text + "basket";
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

            db.CloseConnection();
        }

        public bool isuserexists()
        {
            DB db = new DB();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT Login FROM Customers WHERE Login = @logf", db.GetConnection());

            command.Parameters.Add("@logf", SqlDbType.VarChar).Value = loginField.Text;

            sda.SelectCommand = command;
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username Exists");
                return true;
            }

            else
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void namebox_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == "Name")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }
        }

        private void namebox_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                namebox.Text = "Name";
                namebox.ForeColor = Color.LightGray;
            }
        }

        private void surnamebox_Enter(object sender, EventArgs e)
        {
            if (surnamebox.Text == "Surname")
            {
                surnamebox.Text = "";
                surnamebox.ForeColor = Color.Black;
            }
        }

        private void surnamebox_Leave(object sender, EventArgs e)
        {
            if (surnamebox.Text == "")
            {
                surnamebox.Text = "Surname";
                surnamebox.ForeColor = Color.LightGray;
            }
        }

        private void adressbox_Enter(object sender, EventArgs e)
        {
            if (adressbox.Text == "Adress")
            {
                adressbox.Text = "";
                adressbox.ForeColor = Color.Black;
            }
        }

        private void adressbox_Leave(object sender, EventArgs e)
        {
            if (adressbox.Text == "")
            {
                adressbox.Text = "Adress";
                adressbox.ForeColor = Color.LightGray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Username")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Username";
                loginField.ForeColor = Color.LightGray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Password")
            {
                passwordField.Text = "";
                passwordField.PasswordChar = '\0';
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Password";
                passwordField.PasswordChar = '\0';
                passwordField.ForeColor = Color.LightGray;
            }
        }

        private void repasswordField_Enter(object sender, EventArgs e)
        {
            if (repasswordField.Text == "Password")
            {
                repasswordField.Text = "";
                repasswordField.ForeColor = Color.Black;
            }
        }

        private void repasswordField_Leave(object sender, EventArgs e)
        {
            if (repasswordField.Text == "")
            {
                repasswordField.Text = "Password";
                repasswordField.ForeColor = Color.LightGray;
            }
        }
    }
}
