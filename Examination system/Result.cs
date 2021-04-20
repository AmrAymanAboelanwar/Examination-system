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
    public partial class Result : Form
    {
        int grade;
        public Result(int stuId , int exam_No , int crs_id)
        {
            InitializeComponent();

            sqlConnection1.Open();
            sqlCommand1.Parameters.AddWithValue("@stu_id", stuId);
            sqlCommand1.Parameters.AddWithValue("@exam_id", exam_No);
            int affectiveRows = sqlCommand1.ExecuteNonQuery();
            
            if (affectiveRows > 0)
            {
                SqlCommand cmd = new SqlCommand("getStudentGradeInCourse", sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stdId",stuId );
                cmd.Parameters.AddWithValue("@crsId", crs_id);
                SqlDataReader sdr = cmd.ExecuteReader();
                try{


                    while (sdr.Read())
                    {
                        grade = int.Parse(sdr["grade"].ToString());
                    }
                    if (grade > 50)
                    {
                        res.Text = grade.ToString()+"%";
                    }
                    else
                    {
                        res.Text = grade.ToString()+"%";
                        res.ForeColor = Color.Red;
                    }
                   

                }
                catch
                {
                    // error 
                }

                sqlConnection1.Close();

            }
        }
    }
}
