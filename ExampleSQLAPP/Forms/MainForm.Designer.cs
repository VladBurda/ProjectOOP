namespace ExampleSQLAPP
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            BackButton = new Button();
            RefreshButton = new Button();
            MainManu = new Label();
            CloseButton = new Label();
            panel1 = new Panel();
            AddProd = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            ProductsC = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsC).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(MainManu);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1424, 120);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(1218, 80);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 16;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RefreshButton.Location = new Point(1318, 80);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 15;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainManu
            // 
            MainManu.AutoSize = true;
            MainManu.Location = new Point(639, 38);
            MainManu.Name = "MainManu";
            MainManu.Size = new Size(180, 46);
            MainManu.TabIndex = 2;
            MainManu.Text = "Main Menu";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(1392, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(32, 22);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "x";
            CloseButton.TextAlign = ContentAlignment.TopCenter;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(AddProd);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ProductsC);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 750);
            panel1.TabIndex = 1;
            // 
            // AddProd
            // 
            AddProd.Font = new Font("Arial Narrow", 12F);
            AddProd.Location = new Point(667, 695);
            AddProd.Name = "AddProd";
            AddProd.Size = new Size(137, 43);
            AddProd.TabIndex = 23;
            AddProd.Text = "Add To Basket";
            AddProd.UseVisualStyleBackColor = true;
            AddProd.Click += AddProd_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 18F);
            textBox2.Location = new Point(584, 695);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 42);
            textBox2.TabIndex = 22;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 18F);
            textBox1.Location = new Point(501, 695);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 42);
            textBox1.TabIndex = 21;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Narrow", 12F);
            checkBox2.Location = new Point(304, 710);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(184, 28);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Select to Take Away";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 12F);
            checkBox1.Location = new Point(304, 689);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 28);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Select to Add Product";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F);
            label3.Location = new Point(22, 695);
            label3.Name = "label3";
            label3.Size = new Size(276, 35);
            label3.TabIndex = 18;
            label3.Text = "Add Product To Basket:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1218, 426);
            button1.Name = "button1";
            button1.Size = new Size(194, 78);
            button1.TabIndex = 17;
            button1.Text = "Basket";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductsC
            // 
            ProductsC.AllowUserToAddRows = false;
            ProductsC.AllowUserToDeleteRows = false;
            ProductsC.Anchor = AnchorStyles.Top;
            ProductsC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProductsC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ProductsC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ProductsC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsC.Location = new Point(0, 115);
            ProductsC.Name = "ProductsC";
            ProductsC.ReadOnly = true;
            ProductsC.RowHeadersWidth = 51;
            ProductsC.Size = new Size(1424, 294);
            ProductsC.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label MainManu;
        private Label CloseButton;
        private Panel panel1;
        private DataGridView ProductsC;
        private Button RefreshButton;
        private Button BackButton;
        private Button button1;
        private Button AddProd;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
    }
}