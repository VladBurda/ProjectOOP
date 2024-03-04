namespace ExampleSQLAPP.Forms
{
    partial class Orders
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
            panel1 = new Panel();
            button2 = new Button();
            compord = new TextBox();
            label2 = new Label();
            AddProd = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ord = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            BackButton = new Button();
            CloseButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ord).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(compord);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddProd);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ord);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 553);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F);
            button2.Location = new Point(428, 437);
            button2.Name = "button2";
            button2.Size = new Size(95, 43);
            button2.TabIndex = 29;
            button2.Text = "Complete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // compord
            // 
            compord.Font = new Font("Arial Narrow", 18F);
            compord.Location = new Point(254, 438);
            compord.Name = "compord";
            compord.Size = new Size(168, 42);
            compord.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F);
            label2.Location = new Point(12, 438);
            label2.Name = "label2";
            label2.Size = new Size(198, 35);
            label2.TabIndex = 27;
            label2.Text = "Complete Order:";
            // 
            // AddProd
            // 
            AddProd.Font = new Font("Arial Narrow", 12F);
            AddProd.Location = new Point(428, 507);
            AddProd.Name = "AddProd";
            AddProd.Size = new Size(95, 43);
            AddProd.TabIndex = 26;
            AddProd.Text = "Show";
            AddProd.UseVisualStyleBackColor = true;
            AddProd.Click += AddProd_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 18F);
            textBox1.Location = new Point(254, 508);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 42);
            textBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F);
            label3.Location = new Point(12, 508);
            label3.Name = "label3";
            label3.Size = new Size(236, 35);
            label3.TabIndex = 24;
            label3.Text = "Show Order Details:";
            // 
            // ord
            // 
            ord.AllowUserToAddRows = false;
            ord.AllowUserToDeleteRows = false;
            ord.Anchor = AnchorStyles.Top;
            ord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ord.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ord.DefaultCellStyle = dataGridViewCellStyle2;
            ord.Location = new Point(3, 117);
            ord.Name = "ord";
            ord.ReadOnly = true;
            ord.RowHeadersWidth = 51;
            ord.Size = new Size(967, 287);
            ord.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 120);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(867, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(758, 82);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(941, 0);
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
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(380, 77);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 553);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Orders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ord).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private DataGridView ord;
        private Button button1;
        private Button BackButton;
        private Button AddProd;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private TextBox compord;
        private Label label2;
    }
}