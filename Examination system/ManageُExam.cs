using DBProject;
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
    public partial class ManageExam : Form
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        public ManageExam()
        {
            InitializeComponent();
        }

        private void ManageExam_Load(object sender, EventArgs e)
        {
            string sel = "select Crs_id,Crs_name from Course";
            sqlCommand1.CommandType = CommandType.Text;
            sqlCommand1.CommandText = sel;
            sqlConnection1.Open();
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["Crs_name"]);
                dic.Add(int.Parse(sdr["Crs_id"].ToString()), sdr["Crs_name"].ToString());
            }
            sdr.Close();
            sqlConnection1.Close();
        }




        string course = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            course = comboBox1.SelectedItem.ToString();

        }

        int val = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            int crsId = 0, NoOfMc = 0, NoOftf = 0, duraa = 0;
            string Desc = "";

            foreach (var item in dic)
            {
                if (course == dic[item.Key])
                {
                    crsId = item.Key;
                    break;
                }
            }


            try
            {


                if (course.Length == 0 && mc.Text.ToString().Length < 1 && tf.Text.ToString().Length < 1 && dura.Text.ToString().Length < 1)
                {


                    showMsgErr("Data Not Valid");
                }
                else
                {
                    NoOfMc = int.Parse(mc.Text.ToString());
                    NoOftf = int.Parse(tf.Text.ToString());
                    duraa = int.Parse(dura.Text.ToString());
                    Desc = disc.Text.ToString();

                    val = generateExam(crsId, NoOfMc, NoOftf, Desc, duraa);

                    if (val > 0)
                    {
                        msg.Text = "Exam in this Course generate successfully";
                        msg.ForeColor = Color.Green;
                        setTimeout(err, 1000);
                    }
                    else
                    {
                        showMsgErr("This Course doesn't have this rang of question to generate");
                    }
                }
            }
            catch
            {
                showMsgErr("data not valid");
            }

        }


        private int generateExam(int crsId, int noOfMc, int noOftf, string desc, int dura)
        {
            //@CourseId int,@mc int , @tf int,@desc nvarchar(500),@dur float
            int AffictedRows = 0;
            SqlCommand cmd = new SqlCommand("genrateExam", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseId", crsId);
            cmd.Parameters.AddWithValue("@mc", noOfMc);
            cmd.Parameters.AddWithValue("@tf", noOftf);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@dur", dura);
            try
            {
                sqlConnection1.Open();
                AffictedRows = cmd.ExecuteNonQuery();
            }
            catch
            {
                showMsgErr("error connection");
            }

            sqlConnection1.Close();
            return AffictedRows;
        }





        private void showMsgErr(String val)
        {
            msg.Text = val;
            msg.ForeColor = Color.Red;
            setTimeout(err, 3000);
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

        private void Back_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }
    }
}
