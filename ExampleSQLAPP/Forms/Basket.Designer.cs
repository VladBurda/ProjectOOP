namespace ExampleSQLAPP.Forms
{
    partial class Basket
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
            button1 = new Button();
            Backet = new DataGridView();
            panel2 = new Panel();
            BackButton = new Button();
            CloseButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Backet).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Backet);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 429);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(0, 382);
            button1.Name = "button1";
            button1.Size = new Size(736, 47);
            button1.TabIndex = 19;
            button1.Text = "Confirm Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Backet
            // 
            Backet.AllowUserToAddRows = false;
            Backet.AllowUserToDeleteRows = false;
            Backet.Anchor = AnchorStyles.Top;
            Backet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Backet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Backet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Backet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Backet.DefaultCellStyle = dataGridViewCellStyle2;
            Backet.Location = new Point(0, 89);
            Backet.Name = "Backet";
            Backet.ReadOnly = true;
            Backet.RowHeadersWidth = 51;
            Backet.Size = new Size(736, 287);
            Backet.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 91);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BackButton.Location = new Point(638, 59);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 18;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(704, 0);
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
            label1.Location = new Point(188, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 77);
            label1.TabIndex = 0;
            label1.Text = "Backet";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Basket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 429);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Basket";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Backet";
            Load += Basket_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Backet).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label CloseButton;
        private Label label1;
        private Button BackButton;
        private DataGridView Backet;
        private Button button1;
    }
}