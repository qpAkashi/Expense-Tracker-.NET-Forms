namespace ExpenseTrackingApp
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            fileSystemWatcher1 = new FileSystemWatcher();
            closebtnmain = new Button();
            label1 = new Label();
            label2 = new Label();
            produsfield = new TextBox();
            pretfield = new TextBox();
            datagrid = new DataGridView();
            cheltuitlabel = new Label();
            label4 = new Label();
            bugetfield = new TextBox();
            adaugaprodbtn = new Button();
            stergeprodbtn = new Button();
            adaugabugetbtn = new Button();
            label5 = new Label();
            cantitatefield = new TextBox();
            bugetlabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            stergebugetbtn = new Button();
            stergebugetramas = new Button();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            categoriefield = new TextBox();
            nrchel = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // closebtnmain
            // 
            closebtnmain.BackColor = Color.FromArgb(255, 247, 209);
            closebtnmain.FlatStyle = FlatStyle.Flat;
            closebtnmain.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closebtnmain.ForeColor = Color.FromArgb(86, 58, 156);
            closebtnmain.Location = new Point(1814, 12);
            closebtnmain.Name = "closebtnmain";
            closebtnmain.Size = new Size(94, 29);
            closebtnmain.TabIndex = 1;
            closebtnmain.Text = "X";
            closebtnmain.UseVisualStyleBackColor = false;
            closebtnmain.Click += closebtnmain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 168);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 2;
            label1.Text = "Name of the item : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 280);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Price of the item : ";
            // 
            // produsfield
            // 
            produsfield.Location = new Point(297, 168);
            produsfield.Name = "produsfield";
            produsfield.Size = new Size(214, 27);
            produsfield.TabIndex = 4;
            // 
            // pretfield
            // 
            pretfield.Location = new Point(297, 277);
            pretfield.Name = "pretfield";
            pretfield.Size = new Size(137, 27);
            pretfield.TabIndex = 5;
            // 
            // datagrid
            // 
            datagrid.AllowUserToDeleteRows = false;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Location = new Point(679, 292);
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersWidth = 51;
            datagrid.Size = new Size(544, 479);
            datagrid.TabIndex = 6;
            // 
            // cheltuitlabel
            // 
            cheltuitlabel.AutoSize = true;
            cheltuitlabel.Location = new Point(1241, 813);
            cheltuitlabel.Name = "cheltuitlabel";
            cheltuitlabel.Size = new Size(0, 20);
            cheltuitlabel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 328);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Budget:";
            label4.Click += label4_Click;
            // 
            // bugetfield
            // 
            bugetfield.Location = new Point(297, 325);
            bugetfield.Name = "bugetfield";
            bugetfield.Size = new Size(137, 27);
            bugetfield.TabIndex = 9;
            // 
            // adaugaprodbtn
            // 
            adaugaprodbtn.Location = new Point(44, 455);
            adaugaprodbtn.Name = "adaugaprodbtn";
            adaugaprodbtn.Size = new Size(169, 142);
            adaugaprodbtn.TabIndex = 11;
            adaugaprodbtn.Text = "Add Product";
            adaugaprodbtn.UseVisualStyleBackColor = true;
            adaugaprodbtn.Click += adaugaprodbtn_Click;
            // 
            // stergeprodbtn
            // 
            stergeprodbtn.Location = new Point(219, 455);
            stergeprodbtn.Name = "stergeprodbtn";
            stergeprodbtn.Size = new Size(169, 142);
            stergeprodbtn.TabIndex = 12;
            stergeprodbtn.Text = "Delete Product";
            stergeprodbtn.UseVisualStyleBackColor = true;
            stergeprodbtn.Click += stergeprodbtn_Click;
            // 
            // adaugabugetbtn
            // 
            adaugabugetbtn.Location = new Point(394, 455);
            adaugabugetbtn.Name = "adaugabugetbtn";
            adaugabugetbtn.Size = new Size(169, 142);
            adaugabugetbtn.TabIndex = 13;
            adaugabugetbtn.Text = "Add Budget";
            adaugabugetbtn.UseVisualStyleBackColor = true;
            adaugabugetbtn.Click += adaugabugetbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 221);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 14;
            label5.Text = "Quantity : ";
            // 
            // cantitatefield
            // 
            cantitatefield.Location = new Point(298, 218);
            cantitatefield.Name = "cantitatefield";
            cantitatefield.Size = new Size(214, 27);
            cantitatefield.TabIndex = 15;
            // 
            // bugetlabel
            // 
            bugetlabel.AutoSize = true;
            bugetlabel.Location = new Point(1241, 870);
            bugetlabel.Name = "bugetlabel";
            bugetlabel.Size = new Size(99, 20);
            bugetlabel.TabIndex = 16;
            bugetlabel.Text = "Spent Money:";
            bugetlabel.Click += bugetlabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(127, 280);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(192, 325);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1204, 806);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1204, 863);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // stergebugetbtn
            // 
            stergebugetbtn.Location = new Point(44, 629);
            stergebugetbtn.Name = "stergebugetbtn";
            stergebugetbtn.Size = new Size(169, 142);
            stergebugetbtn.TabIndex = 23;
            stergebugetbtn.Text = "Delete Budget";
            stergebugetbtn.UseVisualStyleBackColor = true;
            stergebugetbtn.Click += stergebugetbtn_Click;
            // 
            // stergebugetramas
            // 
            stergebugetramas.Location = new Point(219, 629);
            stergebugetramas.Name = "stergebugetramas";
            stergebugetramas.Size = new Size(169, 142);
            stergebugetramas.TabIndex = 25;
            stergebugetramas.Text = "Delete Remaining Budget";
            stergebugetramas.UseVisualStyleBackColor = true;
            stergebugetramas.Click += stergecategoriabtn_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(219, 378);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 385);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 27;
            label7.Text = "Category : ";
            // 
            // categoriefield
            // 
            categoriefield.Location = new Point(339, 382);
            categoriefield.Name = "categoriefield";
            categoriefield.Size = new Size(137, 27);
            categoriefield.TabIndex = 28;
            // 
            // nrchel
            // 
            nrchel.AutoSize = true;
            nrchel.Location = new Point(1347, 813);
            nrchel.Name = "nrchel";
            nrchel.Size = new Size(0, 20);
            nrchel.TabIndex = 29;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 58, 156);
            ClientSize = new Size(1920, 1080);
            Controls.Add(nrchel);
            Controls.Add(categoriefield);
            Controls.Add(label7);
            Controls.Add(pictureBox7);
            Controls.Add(stergebugetramas);
            Controls.Add(stergebugetbtn);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bugetlabel);
            Controls.Add(cantitatefield);
            Controls.Add(label5);
            Controls.Add(adaugabugetbtn);
            Controls.Add(stergeprodbtn);
            Controls.Add(adaugaprodbtn);
            Controls.Add(bugetfield);
            Controls.Add(label4);
            Controls.Add(cheltuitlabel);
            Controls.Add(datagrid);
            Controls.Add(pretfield);
            Controls.Add(produsfield);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closebtnmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "Form2";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button closebtnmain;
        private Label label2;
        private Label label1;
        private TextBox pretfield;
        private TextBox produsfield;
        private Button stergeprodbtn;
        private Button adaugaprodbtn;
        private TextBox bugetfield;
        private Label label4;
        private Label cheltuitlabel;
        private DataGridView datagrid;
        private TextBox cantitatefield;
        private Label label5;
        private Button adaugabugetbtn;
        private Label bugetlabel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TextBox categoriefield;
        private Label label7;
        private PictureBox pictureBox7;
        private Button stergebugetramas;
        private Button stergebugetbtn;
        private Label nrchel;
    }
}