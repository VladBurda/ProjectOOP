namespace ExampleSQLAPP.Forms
{
    partial class Employee
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
            panel2 = new Panel();
            BackButton = new Button();
            RefreshButton = new Button();
            CloseButton = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            label3 = new Label();
            Salary = new TextBox();
            LastName = new TextBox();
            ContactNum = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            FirstName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            EmployeeID = new TextBox();
            label2 = new Label();
            EmployeeInfo = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeInfo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(RefreshButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1249, 100);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += Panel2_MouseMove;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(1043, 57);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 15;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RefreshButton.Location = new Point(1143, 57);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 14;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(1217, 0);
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
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(603, 77);
            label1.TabIndex = 0;
            label1.Text = "Employees Manager";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Salary);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(ContactNum);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(FirstName);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(EmployeeID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EmployeeInfo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 680);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(375, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 252);
            panel3.TabIndex = 28;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1074, 524);
            button1.Name = "button1";
            button1.Size = new Size(145, 128);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F);
            label3.Location = new Point(605, 459);
            label3.Name = "label3";
            label3.Size = new Size(239, 35);
            label3.TabIndex = 26;
            label3.Text = "Add New Employee:";
            // 
            // Salary
            // 
            Salary.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Salary.Location = new Point(832, 610);
            Salary.Name = "Salary";
            Salary.Size = new Size(199, 42);
            Salary.TabIndex = 25;
            Salary.Enter += Salary_Enter;
            Salary.Leave += Salary_Leave;
            // 
            // LastName
            // 
            LastName.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastName.Location = new Point(832, 524);
            LastName.Name = "LastName";
            LastName.Size = new Size(199, 42);
            LastName.TabIndex = 24;
            LastName.Enter += LastName_Enter;
            LastName.Leave += LastName_Leave;
            // 
            // ContactNum
            // 
            ContactNum.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ContactNum.Location = new Point(605, 610);
            ContactNum.Name = "ContactNum";
            ContactNum.Size = new Size(193, 42);
            ContactNum.TabIndex = 23;
            ContactNum.Enter += ContactNum_Enter;
            ContactNum.Leave += ContactNum_Leave;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker2.Location = new Point(712, 574);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(209, 30);
            dateTimePicker2.TabIndex = 22;
            // 
            // FirstName
            // 
            FirstName.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FirstName.Location = new Point(605, 524);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(193, 42);
            FirstName.TabIndex = 18;
            FirstName.Enter += FirstName_Enter;
            FirstName.Leave += FirstName_Leave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker1.Location = new Point(27, 536);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 30);
            dateTimePicker1.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 12F);
            button3.Location = new Point(130, 586);
            button3.Name = "button3";
            button3.Size = new Size(94, 69);
            button3.TabIndex = 16;
            button3.Text = "Fire";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmployeeID
            // 
            EmployeeID.Font = new Font("Arial Narrow", 18F);
            EmployeeID.Location = new Point(27, 613);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(76, 42);
            EmployeeID.TabIndex = 15;
            EmployeeID.Enter += EmployeeID_Enter;
            EmployeeID.Leave += EmployeeID_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F);
            label2.Location = new Point(27, 459);
            label2.Name = "label2";
            label2.Size = new Size(64, 35);
            label2.TabIndex = 14;
            label2.Text = "Fire:";
            // 
            // EmployeeInfo
            // 
            EmployeeInfo.Anchor = AnchorStyles.Top;
            EmployeeInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EmployeeInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeeInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeeInfo.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeeInfo.Location = new Point(0, 89);
            EmployeeInfo.Name = "EmployeeInfo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EmployeeInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EmployeeInfo.RowHeadersWidth = 51;
            EmployeeInfo.Size = new Size(1249, 343);
            EmployeeInfo.TabIndex = 13;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private Panel panel1;
        private DataGridView EmployeeInfo;
        private Button RefreshButton;
        private Button button3;
        private TextBox EmployeeID;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox FirstName;
        private TextBox Salary;
        private TextBox LastName;
        private TextBox ContactNum;
        private Button button1;
        private Label label3;
        private Button BackButton;
        private Panel panel3;
    }
}