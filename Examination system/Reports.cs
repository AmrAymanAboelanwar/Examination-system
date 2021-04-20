using DBProject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }



       
        private void Reports_Load(object sender, EventArgs e)
        {
            //load data in comboBox Report1
            GetExamR1();

            //load data in comboBox Report2
             GetInsR2();

            //load data in comboBoxs Report3
             GetStudentsR3();

            //load data in comboBoxs Report4
            GetStudentGradesR4();

            //load data in comboBoxs Report5
            GetDeptsR5();

            //load data in comboBoxs Report56
            GetCrsR6();

        }


        #region report1
        // report 1
        private void GetExamR1()
        {
            // load all exams num in db
            sqlConnection1.Open();
            sqlCommand1.CommandText = "select Ex_id from Exam";
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                ExamNoCbR1.Items.Add(sdr["Ex_id"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();

            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
        private void ExamNoCbR1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportParameter rp = new ReportParameter("exam_id", ExamNoCbR1.SelectedItem.ToString());
            this.reportViewer1.ServerReport.SetParameters(new ReportParameter[] { rp });
            this.reportViewer1.RefreshReport();
        }

        // end report1
        #endregion



        #region report2
        // start report2 
        Dictionary<int, string> dic = new Dictionary<int, string>();
      
         private void GetInsR2()
        {
            dic.Clear();
            InsCbR2.Items.Clear();

            string c = "select Ins_id,Name from Instructor";
            sqlConnection1.Open();
            sqlCommand1.CommandText = c;
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                InsCbR2.Items.Add(sdr["Name"].ToString());
                dic.Add(int.Parse(sdr["ins_id"].ToString()), sdr["Name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
        }

        private void InsCbR2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int insId = 0;
            foreach (var item in dic)
            {
                if (item.Value == InsCbR2.SelectedItem.ToString())
                {
                    insId = item.Key;
                    break;
                }

            }

            ReportParameter rp = new ReportParameter("InsId", insId.ToString());
            this.reportViewer2.ServerReport.SetParameters(new ReportParameter[] { rp });
            this.reportViewer2.RefreshReport();
        }


        // end report2
        #endregion



        #region report3
        Dictionary<int, string> exam = new Dictionary<int, string>();
        private void GetStudentsR3()
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "select distinct concat(s.Fname,' ',s.Lname) as name , Stu_id from Stud_Course_Exam sce inner join Student s on s.St_id=sce.Stu_id where Ex_id is not null";
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                StCbR3.Items.Add(sdr["Stu_id"].ToString() + ".  " + sdr["name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
           
        }

       

        private void StCbR3_SelectedIndexChanged(object sender, EventArgs e)
        {
            exam.Clear();
            // get exams for select student
            GetStudentExamR3();
            
        }

        private void GetStudentExamR3()
        {
            ExamCbR3.Items.Clear();
            sqlConnection1.Open();
            sqlCommand1.CommandText = "select distinct sce.Ex_id , c.Crs_name from Stud_Course_Exam sce inner join Exam_Question eq on sce.Ex_id = eq.Ex_id inner Join Question q on eq.Q_id = q.Q_id inner Join Course c on q.crs_id = c.Crs_id where Stu_id = " + StCbR3.SelectedItem.ToString().Split('.')[0] + " and  sce.Ex_id is not null";
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                exam.Add(int.Parse(sdr["Ex_id"].ToString()), sdr["Crs_name"].ToString());
                ExamCbR3.Items.Add(sdr["Crs_name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
        }

        private void ExamCbR3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int exNo=0;
            foreach (var item in exam)
            {
                if (ExamCbR3.SelectedItem.ToString() == item.Value)
                {
                    exNo = item.Key;
                }
            }
            ReportParameter rp = new ReportParameter("stu_Id", StCbR3.SelectedItem.ToString().Split('.')[0]);
            ReportParameter rp2 = new ReportParameter("exam_Id", exNo.ToString());
            this.reportViewer3.ServerReport.SetParameters(new ReportParameter[] { rp, rp2 });
            this.reportViewer3.RefreshReport();
        }

        // end report3
        #endregion



        #region report4
        // report 4

        private void GetStudentGradesR4()
        {
            string c = "select distinct Stu_id ,concat(s.Fname,' ',s.Lname) as name from Student s inner Join Stud_Course_Exam ss on  s.St_id=ss.Stu_id  where ss.Ex_id is not null ";
            sqlConnection1.Open();
            sqlCommand1.CommandText = c;
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {

                StuCBR4.Items.Add(sdr["Stu_id"].ToString() + ".  " + sdr["name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();

        }


        private void StuCBR4_SelectedIndexChanged(object sender, EventArgs e)
        {

            ReportParameter rp = new ReportParameter("StudentId", StuCBR4.SelectedItem.ToString().Split('.')[0]);
            this.reportViewer4.ServerReport.SetParameters(new ReportParameter[] { rp });
            this.reportViewer4.RefreshReport();
        }





        // end report4
        #endregion



        #region report5
        // report 5

        Dictionary<int, string> dic2 = new Dictionary<int, string>();
        private void GetDeptsR5()
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "select distinct d.Dept_id,d.Dname from Department d inner join Student s on d.Dept_id=s.Dept_id";
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                dic2.Add(int.Parse(sdr["Dept_id"].ToString()), sdr["Dname"].ToString());
                DeptCbR5.Items.Add(sdr["Dname"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
        }
        private void DeptCbR5_SelectedIndexChanged(object sender, EventArgs e)
        {

            int d_Id = 0;
            foreach (var item in dic2)
            {
                if (item.Value == DeptCbR5.SelectedItem.ToString())
                {
                    d_Id = item.Key;
                    break;
                }

            }
            ReportParameter rp = new ReportParameter("deptId", d_Id.ToString());
            this.reportViewer5.ServerReport.SetParameters(new ReportParameter[] { rp });

            this.reportViewer5.RefreshReport();


        }




        // end report5
        #endregion




        #region report6
        // report 6

        Dictionary<int, string> dic3 = new Dictionary<int, string>();
        private void GetCrsR6()
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "select distinct c.Crs_id,c.Crs_name  from Course c  inner join Course_Topic ct  on c.Crs_id=ct.crs_id";
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                dic3.Add(int.Parse(sdr["Crs_id"].ToString()), sdr["Crs_name"].ToString());
                CrsCbR6.Items.Add(sdr["Crs_name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
        }

        private void CrsCbR6_SelectedIndexChanged(object sender, EventArgs e)
        {

            int c_id = 0;
            foreach (var item in dic3)
            {
                if (item.Value == CrsCbR6.SelectedItem.ToString())
                {
                    c_id = item.Key;
                    break;
                }
            }

            ReportParameter rp = new ReportParameter("crs_id", c_id.ToString());
            this.reportViewer6.ServerReport.SetParameters(new ReportParameter[] { rp });

            this.reportViewer6.RefreshReport();

        }







        // end report6
        #endregion


        private void back_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());

        }
    }
}
