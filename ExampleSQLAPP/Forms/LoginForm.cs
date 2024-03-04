using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace ExampleSQLAPP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(189, 50);
        }

        public string lUsername => loginField.Text;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            DB db = new DB();

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT Login, Password, Role FROM CUSTOMERS WHERE Login = @logf and Password = @passf", db.GetConnection());

            command.Parameters.Add("@logf", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@passf", SqlDbType.VarChar).Value = passwordUser;

            sda.SelectCommand = command;
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                bool isAdmin = (bool)dt.Rows[0]["Role"];
                if (isAdmin)
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                }
                else
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    string logbasketTableName = loginField.Text + "basket";
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Login or Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
    }
}
