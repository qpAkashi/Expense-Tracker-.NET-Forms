namespace ExpenseTrackingApp
{
    partial class Login
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            usernamefield = new TextBox();
            passwordfield = new TextBox();
            showpass = new CheckBox();
            pictureBox3 = new PictureBox();
            closebtn = new Button();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 93, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 762);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 93, 200);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(250, 639);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 123);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 247, 209);
            label1.Location = new Point(413, 90);
            label1.Name = "label1";
            label1.Size = new Size(393, 24);
            label1.TabIndex = 2;
            label1.Text = "Developed by Basfalion Rares Ionut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(363, 147);
            label2.Name = "label2";
            label2.Size = new Size(124, 29);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(367, 240);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.ForeColor = Color.FromArgb(139, 93, 200);
            loginbtn.Location = new Point(493, 335);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(132, 59);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(323, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // usernamefield
            // 
            usernamefield.Location = new Point(493, 151);
            usernamefield.Name = "usernamefield";
            usernamefield.Size = new Size(280, 27);
            usernamefield.TabIndex = 8;
            usernamefield.TextChanged += usernamefield_TextChanged;
            // 
            // passwordfield
            // 
            passwordfield.Location = new Point(493, 244);
            passwordfield.Name = "passwordfield";
            passwordfield.Size = new Size(280, 27);
            passwordfield.TabIndex = 9;
            passwordfield.TextChanged += passwordfield_TextChanged;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.Location = new Point(663, 335);
            showpass.Name = "showpass";
            showpass.Size = new Size(132, 24);
            showpass.TabIndex = 10;
            showpass.Text = "Show Password";
            showpass.UseVisualStyleBackColor = true;
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(449, 350);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.FromArgb(86, 58, 156);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(255, 247, 209);
            closebtn.Location = new Point(962, 12);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(94, 29);
            closebtn.TabIndex = 12;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 116);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(217, 247);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 247, 209);
            label4.Location = new Point(26, 366);
            label4.Name = "label4";
            label4.Size = new Size(183, 49);
            label4.TabIndex = 13;
            label4.Text = "SmartSave";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 247, 209);
            ClientSize = new Size(1068, 762);
            ControlBox = false;
            Controls.Add(closebtn);
            Controls.Add(pictureBox3);
            Controls.Add(showpass);
            Controls.Add(passwordfield);
            Controls.Add(usernamefield);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(loginbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginbtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox usernamefield;
        private TextBox passwordfield;
        private CheckBox showpass;
        private PictureBox pictureBox3;
        private Button closebtn;

        // Event handler for username field text change
        private void usernamefield_TextChanged(object sender, EventArgs e)
        {
            // Handle username text change event
        }

        // Event handler for close button click
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void loginbtn_Click(Object sender, EventArgs e)
        {
        }

        private Label label4;
        private PictureBox pictureBox4;
    }
}
