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

namespace ExampleSQLAPP.Forms
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            ProductID.Text = "ProductID";
            ProductID.ForeColor = Color.LightGray;

            Cost.Text = "Cost";
            Cost.ForeColor = Color.LightGray;

            NumberOfProducts.Text = "Number";
            NumberOfProducts.ForeColor = Color.LightGray;

            SupplierId.Text = "Supplier ID";
            SupplierId.ForeColor = Color.LightGray;

            CompanyName.Text = "Company Name";
            CompanyName.ForeColor = Color.LightGray;

            ContactName.Text = "Contact Name";
            ContactName.ForeColor = Color.LightGray;

            City.Text = "City";
            City.ForeColor = Color.LightGray;

            SECCompName.Text = "Contact Number";
            SECCompName.ForeColor = Color.LightGray;

            ID.Text = "Sup ID";
            ID.ForeColor = Color.LightGray;

            NumR.Text = "Num";
            NumR.ForeColor = Color.LightGray;

            ProdID.Text = "ProdID";
            ProdID.ForeColor = Color.LightGray;

            CostR.Text = "Cost";
            CostR.ForeColor = Color.LightGray;

            Descr.Text = "Description";
            Descr.ForeColor = Color.LightGray;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private SqlDataAdapter adapter1 = new SqlDataAdapter();

        private DataTable table1 = new DataTable();

        private SqlDataAdapter adapter2 = new SqlDataAdapter();

        private DataTable table2 = new DataTable();
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlco = new SqlConnection("Data Source=(local);Initial Catalog=Project_W67949;Integrated Security=True;Encrypt=False");

            sqlco.Open();

            adapter = new SqlDataAdapter("select * from supplierdelivers", sqlco);

            table = new DataTable();

            adapter.Fill(table);
            SupplierDelivers.DataSource = table;

            adapter1 = new SqlDataAdapter("select * from suppliers", sqlco);

            table1 = new DataTable();

            adapter1.Fill(table1);
            SupplierInfo.DataSource = table1;

            adapter2 = new SqlDataAdapter("select * from supplierreturns", sqlco);

            table2 = new DataTable();

            adapter2.Fill(table2);
            Return.DataSource = table2;

            sqlco.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            SupplierDelivers.DataSource = table;

            table1.Clear();

            adapter1.Fill(table1);
            SupplierInfo.DataSource = table1;

            table2.Clear();

            adapter2.Fill(table2);
            Return.DataSource = table2;
        }

        private void ProductID_Enter(object sender, EventArgs e)
        {
            if (ProductID.Text == "ProductID")
            {
                ProductID.Text = "";
                ProductID.ForeColor = Color.Black;
            }
        }

        private void ProductID_Leave(object sender, EventArgs e)
        {
            if (ProductID.Text == "")
            {
                ProductID.Text = "ProductID";
                ProductID.ForeColor = Color.LightGray;
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

        private void NumberOfProducts_Enter(object sender, EventArgs e)
        {
            if (NumberOfProducts.Text == "Number")
            {
                NumberOfProducts.Text = "";
                NumberOfProducts.ForeColor = Color.Black;
            }
        }

        private void NumberOfProducts_Leave(object sender, EventArgs e)
        {
            if (NumberOfProducts.Text == "")
            {
                NumberOfProducts.Text = "Number";
                NumberOfProducts.ForeColor = Color.LightGray;
            }
        }

        private void SupplierId_Enter(object sender, EventArgs e)
        {
            if (SupplierId.Text == "Supplier ID")
            {
                SupplierId.Text = "";
                SupplierId.ForeColor = Color.Black;
            }
        }

        private void SupplierId_Leave(object sender, EventArgs e)
        {
            if (SupplierId.Text == "")
            {
                SupplierId.Text = "Supplier ID";
                SupplierId.ForeColor = Color.LightGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExampleSQLAPP.AdminForm administratorForm = new ExampleSQLAPP.AdminForm();
            administratorForm.Show();
        }

        private void DelInfSave_Click(object sender, EventArgs e)
        {
            if (ProductID.Text == "ProductID" || Cost.Text == "Cost" || NumberOfProducts.Text == "Number" || SupplierId.Text == "Supplier ID")
            {
                MessageBox.Show("Text Box Is Empty");
                return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO SupplierDelivers VALUES(@prid,@cost,@numb,@supid,@orderdate)", db.GetConnection());

            command.Parameters.Add("@prid", SqlDbType.VarChar).Value = ProductID.Text;
            command.Parameters.Add("@cost", SqlDbType.VarChar).Value = Cost.Text;
            command.Parameters.Add("@numb", SqlDbType.VarChar).Value = NumberOfProducts.Text;
            command.Parameters.Add("@supid", SqlDbType.VarChar).Value = SupplierId.Text;
            command.Parameters.Add("@orderdate", SqlDbType.DateTime).Value = dateTimePicker1.Value;

            db.OpenConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            db.CloseConnection();
        }
        static bool CheckPhoneNumberFormat(string phoneNumber)
        {
            // Define the regex pattern for the phone number format
            string pattern = @"^\+\d{2} \d{3} \d{3} \d{3}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private void AddDeliver_Click(object sender, EventArgs e)
        {
            if (CompanyName.Text == "Company Name" || City.Text == "City" || CompanyName.Text == "Contact Name" || SECCompName.Text == "Contact Number")
            {
                MessageBox.Show("Text Box Is Empty");
                return;
            }
            if (CheckPhoneNumberFormat(SECCompName.Text) == false)
            {
                MessageBox.Show("Incorrect Phone Number"); return;
            }
            

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO Suppliers VALUES(@comn,@cntname,@seccn,@city)", db.GetConnection());

            command.Parameters.Add("@comn", SqlDbType.VarChar).Value = CompanyName.Text;
            command.Parameters.Add("@city", SqlDbType.VarChar).Value = City.Text;
            command.Parameters.Add("@cntname", SqlDbType.VarChar).Value = ContactName.Text;
            command.Parameters.Add("@seccn", SqlDbType.VarChar).Value = SECCompName.Text;

            db.OpenConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            db.CloseConnection();
        }

        private void CompanyName_Enter(object sender, EventArgs e)
        {
            if (CompanyName.Text == "Company Name")
            {
                CompanyName.Text = "";
                CompanyName.ForeColor = Color.Black;
            }
        }

        private void CompanyName_Leave(object sender, EventArgs e)
        {
            if (CompanyName.Text == "")
            {
                CompanyName.Text = "Company Name";
                CompanyName.ForeColor = Color.LightGray;
            }
        }

        private void City_Enter(object sender, EventArgs e)
        {
            if (City.Text == "City")
            {
                City.Text = "";
                City.ForeColor = Color.Black;
            }
        }

        private void City_Leave(object sender, EventArgs e)
        {
            if (City.Text == "")
            {
                City.Text = "City";
                City.ForeColor = Color.LightGray;
            }
        }

        private void ContactName_Enter(object sender, EventArgs e)
        {
            if (ContactName.Text == "Contact Name")
            {
                ContactName.Text = "";
                ContactName.ForeColor = Color.Black;
            }
        }

        private void ContactName_Leave(object sender, EventArgs e)
        {
            if (ContactName.Text == "")
            {
                ContactName.Text = "Contact Name";
                ContactName.ForeColor = Color.LightGray;
            }
        }

        private void SECCompName_Enter(object sender, EventArgs e)
        {
            if (SECCompName.Text == "Contact Number")
            {
                SECCompName.Text = "";
                SECCompName.ForeColor = Color.Black;
            }
        }

        private void SECCompName_Leave(object sender, EventArgs e)
        {
            if (SECCompName.Text == "")
            {
                SECCompName.Text = "Contact Number";
                SECCompName.ForeColor = Color.LightGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID.Text == "Sup ID" || NumR.Text == "Num" || CostR.Text == "Cost" || Descr.Text == "Description" || ProdID.Text == "ProdID")
            {
                MessageBox.Show("Text Box Is Empty");
                return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO SupplierReturns VALUES(@id,@number,@cost,@desc,@prodID)", db.GetConnection());

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = ID.Text;
            command.Parameters.Add("@number", SqlDbType.VarChar).Value = NumR.Text;
            command.Parameters.Add("@cost", SqlDbType.VarChar).Value = CostR.Text;
            command.Parameters.Add("@desc", SqlDbType.VarChar).Value = Descr.Text;
            command.Parameters.Add("@prodID", SqlDbType.VarChar).Value = ProdID.Text;

            db.OpenConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Return Made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            db.CloseConnection();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            if (ID.Text == "Sup ID")
            {
                ID.Text = "";
                ID.ForeColor = Color.Black;
            }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                ID.Text = "Sup ID";
                ID.ForeColor = Color.LightGray;
            }
        }

        private void NumR_Enter(object sender, EventArgs e)
        {
            if (NumR.Text == "Num")
            {
                NumR.Text = "";
                NumR.ForeColor = Color.Black;
            }
        }

        private void NumR_Leave(object sender, EventArgs e)
        {
            if (NumR.Text == "")
            {
                NumR.Text = "Num";
                NumR.ForeColor = Color.LightGray;
            }
        }


        private void ProdID_Enter(object sender, EventArgs e)
        {
            if (ProdID.Text == "ProdID")
            {
                ProdID.Text = "";
                ProdID.ForeColor = Color.Black;
            }
        }

        private void ProdID_Leave(object sender, EventArgs e)
        {
            if (ProdID.Text == "")
            {
                ProdID.Text = "ProdID";
                ProdID.ForeColor = Color.LightGray;
            }
        }

        private void CostR_Enter(object sender, EventArgs e)
        {
            if (CostR.Text == "Cost")
            {
                CostR.Text = "";
                CostR.ForeColor = Color.Black;
            }
        }

        private void CostR_Leave(object sender, EventArgs e)
        {
            if (CostR.Text == "")
            {
                CostR.Text = "Cost";
                CostR.ForeColor = Color.LightGray;
            }
        }

        private void Descr_Enter(object sender, EventArgs e)
        {
            if (Descr.Text == "Description")
            {
                Descr.Text = "";
                Descr.ForeColor = Color.Black;
            }
        }

        private void Descr_Leave(object sender, EventArgs e)
        {
            if (Descr.Text == "")
            {
                Descr.Text = "Description";
                Descr.ForeColor = Color.LightGray;
            }
        }

    }
}
