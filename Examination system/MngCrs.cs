using Examination_system;
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

namespace DBProject
{
    public partial class MngCrs : Form
    {
        public MngCrs()
        {
            InitializeComponent();
        }
        Dictionary<int, string> InsDic = new Dictionary<int, string>();
        Dictionary<int, string> TFDic = new Dictionary<int, string>();
        Dictionary<int, string> MCDic = new Dictionary<int, string>();
        Dictionary<int, string> topicCrs = new Dictionary<int, string>();
        Dictionary<int, string> stdCrsDic = new Dictionary<int, string>();
        int insId;
        int stdcrsid;
        int MCId;
        int TFId;
        int topId;
        private void MngCrs_Load(object sender, EventArgs e)
        {
            GetAllCourses();
            GetCourseIns();
            GetQue();
            GetCrsTopic();
        }

        private void GetCrsTopic()
        {
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getCrsTopic", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(std.ExecuteReader());
                dataGridView2.DataSource = dt;
                                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void GetQue()
        {
            TFDic.Clear();
            MCDic.Clear();
            stdCrsDic.Clear();
            topicCrs.Clear();
            ExamDB.Open();
            try
            {
                
                SqlCommand crs = new SqlCommand("getAllcours", ExamDB);
                crs.CommandType = CommandType.StoredProcedure;
                SqlDataReader Crs = crs.ExecuteReader();
                while (Crs.Read())
                {
                    TFDic.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
                    namrCRS.Items.Add(Crs["Course Name"].ToString());
                    MCDic.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
                    CRS.Items.Add(Crs["Course Name"].ToString());
                    topicCrs.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
                    crs_Name.Items.Add(Crs["Course Name"]).ToString();
                    stdCrsDic.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
                    std_crs.Items.Add(Crs["Course Name"]).ToString();

                }
                Crs.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void GetCourseIns()
        {
            InsDic.Clear();
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getDeptIns", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    InsDic.Add(int.Parse(Std["Ins_id"].ToString()), Std["Name"].ToString());
                    insCrs.Items.Add(Std["Name"]).ToString();
                }
                Std.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void GetAllCourses()
        {
            ExamDB.Open();
            try
            {                
                SqlCommand std = new SqlCommand("getAllcours", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(std.ExecuteReader());
                dataGridView1.DataSource = dt;
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void insCrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in InsDic)
            {
                if (insCrs.SelectedItem.ToString() == item.Value)
                {
                    insId = item.Key;
                    break;
                }
            }
        }
        //add new course
        private void save_Click(object sender, EventArgs e)
        {

            ExamDB.Open();
            try
            {
                if (crsName.Text == "" 
                    || crsName.Text == null 
                    || crsName.Text.Length<2 
                    || dur.Text == null 
                    || dur.Text == ""
                    ) { MessageBox.Show("^_^ Please Enter Valid Data ^_^"); }
                else
                {
                    SqlCommand cmd = new SqlCommand("addCourse", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@crsname", SqlDbType.NVarChar).Value = crsName.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@dur", SqlDbType.Int).Value = dur.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@insId", SqlDbType.Int).Value = insId;
                    int x = cmd.ExecuteNonQuery();
                    if (x == -1)
                    {
                        MessageBox.Show("^_^ course is  existed ^_^");
                    }
                    else
                    {
                        MessageBox.Show("^_^ You Added New Course ^_^");
                    }                    
                    crsName.Text = dur.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            GetAllCourses();
            GetQue();
        }
        //add MC Question
        private void addMCQue_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (qubox.Text == null || qubox.Text == "" || 
                    deg.Text == null || deg.Text == "" ||
                    a.Text == null || a.Text == "" ||
                    b.Text == null || c.Text == "" ||
                    d.Text == null || b.Text == "" ||
                    b.Text == null || d.Text == "" ||
                    qubox.Text.Length <5 
                    ) { MessageBox.Show(" ^_^ please Enter Data Frist ^_^"); }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("addNewMcQuestion", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@question", SqlDbType.NVarChar).Value = qubox.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@grade", SqlDbType.Int).Value = deg.Text.Trim().ToString();
                    cmd.Parameters.AddWithValue("@ansid", SqlDbType.Int).Value = answer.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@ch1", SqlDbType.Int).Value = a.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@ch2", SqlDbType.Int).Value = b.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@ch3", SqlDbType.Int).Value = c.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@ch4", SqlDbType.Int).Value = d.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@crs_id", SqlDbType.Int).Value = MCId;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("^_^ You Added New Question ^_^");
                    
                    qubox.Text = crsName.Text = deg.Text = answer.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void CRS_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in MCDic)
            {
                if (CRS.SelectedItem.ToString() == item.Value)
                {
                    MCId = item.Key;
                    break;
                }
            }
        }
        //add TF Question
        private void addTFQuestion_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (queBox.Text == null || queBox.Text == ""
                    || queBox.Text.Length < 5 || degree.Text == null
                    || degree.Text == "" || anserBox.Text == ""
                    || anserBox.Text == null
                    )
                { 
                    MessageBox.Show("^_^ your question is very short ^_^");
                    queBox.Text = degree.Text = anserBox.Text = String.Empty;
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("addNewTFQuestion", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@question", SqlDbType.NVarChar).Value = queBox.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@grade", SqlDbType.Int).Value = degree.Text.Trim().ToString();
                    cmd.Parameters.AddWithValue("@ansid", SqlDbType.Int).Value = anserBox.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@crs_id", SqlDbType.Int).Value = TFId;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("^_^ You Added New Question ^_^");
                    
                    queBox.Text = degree.Text = anserBox.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
                queBox.Text = degree.Text = anserBox.Text = String.Empty;
            }
            ExamDB.Close();

        }

        private void namrCRS_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in TFDic)
            {
                if (namrCRS.SelectedItem.ToString() == item.Value)
                {
                    TFId = item.Key;
                    break;
                }
            }
        }        

        private void crs_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in topicCrs)
            {
                if (crs_Name.SelectedItem.ToString() == item.Value)
                {
                    topId = item.Key;
                    break;
                }
            }
        }
        //get course Data on selct crs name
        private void std_crs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in stdCrsDic)
            {
                if (std_crs.SelectedItem.ToString() == item.Value)
                {
                    stdcrsid = item.Key;
                    break;
                }
            }
            GetallStdCourse();
        }

        private void GetallStdCourse()
        {
            ExamDB.Open();
            try
            {
                SqlCommand std = new SqlCommand("getAllStdinCrs", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dTable = new DataTable();
                std.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = std_crs.Text.Trim().ToString();
                dTable.Load(std.ExecuteReader());
                dataGridView3.DataSource = dTable;

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }
        //add new topic
        private void addTopic_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (topName.Text==null|| topName.Text==""|| topName.Text.Length<3) { MessageBox.Show("^_^ Please Enter more than 3 char ^_^"); }
                SqlCommand cmd = new SqlCommand("addNewTopicInCourse", ExamDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@crs_id", SqlDbType.NVarChar).Value = topId;
                cmd.Parameters.AddWithValue("@t_name", SqlDbType.Int).Value = topName.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("^_^ You Added New Tpoic ^_^");
                
                topName.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            GetCrsTopic();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }
        private void cnl_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void crsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Char is allowed ^_^");
            }
        }
        private void dur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Number is allowed ^_^");
            }
        }
    }
}
