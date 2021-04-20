
namespace DBProject
{
    partial class MngStd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngStd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExamDB = new System.Data.SqlClient.SqlConnection();
            this.std = new System.Data.SqlClient.SqlCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cnl = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bod = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.dept = new System.Windows.Forms.ComboBox();
            this.ads = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeptName = new System.Windows.Forms.ComboBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stdID = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.enrolledCrs = new System.Windows.Forms.ListBox();
            this.enrollbtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.avCrs = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nameStd = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 631);
            this.dataGridView1.TabIndex = 2;
            // 
            // ExamDB
            // 
            this.ExamDB.ConnectionString = "Data Source=.;Initial Catalog=ExamDB;Integrated Security=True";
            this.ExamDB.FireInfoMessageEventOnUserErrors = false;
            // 
            // std
            // 
            this.std.CommandText = "getDepartment";
            this.std.CommandType = System.Data.CommandType.StoredProcedure;
            this.std.Connection = this.ExamDB;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1421, 784);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.cnl);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1413, 755);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cnl
            // 
            this.cnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnl.ForeColor = System.Drawing.Color.Navy;
            this.cnl.Location = new System.Drawing.Point(896, 607);
            this.cnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(93, 42);
            this.cnl.TabIndex = 29;
            this.cnl.Text = "Back";
            this.cnl.UseVisualStyleBackColor = false;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.bod);
            this.tabPage2.Controls.Add(this.save);
            this.tabPage2.Controls.Add(this.dept);
            this.tabPage2.Controls.Add(this.ads);
            this.tabPage2.Controls.Add(this.lname);
            this.tabPage2.Controls.Add(this.fname);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1413, 755);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1068, 222);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Courses";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(468, 631);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bod
            // 
            this.bod.Location = new System.Drawing.Point(520, 454);
            this.bod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bod.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.bod.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.bod.Name = "bod";
            this.bod.Size = new System.Drawing.Size(200, 22);
            this.bod.TabIndex = 29;
            this.bod.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.ForeColor = System.Drawing.Color.Navy;
            this.save.Location = new System.Drawing.Point(673, 631);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(91, 42);
            this.save.TabIndex = 27;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dept
            // 
            this.dept.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(527, 544);
            this.dept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(193, 24);
            this.dept.TabIndex = 26;
            this.dept.SelectedIndexChanged += new System.EventHandler(this.dept_SelectedIndexChanged_1);
            // 
            // ads
            // 
            this.ads.Location = new System.Drawing.Point(520, 354);
            this.ads.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ads.Name = "ads";
            this.ads.Size = new System.Drawing.Size(193, 22);
            this.ads.TabIndex = 25;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(520, 274);
            this.lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(193, 22);
            this.lname.TabIndex = 24;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(520, 187);
            this.fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(193, 22);
            this.fname.TabIndex = 23;
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(608, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "New Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(365, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(365, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(365, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(365, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(365, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Frist Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btnnew);
            this.tabPage3.Controls.Add(this.dob);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lastname);
            this.tabPage3.Controls.Add(this.address);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.DeptName);
            this.tabPage3.Controls.Add(this.stdName);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.stdID);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1413, 755);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Find Student";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(521, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 40;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(584, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 48);
            this.label13.TabIndex = 39;
            this.label13.Text = "Find Student";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnew.ForeColor = System.Drawing.Color.Navy;
            this.btnnew.Location = new System.Drawing.Point(747, 594);
            this.btnnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(117, 44);
            this.btnnew.TabIndex = 38;
            this.btnnew.Text = "Edit Student";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(681, 495);
            this.dob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dob.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dob.MinDate = new System.DateTime(1990, 1, 30, 0, 0, 0, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(223, 22);
            this.dob.TabIndex = 37;
            this.dob.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Last Name";
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(681, 366);
            this.lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(223, 22);
            this.lastname.TabIndex = 35;
            this.lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(681, 436);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(223, 22);
            this.address.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(508, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Birth Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(509, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Frist Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Dept Name";
            // 
            // DeptName
            // 
            this.DeptName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptName.FormattingEnabled = true;
            this.DeptName.Location = new System.Drawing.Point(681, 133);
            this.DeptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(223, 24);
            this.DeptName.TabIndex = 29;
            this.DeptName.SelectedIndexChanged += new System.EventHandler(this.DeptName_SelectedIndexChanged);
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(681, 281);
            this.stdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(223, 22);
            this.stdName.TabIndex = 28;
            this.stdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(508, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Std ID";
            // 
            // stdID
            // 
            this.stdID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stdID.FormattingEnabled = true;
            this.stdID.Location = new System.Drawing.Point(681, 199);
            this.stdID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(223, 24);
            this.stdID.TabIndex = 26;
            this.stdID.SelectedIndexChanged += new System.EventHandler(this.stdID_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.enrolledCrs);
            this.tabPage4.Controls.Add(this.enrollbtn);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.avCrs);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.nameStd);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1413, 755);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Course Enrollment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(133, 546);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 42);
            this.button3.TabIndex = 30;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enrolledCrs
            // 
            this.enrolledCrs.FormattingEnabled = true;
            this.enrolledCrs.ItemHeight = 16;
            this.enrolledCrs.Location = new System.Drawing.Point(307, 286);
            this.enrolledCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enrolledCrs.Name = "enrolledCrs";
            this.enrolledCrs.Size = new System.Drawing.Size(215, 164);
            this.enrolledCrs.TabIndex = 7;
            // 
            // enrollbtn
            // 
            this.enrollbtn.Location = new System.Drawing.Point(331, 542);
            this.enrollbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enrollbtn.Name = "enrollbtn";
            this.enrollbtn.Size = new System.Drawing.Size(136, 54);
            this.enrollbtn.TabIndex = 6;
            this.enrollbtn.Text = "Enroll";
            this.enrollbtn.UseVisualStyleBackColor = true;
            this.enrollbtn.Click += new System.EventHandler(this.enrollbtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(109, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "Added Courses";
            // 
            // avCrs
            // 
            this.avCrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.avCrs.FormattingEnabled = true;
            this.avCrs.Location = new System.Drawing.Point(305, 223);
            this.avCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avCrs.Name = "avCrs";
            this.avCrs.Size = new System.Drawing.Size(217, 24);
            this.avCrs.TabIndex = 3;
            this.avCrs.SelectedIndexChanged += new System.EventHandler(this.avCrs_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(109, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Available Courses";
            // 
            // nameStd
            // 
            this.nameStd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameStd.FormattingEnabled = true;
            this.nameStd.Location = new System.Drawing.Point(307, 148);
            this.nameStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameStd.Name = "nameStd";
            this.nameStd.Size = new System.Drawing.Size(215, 24);
            this.nameStd.TabIndex = 1;
            this.nameStd.SelectedIndexChanged += new System.EventHandler(this.nameStd_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(109, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Student Name";
            // 
            // MngStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1445, 801);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MngStd";
            this.Text = "MngStd";
            this.Load += new System.EventHandler(this.MngStd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection ExamDB;
        private System.Data.SqlClient.SqlCommand std;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker bod;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.TextBox ads;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DeptName;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox stdID;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox nameStd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox avCrs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button enrollbtn;
        private System.Windows.Forms.ListBox enrolledCrs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
    }
}