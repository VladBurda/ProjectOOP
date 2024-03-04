namespace ExampleSQLAPP.Forms
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            button1 = new Button();
            RefreshButton = new Button();
            CloseButton = new Label();
            label1 = new Label();
            SupplierDelivers = new DataGridView();
            ProductID = new TextBox();
            NumberOfProducts = new TextBox();
            Cost = new TextBox();
            SupplierId = new TextBox();
            label2 = new Label();
            DelInfSave = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            SupplierInfo = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            button2 = new Button();
            Descr = new TextBox();
            CostR = new TextBox();
            ProdID = new TextBox();
            NumR = new TextBox();
            ID = new TextBox();
            Return = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            AddDeliver = new Button();
            label4 = new Label();
            SECCompName = new TextBox();
            City = new TextBox();
            ContactName = new TextBox();
            CompanyName = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierDelivers).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierInfo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Return).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 94);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1138, 54);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RefreshButton.Location = new Point(1238, 54);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(1312, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 22);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "x";
            CloseButton.TextAlign = ContentAlignment.TopCenter;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 9);
            label1.Name = "label1";
            label1.Size = new Size(593, 77);
            label1.TabIndex = 0;
            label1.Text = "Supplier Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SupplierDelivers
            // 
            SupplierDelivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SupplierDelivers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SupplierDelivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SupplierDelivers.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SupplierDelivers.DefaultCellStyle = dataGridViewCellStyle2;
            SupplierDelivers.Location = new Point(0, 180);
            SupplierDelivers.Name = "SupplierDelivers";
            SupplierDelivers.RowHeadersWidth = 60;
            SupplierDelivers.Size = new Size(1347, 160);
            SupplierDelivers.TabIndex = 2;
            // 
            // ProductID
            // 
            ProductID.Font = new Font("Arial Narrow", 18F);
            ProductID.Location = new Point(236, 346);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(181, 42);
            ProductID.TabIndex = 3;
            ProductID.Enter += ProductID_Enter;
            ProductID.Leave += ProductID_Leave;
            // 
            // NumberOfProducts
            // 
            NumberOfProducts.Font = new Font("Arial Narrow", 18F);
            NumberOfProducts.Location = new Point(610, 346);
            NumberOfProducts.Name = "NumberOfProducts";
            NumberOfProducts.Size = new Size(181, 42);
            NumberOfProducts.TabIndex = 4;
            NumberOfProducts.Enter += NumberOfProducts_Enter;
            NumberOfProducts.Leave += NumberOfProducts_Leave;
            // 
            // Cost
            // 
            Cost.Font = new Font("Arial Narrow", 18F);
            Cost.Location = new Point(423, 346);
            Cost.Name = "Cost";
            Cost.Size = new Size(181, 42);
            Cost.TabIndex = 5;
            Cost.Enter += Cost_Enter;
            Cost.Leave += Cost_Leave;
            // 
            // SupplierId
            // 
            SupplierId.Font = new Font("Arial Narrow", 18F);
            SupplierId.Location = new Point(797, 346);
            SupplierId.Name = "SupplierId";
            SupplierId.Size = new Size(181, 42);
            SupplierId.TabIndex = 6;
            SupplierId.Enter += SupplierId_Enter;
            SupplierId.Leave += SupplierId_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 349);
            label2.Name = "label2";
            label2.Size = new Size(210, 35);
            label2.TabIndex = 8;
            label2.Text = "Add Delivery Info:";
            // 
            // DelInfSave
            // 
            DelInfSave.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelInfSave.Location = new Point(1240, 355);
            DelInfSave.Name = "DelInfSave";
            DelInfSave.Size = new Size(94, 29);
            DelInfSave.TabIndex = 9;
            DelInfSave.Text = "Save";
            DelInfSave.UseVisualStyleBackColor = true;
            DelInfSave.Click += DelInfSave_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(0, 394);
            panel4.Name = "panel4";
            panel4.Size = new Size(1344, 10);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(499, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 341);
            panel3.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(984, 346);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 42);
            dateTimePicker1.TabIndex = 11;
            // 
            // SupplierInfo
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SupplierInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SupplierInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            SupplierInfo.DefaultCellStyle = dataGridViewCellStyle4;
            SupplierInfo.Location = new Point(0, 465);
            SupplierInfo.Name = "SupplierInfo";
            SupplierInfo.RowHeadersWidth = 51;
            SupplierInfo.Size = new Size(681, 151);
            SupplierInfo.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 417);
            label3.Name = "label3";
            label3.Size = new Size(173, 35);
            label3.TabIndex = 13;
            label3.Text = "Suppliers Info:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Descr);
            panel1.Controls.Add(CostR);
            panel1.Controls.Add(ProdID);
            panel1.Controls.Add(NumR);
            panel1.Controls.Add(ID);
            panel1.Controls.Add(Return);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(AddDeliver);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SECCompName);
            panel1.Controls.Add(City);
            panel1.Controls.Add(ContactName);
            panel1.Controls.Add(CompanyName);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SupplierInfo);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(DelInfSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SupplierId);
            panel1.Controls.Add(Cost);
            panel1.Controls.Add(NumberOfProducts);
            panel1.Controls.Add(ProductID);
            panel1.Controls.Add(SupplierDelivers);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 738);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(20, 121);
            label8.Name = "label8";
            label8.Size = new Size(165, 35);
            label8.TabIndex = 32;
            label8.Text = "Supplies Info:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(703, 660);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 31;
            label7.Text = "Make a return:";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(1224, 645);
            button2.Name = "button2";
            button2.Size = new Size(108, 61);
            button2.TabIndex = 30;
            button2.Text = "Make Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Descr
            // 
            Descr.Font = new Font("Arial Narrow", 18F);
            Descr.Location = new Point(1037, 622);
            Descr.Multiline = true;
            Descr.Name = "Descr";
            Descr.Size = new Size(181, 99);
            Descr.TabIndex = 29;
            Descr.Enter += Descr_Enter;
            Descr.Leave += Descr_Leave;
            // 
            // CostR
            // 
            CostR.Font = new Font("Arial Narrow", 18F);
            CostR.Location = new Point(932, 679);
            CostR.Name = "CostR";
            CostR.Size = new Size(99, 42);
            CostR.TabIndex = 27;
            CostR.Enter += CostR_Enter;
            CostR.Leave += CostR_Leave;
            // 
            // ProdID
            // 
            ProdID.Font = new Font("Arial Narrow", 18F);
            ProdID.Location = new Point(932, 622);
            ProdID.Name = "ProdID";
            ProdID.Size = new Size(99, 42);
            ProdID.TabIndex = 26;
            ProdID.Enter += ProdID_Enter;
            ProdID.Leave += ProdID_Leave;
            // 
            // NumR
            // 
            NumR.Font = new Font("Arial Narrow", 18F);
            NumR.Location = new Point(838, 679);
            NumR.Name = "NumR";
            NumR.Size = new Size(88, 42);
            NumR.TabIndex = 25;
            NumR.Enter += NumR_Enter;
            NumR.Leave += NumR_Leave;
            // 
            // ID
            // 
            ID.Font = new Font("Arial Narrow", 18F);
            ID.Location = new Point(838, 622);
            ID.Name = "ID";
            ID.Size = new Size(88, 42);
            ID.TabIndex = 24;
            ID.Enter += ID_Enter;
            ID.Leave += ID_Leave;
            // 
            // Return
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            Return.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            Return.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            Return.DefaultCellStyle = dataGridViewCellStyle6;
            Return.Location = new Point(703, 465);
            Return.Name = "Return";
            Return.RowHeadersWidth = 51;
            Return.Size = new Size(641, 151);
            Return.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(709, 417);
            label6.Name = "label6";
            label6.Size = new Size(158, 35);
            label6.TabIndex = 22;
            label6.Text = "Returns Info:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(703, 326);
            label5.Name = "label5";
            label5.Size = new Size(0, 35);
            label5.TabIndex = 21;
            // 
            // AddDeliver
            // 
            AddDeliver.Location = new Point(588, 641);
            AddDeliver.Name = "AddDeliver";
            AddDeliver.Size = new Size(93, 54);
            AddDeliver.TabIndex = 20;
            AddDeliver.Text = "Add";
            AddDeliver.UseVisualStyleBackColor = true;
            AddDeliver.Click += AddDeliver_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 660);
            label4.Name = "label4";
            label4.Size = new Size(206, 35);
            label4.TabIndex = 19;
            label4.Text = "Add New Deliver:";
            // 
            // SECCompName
            // 
            SECCompName.Font = new Font("Arial Narrow", 18F);
            SECCompName.Location = new Point(401, 679);
            SECCompName.Name = "SECCompName";
            SECCompName.Size = new Size(181, 42);
            SECCompName.TabIndex = 18;
            SECCompName.Enter += SECCompName_Enter;
            SECCompName.Leave += SECCompName_Leave;
            // 
            // City
            // 
            City.Font = new Font("Arial Narrow", 18F);
            City.Location = new Point(401, 622);
            City.Name = "City";
            City.Size = new Size(181, 42);
            City.TabIndex = 17;
            City.Enter += City_Enter;
            City.Leave += City_Leave;
            // 
            // ContactName
            // 
            ContactName.Font = new Font("Arial Narrow", 18F);
            ContactName.Location = new Point(214, 679);
            ContactName.Name = "ContactName";
            ContactName.Size = new Size(181, 42);
            ContactName.TabIndex = 16;
            ContactName.Enter += ContactName_Enter;
            ContactName.Leave += ContactName_Leave;
            // 
            // CompanyName
            // 
            CompanyName.Font = new Font("Arial Narrow", 18F);
            CompanyName.Location = new Point(214, 622);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(181, 42);
            CompanyName.TabIndex = 15;
            CompanyName.Enter += CompanyName_Enter;
            CompanyName.Leave += CompanyName_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(687, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 343);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(499, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 341);
            panel6.TabIndex = 11;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 738);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SupplierDelivers).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SupplierInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Return).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Button RefreshButton;
        private Label CloseButton;
        private Label label1;
        private DataGridView SupplierDelivers;
        private TextBox ProductID;
        private TextBox NumberOfProducts;
        private TextBox Cost;
        private TextBox SupplierId;
        private Label label2;
        private Button DelInfSave;
        private Panel panel4;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private DataGridView SupplierInfo;
        private Label label3;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private TextBox SECCompName;
        private TextBox City;
        private TextBox ContactName;
        private new TextBox CompanyName;
        private Button AddDeliver;
        private Label label4;
        private DataGridView Return;
        private Label label6;
        private Label label5;
        private Button button2;
        private TextBox Descr;
        private TextBox CostR;
        private TextBox ProdID;
        private TextBox NumR;
        private TextBox ID;
        private Label label7;
        private Label label8;
    }
}