
namespace DBProject
{
    partial class MngCrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngCrs));
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExamDB = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cnl = new System.Windows.Forms.Button();
            this.insCrs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.dur = new System.Windows.Forms.TextBox();
            this.crsName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CRS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qubox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.ComboBox();
            this.d = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.addMCQue = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.degree = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.namrCRS = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.queBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.anserBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addTFQuestion = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.topName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.crs_Name = new System.Windows.Forms.ComboBox();
            this.addTopic = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.std_crs = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(659, 658);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 230);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 369);
            this.dataGridView1.TabIndex = 8;
            // 
            // ExamDB
            // 
            this.ExamDB.ConnectionString = "Data Source=.;Initial Catalog=ExamDB;Integrated Security=True";
            this.ExamDB.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.ExamDB;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1432, 790);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1424, 761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cours Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Courses Data";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.cnl);
            this.tabPage2.Controls.Add(this.insCrs);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.save);
            this.tabPage2.Controls.Add(this.dur);
            this.tabPage2.Controls.Add(this.crsName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1424, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Course";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cnl
            // 
            this.cnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cnl.ForeColor = System.Drawing.Color.Navy;
            this.cnl.Location = new System.Drawing.Point(597, 539);
            this.cnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnl.Name = "cnl";
            this.cnl.Size = new System.Drawing.Size(93, 42);
            this.cnl.TabIndex = 38;
            this.cnl.Text = "Back";
            this.cnl.UseVisualStyleBackColor = false;
            this.cnl.Click += new System.EventHandler(this.cnl_Click);
            // 
            // insCrs
            // 
            this.insCrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insCrs.FormattingEnabled = true;
            this.insCrs.Location = new System.Drawing.Point(709, 439);
            this.insCrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insCrs.Name = "insCrs";
            this.insCrs.Size = new System.Drawing.Size(193, 24);
            this.insCrs.TabIndex = 37;
            this.insCrs.SelectedIndexChanged += new System.EventHandler(this.insCrs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(523, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Course Instructor";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.OldLace;
            this.save.ForeColor = System.Drawing.Color.Navy;
            this.save.Location = new System.Drawing.Point(751, 538);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(99, 43);
            this.save.TabIndex = 35;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dur
            // 
            this.dur.BackColor = System.Drawing.Color.OldLace;
            this.dur.Location = new System.Drawing.Point(709, 368);
            this.dur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(193, 22);
            this.dur.TabIndex = 34;
            this.dur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dur_KeyPress);
            // 
            // crsName
            // 
            this.crsName.BackColor = System.Drawing.Color.OldLace;
            this.crsName.Location = new System.Drawing.Point(709, 282);
            this.crsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(193, 22);
            this.crsName.TabIndex = 33;
            this.crsName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.crsName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(565, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 58);
            this.label6.TabIndex = 32;
            this.label6.Text = "New Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(523, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Course Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(523, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Course Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.deg);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.CRS);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.qubox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.answer);
            this.tabPage3.Controls.Add(this.d);
            this.tabPage3.Controls.Add(this.c);
            this.tabPage3.Controls.Add(this.b);
            this.tabPage3.Controls.Add(this.a);
            this.tabPage3.Controls.Add(this.l4);
            this.tabPage3.Controls.Add(this.l3);
            this.tabPage3.Controls.Add(this.l2);
            this.tabPage3.Controls.Add(this.l1);
            this.tabPage3.Controls.Add(this.addMCQue);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1424, 761);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MC Questions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(513, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 53;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deg
            // 
            this.deg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deg.FormattingEnabled = true;
            this.deg.Items.AddRange(new object[] {
            "1",
            "2"});
            this.deg.Location = new System.Drawing.Point(428, 400);
            this.deg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(281, 24);
            this.deg.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(285, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Degree";
            // 
            // CRS
            // 
            this.CRS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CRS.FormattingEnabled = true;
            this.CRS.Location = new System.Drawing.Point(428, 234);
            this.CRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRS.Name = "CRS";
            this.CRS.Size = new System.Drawing.Size(281, 24);
            this.CRS.TabIndex = 50;
            this.CRS.SelectedIndexChanged += new System.EventHandler(this.CRS_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(285, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "Course";
            // 
            // qubox
            // 
            this.qubox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.qubox.Location = new System.Drawing.Point(428, 325);
            this.qubox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qubox.Name = "qubox";
            this.qubox.Size = new System.Drawing.Size(281, 22);
            this.qubox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OldLace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(285, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 29);
            this.label8.TabIndex = 47;
            this.label8.Text = "Question";
            // 
            // answer
            // 
            this.answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.answer.FormattingEnabled = true;
            this.answer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.answer.Location = new System.Drawing.Point(859, 235);
            this.answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(281, 24);
            this.answer.TabIndex = 46;
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.AntiqueWhite;
            this.d.Location = new System.Drawing.Point(859, 430);
            this.d.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(281, 22);
            this.d.TabIndex = 45;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.AntiqueWhite;
            this.c.Location = new System.Drawing.Point(859, 374);
            this.c.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(281, 22);
            this.c.TabIndex = 44;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.AntiqueWhite;
            this.b.Location = new System.Drawing.Point(859, 327);
            this.b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(281, 22);
            this.b.TabIndex = 43;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.AntiqueWhite;
            this.a.Location = new System.Drawing.Point(859, 282);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(281, 22);
            this.a.TabIndex = 42;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l4.Location = new System.Drawing.Point(820, 430);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(16, 17);
            this.l4.TabIndex = 41;
            this.l4.Text = "4";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l3.Location = new System.Drawing.Point(820, 374);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(16, 17);
            this.l3.TabIndex = 40;
            this.l3.Text = "3";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l2.Location = new System.Drawing.Point(820, 327);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(16, 17);
            this.l2.TabIndex = 39;
            this.l2.Text = "2";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.l1.Location = new System.Drawing.Point(820, 282);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(16, 17);
            this.l1.TabIndex = 38;
            this.l1.Text = "1";
            // 
            // addMCQue
            // 
            this.addMCQue.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addMCQue.ForeColor = System.Drawing.Color.Navy;
            this.addMCQue.Location = new System.Drawing.Point(719, 537);
            this.addMCQue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMCQue.Name = "addMCQue";
            this.addMCQue.Size = new System.Drawing.Size(117, 44);
            this.addMCQue.TabIndex = 37;
            this.addMCQue.Text = "Save";
            this.addMCQue.UseVisualStyleBackColor = false;
            this.addMCQue.Click += new System.EventHandler(this.addMCQue_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(503, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(514, 58);
            this.label9.TabIndex = 36;
            this.label9.Text = "Multi Choice Question";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.OldLace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(753, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = " Answer";
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.degree);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.namrCRS);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.queBox);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.anserBox);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.addTFQuestion);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1424, 761);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "T.F Questions";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(593, 526);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 42);
            this.button2.TabIndex = 59;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.NavajoWhite;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(799, 298);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 25);
            this.label19.TabIndex = 58;
            this.label19.Text = " Answer";
            // 
            // degree
            // 
            this.degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degree.FormattingEnabled = true;
            this.degree.Items.AddRange(new object[] {
            "1",
            "2"});
            this.degree.Location = new System.Drawing.Point(411, 410);
            this.degree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(255, 24);
            this.degree.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.NavajoWhite;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(277, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 29);
            this.label11.TabIndex = 56;
            this.label11.Text = "Degree";
            // 
            // namrCRS
            // 
            this.namrCRS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.namrCRS.FormattingEnabled = true;
            this.namrCRS.Location = new System.Drawing.Point(411, 299);
            this.namrCRS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namrCRS.Name = "namrCRS";
            this.namrCRS.Size = new System.Drawing.Size(255, 24);
            this.namrCRS.TabIndex = 55;
            this.namrCRS.SelectedIndexChanged += new System.EventHandler(this.namrCRS_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(279, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 29);
            this.label12.TabIndex = 54;
            this.label12.Text = "Course";
            // 
            // queBox
            // 
            this.queBox.BackColor = System.Drawing.Color.NavajoWhite;
            this.queBox.Location = new System.Drawing.Point(411, 353);
            this.queBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queBox.Name = "queBox";
            this.queBox.Size = new System.Drawing.Size(255, 22);
            this.queBox.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.NavajoWhite;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(277, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 29);
            this.label13.TabIndex = 52;
            this.label13.Text = "Question";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.NavajoWhite;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(952, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "False";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.NavajoWhite;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(952, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "True";
            // 
            // anserBox
            // 
            this.anserBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anserBox.FormattingEnabled = true;
            this.anserBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.anserBox.Location = new System.Drawing.Point(908, 299);
            this.anserBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anserBox.Name = "anserBox";
            this.anserBox.Size = new System.Drawing.Size(239, 24);
            this.anserBox.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.NavajoWhite;
            this.label16.Location = new System.Drawing.Point(905, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 48;
            this.label16.Text = "2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.NavajoWhite;
            this.label17.Location = new System.Drawing.Point(905, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 47;
            this.label17.Text = "1";
            // 
            // addTFQuestion
            // 
            this.addTFQuestion.BackColor = System.Drawing.Color.NavajoWhite;
            this.addTFQuestion.ForeColor = System.Drawing.Color.Navy;
            this.addTFQuestion.Location = new System.Drawing.Point(781, 523);
            this.addTFQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTFQuestion.Name = "addTFQuestion";
            this.addTFQuestion.Size = new System.Drawing.Size(117, 44);
            this.addTFQuestion.TabIndex = 46;
            this.addTFQuestion.Text = "Save";
            this.addTFQuestion.UseVisualStyleBackColor = false;
            this.addTFQuestion.Click += new System.EventHandler(this.addTFQuestion_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.NavajoWhite;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(635, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(323, 58);
            this.label18.TabIndex = 45;
            this.label18.Text = "True or False";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.topName);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.crs_Name);
            this.tabPage4.Controls.Add(this.addTopic);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1424, 761);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Course Topic";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(107, 524);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 42);
            this.button4.TabIndex = 34;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(859, 402);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "Topic Name";
            // 
            // topName
            // 
            this.topName.Location = new System.Drawing.Point(968, 398);
            this.topName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topName.Name = "topName";
            this.topName.Size = new System.Drawing.Size(175, 22);
            this.topName.TabIndex = 32;
            this.topName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.crsName_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(859, 318);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Course Name";
            // 
            // crs_Name
            // 
            this.crs_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crs_Name.FormattingEnabled = true;
            this.crs_Name.Location = new System.Drawing.Point(972, 318);
            this.crs_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crs_Name.Name = "crs_Name";
            this.crs_Name.Size = new System.Drawing.Size(171, 24);
            this.crs_Name.TabIndex = 30;
            this.crs_Name.SelectedIndexChanged += new System.EventHandler(this.crs_Name_SelectedIndexChanged);
            // 
            // addTopic
            // 
            this.addTopic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTopic.ForeColor = System.Drawing.Color.Navy;
            this.addTopic.Location = new System.Drawing.Point(972, 498);
            this.addTopic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTopic.Name = "addTopic";
            this.addTopic.Size = new System.Drawing.Size(72, 38);
            this.addTopic.TabIndex = 29;
            this.addTopic.Text = "Save";
            this.addTopic.UseVisualStyleBackColor = false;
            this.addTopic.Click += new System.EventHandler(this.addTopic_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(283, 241);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(511, 338);
            this.dataGridView2.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.OldLace;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Location = new System.Drawing.Point(539, 182);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(194, 29);
            this.label22.TabIndex = 26;
            this.label22.Text = "Courses\'s Topic";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.std_crs);
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1424, 761);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Student\'s Course";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(263, 575);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 42);
            this.button5.TabIndex = 30;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // std_crs
            // 
            this.std_crs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.std_crs.FormattingEnabled = true;
            this.std_crs.Location = new System.Drawing.Point(553, 242);
            this.std_crs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.std_crs.Name = "std_crs";
            this.std_crs.Size = new System.Drawing.Size(153, 24);
            this.std_crs.TabIndex = 23;
            this.std_crs.SelectedIndexChanged += new System.EventHandler(this.std_crs_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(440, 274);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(440, 302);
            this.dataGridView3.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.OldLace;
            this.label23.ForeColor = System.Drawing.Color.Navy;
            this.label23.Location = new System.Drawing.Point(437, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 17);
            this.label23.TabIndex = 21;
            this.label23.Text = "Course Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.OldLace;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Navy;
            this.label24.Location = new System.Drawing.Point(548, 185);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(188, 29);
            this.label24.TabIndex = 20;
            this.label24.Text = "Course Student";
            // 
            // MngCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 801);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MngCrs";
            this.Text = "MngCrs";
            this.Load += new System.EventHandler(this.MngCrs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Button crsStd;
        private System.Data.SqlClient.SqlConnection ExamDB;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox insCrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox dur;
        private System.Windows.Forms.TextBox crsName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox deg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CRS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qubox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox answer;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button addMCQue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox degree;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox namrCRS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox queBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox anserBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addTFQuestion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox topName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox crs_Name;
        private System.Windows.Forms.Button addTopic;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox std_crs;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button cnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}