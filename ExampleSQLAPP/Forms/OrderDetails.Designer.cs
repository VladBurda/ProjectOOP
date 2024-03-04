namespace ExampleSQLAPP.Forms
{
    partial class OrderDetails
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
            panel1 = new Panel();
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
            panel1.Controls.Add(ord);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 409);
            panel1.TabIndex = 2;
            // 
            // ord
            // 
            ord.AllowUserToAddRows = false;
            ord.AllowUserToDeleteRows = false;
            ord.Anchor = AnchorStyles.Top;
            ord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ord.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ord.Location = new Point(0, 117);
            ord.Name = "ord";
            ord.ReadOnly = true;
            ord.RowHeadersWidth = 51;
            ord.Size = new Size(973, 287);
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
            panel2.Size = new Size(975, 120);
            panel2.TabIndex = 0;
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
            label1.Location = new Point(307, 20);
            label1.Name = "label1";
            label1.Size = new Size(380, 77);
            label1.TabIndex = 0;
            label1.Text = "Order Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 409);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDetails";
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ord).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView ord;
        private Panel panel2;
        private Button button1;
        private Button BackButton;
        private Label CloseButton;
        private Label label1;
    }
}