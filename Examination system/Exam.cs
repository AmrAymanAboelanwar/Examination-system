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
   
    public partial class Exam : Form
    {
        int crsID;
        int exNo;
        int stuId;
        List<Question> exList;
        List<Choice> stuAnswer = new List<Choice>();
        Dictionary<int,int> studentAnswers = new Dictionary<int,int>();
        Dictionary<int,List<RadioButton>> qDic = new Dictionary< int, List<RadioButton>>() ;
        public Exam(int stId,int crsId)
        {
            InitializeComponent();
            crsID = crsId;
            exNo = getExamNo();
            stuId=stId;
            getExam(crsId,exNo);


        }


       

        private int getExamNo()
        {
            int exNo = 0;
            sqlConnection1.Open();
            sqlCommand1.Parameters.AddWithValue("crs_id", crsID);
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                exNo = (int) sdr["Ex_id"];
            }

            sdr.Close();
            sqlConnection1.Close();

            return exNo;
        }



        private void getExam (int crsId , int examNo){

            SqlCommand cmd = new SqlCommand("getExamInCourse",sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@crsId", crsId);
            cmd.Parameters.AddWithValue("@examNo", examNo);
            sqlConnection1.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            List<Question> ql = new List<Question>();
            List<Choice> chL = null;
            Choice c =null;
            Question que = null;
          
            while (sdr.Read())
            {
                que= new Question((int)sdr["Q_id"], sdr["question"].ToString());
                c = new Choice((int)sdr["ch_id"], sdr["choice"].ToString(), (int)sdr["Q_id"]);
                List<Question> q = ql.FindAll(e => e.Qid == (int)sdr["Q_id"]);

                if (q.Count > 0)
                {
                    chL.Add(c);
                }
                else
                {
                      chL = new List<Choice>();
                      que.choices = chL;
                      ql.Add(que);
                      chL.Add(c);
                }

            }

            exList = ql;
            sdr.Close();
            sqlConnection1.Close();

        }

        // finish Btn
        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show(" Are you sure ","message",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // navigate to degree
                int c = saveStudentAnswers(stuId,crsID, exNo ,studentAnswers);
                if (c > 0)
                {
                    Result r = new Result(stuId, exNo,crsID);
                    this.Hide();
                    r.ShowDialog();
                    this.Close();

                }
                else
                {
                    // error
                }

                               
            }
        }

     

        int n =0;

        int s = 50;
        List<RadioButton> RL = null;
        private void Exam_Load(object sender, EventArgs e)
        {
            RL = new List<RadioButton>();
            RL.Add(radioButton1);
            RL.Add(radioButton2);
            RL.Add(radioButton3);
            RL.Add(radioButton4);

            button2.Hide(); // finish btn
            prev.Hide();


            num.Text = " ( " + (n + 1).ToString() + " ) ";
            ques.Text = exList[n].question;
            for (int i = 0; i < exList[n].choices.Count(); i++)
            {
                RL[i].Text = exList[n].choices[i].choice;
                RL[i].Name = exList[n].choices[i].choicID.ToString()+","+ exList[n].Qid;
            }



        }
       
        private void Next_Click(object sender, EventArgs e)
        {
            prev.Show();

            // empty radio buttons 
            for (int i = 0; i < RL.Count(); i++)
            {
                RL[i].Hide();
                RL[i].Checked = false;
            }

            // increment 
            if (n < exList.Count()-1)
            {
                n++;
                num.Text = " ( " + (n + 1).ToString() + " ) ";
                ques.Text = exList[n].question;
            }

            if (n == exList.Count() - 1)
            {
                Next.Hide();
                button2.Show();
            }


            // add choices to qiestion in radio
            for (int i = 0; i < exList[n].choices.Count(); i++)
            {

                foreach (var item in studentAnswers)
                {
                    if (exList[n].choices[i].choicID == item.Value && exList[n].Qid == item.Key)
                    {
                        RL[i].Checked = true;
                        break;
                    }
                }

                RL[i].Text = exList[n].choices[i].choice;
                RL[i].Name = exList[n].choices[i].choicID.ToString() + "," + exList[n].Qid;
                RL[i].Show();
            }

           

        }
   

        private void prev_Click(object sender, EventArgs e)
        {

            button2.Hide();
            Next.Show();

            if (n > 0)
            {
                n--;
                ques.Text = exList[n].question;
                num.Text = " ( " + (n + 1).ToString() + " ) ";
            }


            for (int i = 0; i < RL.Count(); i++)
            {
                RL[i].Hide();
                RL[i].Checked = false;
            }

            for (int j = 0; j < exList[n].choices.Count(); j++)
            {
                foreach (var item in studentAnswers)
                {
                    if (exList[n].choices[j].choicID == item.Value && exList[n].Qid==item.Key)
                    {
                        RL[j].Checked = true;
                        break;
                    }
                }
                RL[j].Text = exList[n].choices[j].choice;
                RL[j].Name = exList[n].choices[j].choicID.ToString() + "," + exList[n].Qid;
                RL[j].Show();
            }



        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            int chid = int.Parse(r.Name.Split(',')[0]);
            int QId = int.Parse(r.Name.Split(',')[1]);
            

            if (studentAnswers.Count()==0 || !studentAnswers.ContainsKey(QId))
            {
                studentAnswers.Add(QId, chid);
            }
            else
            {
                foreach (var item in studentAnswers)
                {
                    if (item.Key == QId)
                    {
                        studentAnswers[item.Key] = chid;
                        break;
                    }
                }
            }

        }


        private int saveStudentAnswers(int stuId,int crsId, int exNo, Dictionary<int, int> studentAnswers)
        {

            sqlConnection1.Open();
            
            int affRows=0;
            foreach (var item in studentAnswers)
            {
                SqlCommand cmd = new SqlCommand("studentAnswers", sqlConnection1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stud_id", stuId);
                cmd.Parameters.AddWithValue("@crs_id", crsId);
                cmd.Parameters.AddWithValue("@ex_id", exNo);
                cmd.Parameters.AddWithValue("@answer_id",item.Value);
                affRows+=cmd.ExecuteNonQuery();
            }
            sqlConnection1.Close();
            return affRows;
          
        }



    }
}
