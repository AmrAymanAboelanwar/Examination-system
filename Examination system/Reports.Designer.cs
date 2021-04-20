
namespace Examination_system
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExamNoCbR1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InsCbR2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExamCbR3 = new System.Windows.Forms.ComboBox();
            this.StCbR3 = new System.Windows.Forms.ComboBox();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.StuCBR4 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.DeptCbR5 = new System.Windows.Forms.ComboBox();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label7 = new System.Windows.Forms.Label();
            this.CrsCbR6 = new System.Windows.Forms.ComboBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.ExamNoCbR1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1058, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exam";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ExamNoCbR1
            // 
            this.ExamNoCbR1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExamNoCbR1.FormattingEnabled = true;
            this.ExamNoCbR1.Location = new System.Drawing.Point(107, 5);
            this.ExamNoCbR1.Name = "ExamNoCbR1";
            this.ExamNoCbR1.Size = new System.Drawing.Size(154, 21);
            this.ExamNoCbR1.TabIndex = 2;
            this.ExamNoCbR1.SelectedIndexChanged += new System.EventHandler(this.ExamNoCbR1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam Number";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(5, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "/Report/ExamQuestion";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.Size = new System.Drawing.Size(651, 565);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.InsCbR2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1058, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instructor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InsCbR2
            // 
            this.InsCbR2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InsCbR2.FormattingEnabled = true;
            this.InsCbR2.Location = new System.Drawing.Point(132, 3);
            this.InsCbR2.Name = "InsCbR2";
            this.InsCbR2.Size = new System.Drawing.Size(154, 21);
            this.InsCbR2.TabIndex = 4;
            this.InsCbR2.SelectedIndexChanged += new System.EventHandler(this.InsCbR2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Instructor";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(5, 27);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.ServerReport.ReportPath = "/Report/InstructorWithCoursesAndNoStudents";
            this.reportViewer2.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer2.ShowParameterPrompts = false;
            this.reportViewer2.Size = new System.Drawing.Size(651, 573);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.ExamCbR3);
            this.tabPage3.Controls.Add(this.StCbR3);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1058, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Student Exam";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student ";
            // 
            // ExamCbR3
            // 
            this.ExamCbR3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExamCbR3.FormattingEnabled = true;
            this.ExamCbR3.Location = new System.Drawing.Point(340, 6);
            this.ExamCbR3.Name = "ExamCbR3";
            this.ExamCbR3.Size = new System.Drawing.Size(121, 21);
            this.ExamCbR3.TabIndex = 6;
            this.ExamCbR3.SelectedIndexChanged += new System.EventHandler(this.ExamCbR3_SelectedIndexChanged);
            // 
            // StCbR3
            // 
            this.StCbR3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StCbR3.FormattingEnabled = true;
            this.StCbR3.Location = new System.Drawing.Point(90, 5);
            this.StCbR3.Name = "StCbR3";
            this.StCbR3.Size = new System.Drawing.Size(121, 21);
            this.StCbR3.TabIndex = 5;
            this.StCbR3.SelectedIndexChanged += new System.EventHandler(this.StCbR3_SelectedIndexChanged);
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(3, 33);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.ServerReport.ReportPath = "/Report/QuestionsAndStudentAnswers";
            this.reportViewer3.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer3.ShowParameterPrompts = false;
            this.reportViewer3.Size = new System.Drawing.Size(649, 569);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.StuCBR4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1058, 605);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Student Grades";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Location = new System.Drawing.Point(3, 39);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.ServerReport.ReportPath = "/Report/getStudentGrades";
            this.reportViewer4.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer4.ShowParameterPrompts = false;
            this.reportViewer4.Size = new System.Drawing.Size(653, 566);
            this.reportViewer4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "select student";
            // 
            // StuCBR4
            // 
            this.StuCBR4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StuCBR4.FormattingEnabled = true;
            this.StuCBR4.Location = new System.Drawing.Point(117, 15);
            this.StuCBR4.Name = "StuCBR4";
            this.StuCBR4.Size = new System.Drawing.Size(121, 21);
            this.StuCBR4.TabIndex = 3;
            this.StuCBR4.SelectedIndexChanged += new System.EventHandler(this.StuCBR4_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.DeptCbR5);
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1058, 605);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Student Department";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Department";
            // 
            // DeptCbR5
            // 
            this.DeptCbR5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptCbR5.FormattingEnabled = true;
            this.DeptCbR5.Location = new System.Drawing.Point(129, 3);
            this.DeptCbR5.Name = "DeptCbR5";
            this.DeptCbR5.Size = new System.Drawing.Size(162, 21);
            this.DeptCbR5.TabIndex = 3;
            this.DeptCbR5.SelectedIndexChanged += new System.EventHandler(this.DeptCbR5_SelectedIndexChanged);
            // 
            // reportViewer5
            // 
            this.reportViewer5.Location = new System.Drawing.Point(3, 30);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.ServerReport.ReportPath = "/Report/StudentsByDept";
            this.reportViewer5.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer5.ShowParameterPrompts = false;
            this.reportViewer5.Size = new System.Drawing.Size(647, 572);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.CrsCbR6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1058, 605);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Course Topics";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Location = new System.Drawing.Point(3, 39);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.ServerReport.ReportPath = "/Report/TopicsOfCourse";
            this.reportViewer6.ServerReport.ReportServerUrl = new System.Uri("http://localhost:1997/reportserver", System.UriKind.Absolute);
            this.reportViewer6.ShowParameterPrompts = false;
            this.reportViewer6.Size = new System.Drawing.Size(648, 563);
            this.reportViewer6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Course";
            // 
            // CrsCbR6
            // 
            this.CrsCbR6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrsCbR6.FormattingEnabled = true;
            this.CrsCbR6.Location = new System.Drawing.Point(97, 12);
            this.CrsCbR6.Name = "CrsCbR6";
            this.CrsCbR6.Size = new System.Drawing.Size(121, 21);
            this.CrsCbR6.TabIndex = 3;
            this.CrsCbR6.SelectedIndexChanged += new System.EventHandler(this.CrsCbR6_SelectedIndexChanged);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=ExamDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(669, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 651);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox ExamNoCbR1;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ComboBox InsCbR2;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ExamCbR3;
        private System.Windows.Forms.ComboBox StCbR3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StuCBR4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DeptCbR5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CrsCbR6;
        private System.Windows.Forms.Button back;
    }
}