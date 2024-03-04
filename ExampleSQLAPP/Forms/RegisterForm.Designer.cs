namespace ExampleSQLAPP
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            CloseButton = new Label();
            label1 = new Label();
            buttonRegister = new Button();
            passwordField = new TextBox();
            loginField = new TextBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            adressbox = new TextBox();
            surnamebox = new TextBox();
            namebox = new TextBox();
            label2 = new Label();
            repasswordField = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9026108_user_icon;
            pictureBox1.Location = new Point(278, 400);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(768, 0);
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
            label1.Location = new Point(225, 22);
            label1.Name = "label1";
            label1.Size = new Size(380, 77);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.Silver;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Arial Narrow", 10F, FontStyle.Bold);
            buttonRegister.Location = new Point(364, 611);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(105, 34);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Sign Up";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.Location = new Point(334, 456);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(335, 50);
            passwordField.TabIndex = 4;
            passwordField.UseSystemPasswordChar = true;
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginField
            // 
            loginField.Font = new Font("Arial Narrow", 24F);
            loginField.Location = new Point(334, 400);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(335, 50);
            loginField.TabIndex = 3;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9111101_key_security_icon;
            pictureBox2.Location = new Point(278, 456);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(adressbox);
            panel1.Controls.Add(surnamebox);
            panel1.Controls.Add(namebox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(repasswordField);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial Narrow", 24F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 707);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 515);
            label7.Name = "label7";
            label7.Size = new Size(172, 46);
            label7.TabIndex = 19;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(103, 459);
            label8.Name = "label8";
            label8.Size = new Size(172, 46);
            label8.TabIndex = 18;
            label8.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 403);
            label5.Name = "label5";
            label5.Size = new Size(108, 46);
            label5.TabIndex = 17;
            label5.Text = "Login:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 347);
            label6.Name = "label6";
            label6.Size = new Size(141, 46);
            label6.TabIndex = 16;
            label6.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 290);
            label4.Name = "label4";
            label4.Size = new Size(170, 46);
            label4.TabIndex = 15;
            label4.Text = "Surmame:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 234);
            label3.Name = "label3";
            label3.Size = new Size(116, 46);
            label3.TabIndex = 14;
            label3.Text = "Name:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(278, 344);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(278, 231);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(278, 287);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // adressbox
            // 
            adressbox.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            adressbox.Location = new Point(334, 343);
            adressbox.Name = "adressbox";
            adressbox.Size = new Size(335, 50);
            adressbox.TabIndex = 10;
            adressbox.Enter += adressbox_Enter;
            adressbox.Leave += adressbox_Leave;
            // 
            // surnamebox
            // 
            surnamebox.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnamebox.Location = new Point(334, 287);
            surnamebox.Name = "surnamebox";
            surnamebox.Size = new Size(335, 50);
            surnamebox.TabIndex = 9;
            surnamebox.Enter += surnamebox_Enter;
            surnamebox.Leave += surnamebox_Leave;
            // 
            // namebox
            // 
            namebox.Font = new Font("Arial Narrow", 24F);
            namebox.Location = new Point(334, 231);
            namebox.Multiline = true;
            namebox.Name = "namebox";
            namebox.Size = new Size(335, 50);
            namebox.TabIndex = 8;
            namebox.Enter += namebox_Enter;
            namebox.Leave += namebox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(385, 664);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 7;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // repasswordField
            // 
            repasswordField.Font = new Font("Arial Narrow", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            repasswordField.Location = new Point(334, 512);
            repasswordField.Name = "repasswordField";
            repasswordField.PasswordChar = '*';
            repasswordField.Size = new Size(335, 50);
            repasswordField.TabIndex = 7;
            repasswordField.UseSystemPasswordChar = true;
            repasswordField.Enter += repasswordField_Enter;
            repasswordField.Leave += repasswordField_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9111101_key_security_icon;
            pictureBox3.Location = new Point(278, 512);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 120);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 707);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label CloseButton;
        private Label label1;
        private Button buttonRegister;
        private TextBox passwordField;
        private TextBox loginField;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox repasswordField;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox adressbox;
        private TextBox surnamebox;
        private TextBox namebox;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox6;
        private ColorDialog colorDialog1;
    }
}