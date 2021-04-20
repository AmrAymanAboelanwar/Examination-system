using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system
{
    public partial class ReadyToExam : Form
    {
        private int stuentId,  crsId=0;
        public ReadyToExam(int stId)
        {
           
            InitializeComponent();
            this.stuentId = stId;
            getStudentData(this.stuentId);
        }
        
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (crsId == 0)
            {
                showMsgErr("plz select Course");
            }
            else
            {
                Exam exam = new Exam(this.stuentId, this.crsId);
                this.Hide();
                exam.ShowDialog();
                this.Close();
            }
           
        }

        private void ReadyToExam_Load(object sender, EventArgs e)
        {
            // getStudentCourses
            getStudentCourses();



        }


        Dictionary<int, string> dic = new Dictionary<int, string>();

        private void getStudentCourses()
        {
            sqlCommand1.Parameters.AddWithValue("@st_id", stuentId);
            sqlConnection1.Open();
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            try
            {
                while (sdr.Read())
                {
                    comboBox1.Items.Add(sdr["Crs_name"].ToString());
                    dic.Add(int.Parse(sdr["Crs_id"].ToString()), sdr["Crs_name"].ToString());
                }
            }
            catch
            {
                showMsgErr("No avaliable Exam For you");
            }
           
            sdr.Close();
            sqlConnection1.Close();
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in dic)
            {
                if (comboBox1.SelectedItem.ToString() == item.Value)
                {
                    crsId = item.Key;
                    break;
                }
            }
        }












        private void showMsgErr(String val)
        {
            label1.Text = val;
            label1.ForeColor = Color.Red;
            comboBox1.Enabled = false;
            startBtn.Enabled = false;
            setTimeout(err, 1000);
        }

        public void err()
        {
            msg.Text = "";
        }

        public void setTimeout(Action act, int timeout)
        {
            Action action = () =>
            {
                Thread.Sleep(timeout);
                act();
            };

            new Thread(() => Invoke(action)).Start();
        }



        private void getStudentData(int id)
        {
            
            try
            {
                sqlConnection1.Open();
                SqlCommand find = new SqlCommand("getStudent", sqlConnection1);
                find.CommandType = CommandType.StoredProcedure;
                find.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                SqlDataReader stu = find.ExecuteReader();
                while (stu.Read())
                {
                    stName.Text = stu["fname"].ToString()+" "+ stu["lname"].ToString();
     
                }
                stu.Close();
                sqlConnection1.Close();

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }

        }
    }
}
