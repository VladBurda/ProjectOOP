namespace ExampleSQLAPP
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            EmployeeF = new Button();
            SupplierF = new Button();
            panel5 = new Panel();
            AddProd = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            panel4 = new Panel();
            button3 = new Button();
            ProductId = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            Cost = new TextBox();
            button2 = new Button();
            label1 = new Label();
            Number = new TextBox();
            ProductName = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            Back = new Button();
            button1 = new Button();
            MainManu = new Label();
            CloseButton = new Label();
            OrderInf = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(OrderInf);
            panel1.Controls.Add(EmployeeF);
            panel1.Controls.Add(SupplierF);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(AddProd);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(ProductId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Cost);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Number);
            panel1.Controls.Add(ProductName);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1195, 606);
            panel1.TabIndex = 2;
            // 
            // EmployeeF
            // 
            EmployeeF.Font = new Font("Arial Narrow", 12F);
            EmployeeF.Location = new Point(934, 463);
            EmployeeF.Name = "EmployeeF";
            EmployeeF.Size = new Size(127, 63);
            EmployeeF.TabIndex = 19;
            EmployeeF.Text = "Employee Information";
            EmployeeF.UseVisualStyleBackColor = true;
            EmployeeF.Click += EmployeeF_Click;
            // 
            // SupplierF
            // 
            SupplierF.Font = new Font("Arial Narrow", 12F);
            SupplierF.Location = new Point(801, 463);
            SupplierF.Name = "SupplierF";
            SupplierF.Size = new Size(127, 63);
            SupplierF.TabIndex = 18;
            SupplierF.Text = "Supplier Information";
            SupplierF.UseVisualStyleBackColor = true;
            SupplierF.Click += SupplierF_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(788, 463);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 72);
            panel5.TabIndex = 9;
            // 
            // AddProd
            // 
            AddProd.Font = new Font("Arial Narrow", 12F);
            AddProd.Location = new Point(670, 482);
            AddProd.Name = "AddProd";
            AddProd.Size = new Size(112, 29);
            AddProd.TabIndex = 17;
            AddProd.Text = "Add Product";
            AddProd.UseVisualStyleBackColor = true;
            AddProd.Click += AddProd_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 18F);
            textBox2.Location = new Point(587, 473);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 42);
            textBox2.TabIndex = 16;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 18F);
            textBox1.Location = new Point(504, 473);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 42);
            textBox1.TabIndex = 15;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Narrow", 12F);
            checkBox2.Location = new Point(314, 491);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(184, 28);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Select to Take Away";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 12F);
            checkBox1.Location = new Point(314, 470);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 28);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Select to Add Product";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F);
            label3.Location = new Point(12, 476);
            label3.Name = "label3";
            label3.Size = new Size(296, 35);
            label3.TabIndex = 12;
            label3.Text = "Manage Existing Product:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(0, 525);
            panel4.Name = "panel4";
            panel4.Size = new Size(1195, 10);
            panel4.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 12F);
            button3.Location = new Point(1079, 560);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProductId
            // 
            ProductId.Font = new Font("Arial Narrow", 18F);
            ProductId.Location = new Point(984, 554);
            ProductId.Name = "ProductId";
            ProductId.Size = new Size(76, 42);
            ProductId.TabIndex = 10;
            ProductId.Enter += ProductId_Enter;
            ProductId.Leave += ProductId_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F);
            label2.Location = new Point(792, 554);
            label2.Name = "label2";
            label2.Size = new Size(186, 35);
            label2.TabIndex = 9;
            label2.Text = "Delete Product:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(764, 534);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 72);
            panel3.TabIndex = 8;
            // 
            // Cost
            // 
            Cost.Font = new Font("Arial Narrow", 18F);
            Cost.Location = new Point(515, 551);
            Cost.Name = "Cost";
            Cost.Size = new Size(77, 42);
            Cost.TabIndex = 7;
            Cost.Enter += Cost_Enter;
            Cost.Leave += Cost_Leave;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F);
            button2.Location = new Point(598, 560);
            button2.Name = "button2";
            button2.Size = new Size(149, 29);
            button2.TabIndex = 6;
            button2.Text = "Add New Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F);
            label1.Location = new Point(18, 554);
            label1.Name = "label1";
            label1.Size = new Size(215, 35);
            label1.TabIndex = 5;
            label1.Text = "Add New Product:";
            // 
            // Number
            // 
            Number.Font = new Font("Arial Narrow", 18F);
            Number.Location = new Point(432, 551);
            Number.Name = "Number";
            Number.Size = new Size(77, 42);
            Number.TabIndex = 4;
            Number.Enter += Number_Enter;
            Number.Leave += Number_Leave;
            // 
            // ProductName
            // 
            ProductName.Font = new Font("Arial Narrow", 18F);
            ProductName.Location = new Point(239, 551);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(187, 42);
            ProductName.TabIndex = 3;
            ProductName.Enter += ProductName_Enter;
            ProductName.Leave += ProductName_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(1195, 344);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(Back);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(MainManu);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1195, 120);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // Back
            // 
            Back.Font = new Font("Arial Narrow", 12F);
            Back.Location = new Point(979, 85);
            Back.Name = "Back";
            Back.Size = new Size(94, 29);
            Back.TabIndex = 4;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F);
            button1.Location = new Point(1079, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainManu
            // 
            MainManu.AutoSize = true;
            MainManu.Location = new Point(446, 41);
            MainManu.Name = "MainManu";
            MainManu.Size = new Size(352, 46);
            MainManu.TabIndex = 2;
            MainManu.Text = "Administrators Window";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(1163, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 22);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "x";
            CloseButton.TextAlign = ContentAlignment.TopCenter;
            CloseButton.Click += CloseButton_Click;
            // 
            // OrderInf
            // 
            OrderInf.Font = new Font("Arial Narrow", 12F);
            OrderInf.Location = new Point(1065, 463);
            OrderInf.Name = "OrderInf";
            OrderInf.Size = new Size(127, 63);
            OrderInf.TabIndex = 20;
            OrderInf.Text = "Orders Information";
            OrderInf.UseVisualStyleBackColor = true;
            OrderInf.Click += OrderInf_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 606);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label MainManu;
        private Label CloseButton;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox Number;
        private new TextBox ProductName;
        private Panel panel3;
        private TextBox Cost;
        private Button button2;
        private Label label1;
        private TextBox ProductId;
        private Label label2;
        private Button button3;
        private Panel panel4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panel5;
        private Button AddProd;
        private Button EmployeeF;
        private Button SupplierF;
        private Button Back;
        private Button OrderInf;
    }
}