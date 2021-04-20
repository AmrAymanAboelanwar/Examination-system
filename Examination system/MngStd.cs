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
    public partial class MngStd : Form
    {
        public MngStd()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        Dictionary<int, string> stdnameDic = new Dictionary<int, string>();
        Dictionary<int, string> deptNamedic = new Dictionary<int, string>();
        Dictionary<int, string> crsdic = new Dictionary<int, string>();
        int deptId;
        private void MngStd_Load(object sender, EventArgs e)
        {
            getStdData();
            NewStudentPage();
            getDepartMent();
            getStdName();
        }
        private void getStdName()
        {
            stdnameDic.Clear();
            ExamDB.Open();
            try
            {

                SqlCommand std = new SqlCommand("getAllStdName ", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    stdnameDic.Add(int.Parse(Std["St_id"].ToString()), Std["FullName"].ToString());
                    nameStd.Items.Add(Std["FullName"]).ToString();
                }
                Std.Close();

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            
        }
        private void getDepartMent()
        {
            ExamDB.Open();
            try
            {                
                SqlCommand std = new SqlCommand("getdept", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    deptNamedic.Add(int.Parse(Std["Manger Code"].ToString()), Std["Department Name"].ToString());
                    DeptName.Items.Add(Std["Department Name"]).ToString();
                }
                Std.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }
        private void NewStudentPage()
        {
            try
            {
                ExamDB.Open();
                SqlCommand std = new SqlCommand("getdept", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    dic.Add(int.Parse(Std["Manger Code"].ToString()), Std["Department Name"].ToString());
                    dept.Items.Add(Std["Department Name"]).ToString();
                }
                Std.Close();
                ExamDB.Close();
                ExamDB.Open();
                SqlCommand crs = new SqlCommand("getAllcours", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Crs = crs.ExecuteReader();
                while (Crs.Read())
                {
                    dic1.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
                }
                Crs.Close();
                ExamDB.Close();
                int x = 10;
                foreach (var item in dic1)
                {

                    x += 30;
                    CheckBox cb = new CheckBox();
                    cb.AutoSize = true;
                    cb.Location = new Point(800, 160 + x);
                    cb.Text = item.Value;
                    cb.Name = item.Key.ToString();
                    cb.CheckedChanged += CourseName;
                    tabPage2.Controls.Add(cb);
                }

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }

        }
        public void getStdData()
        {
            ExamDB.Open();
            try
            {                
                SqlCommand std = new SqlCommand("getAllStd", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(std.ExecuteReader());
                dataGridView1.DataSource = dt;
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Data Load ^_^");
            }
            ExamDB.Close();
        }
        private void save_Click(object sender, EventArgs e)
        {
            addNewStd();
            getStdData();
            getStdName();
        }
        private void addNewStd()
        {    
            
            ExamDB.Open();
            try
            {
                if (fname.Text == null
                    || fname.Text == ""
                    || fname.Text.Length <= 3
                    || lname.Text.Length <= 3
                    || lname.Text == null 
                    || lname.Text == ""
                    || ads.Text == null 
                    || ads.Text == "" 
                    || bod.Text == null 
                    || bod.Text == "" 
                    || dept.Text == null 
                    || dept.Text == ""
                    ) 
                { MessageBox.Show(" ^_^ please Correct Data & your Name must be >= 3 char ^_^"); }
                else
                {
                    SqlCommand cmd = new SqlCommand("addStudent", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = fname.Text;
                    cmd.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value = lname.Text;
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = ads.Text;
                    cmd.Parameters.AddWithValue("@bod", SqlDbType.Date).Value = bod.Value.Date.ToString().Split(' ')[0];
                    cmd.Parameters.AddWithValue("@dept", SqlDbType.Int).Value = deptId;
                    SqlDataReader CMD = cmd.ExecuteReader();
                    int Std = 0;
                    while (CMD.Read())
                    {
                        Std = int.Parse(CMD["St_id"].ToString());
                    }
                    CMD.Close();
                    fname.Text = lname.Text = ads.Text = bod.Text = dept.Text = String.Empty;
                    int Crs = 0;

                    for (int i = 0; i < checkedCrs.Count; i++)
                    {
                        SqlCommand chcrs = new SqlCommand("addStudentCourse", ExamDB);
                        chcrs.CommandType = CommandType.StoredProcedure;
                        chcrs.Parameters.AddWithValue("@st_id", SqlDbType.Int).Value = Std;
                        chcrs.Parameters.AddWithValue("@crs_id", SqlDbType.Int).Value = checkedCrs[i];
                        Crs = chcrs.ExecuteNonQuery();
                    }

                    MessageBox.Show("^_^ You Added New Student ^_^");
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            getStdName();
        }
            List<int> checkedCrs = new List<int>();
        private void CourseName(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (checkedCrs.Count() == 0 || !checkedCrs.Contains(int.Parse(c.Name)))
            {
                checkedCrs.Add(int.Parse(c.Name));
            }
            else
            {
                foreach (var item in checkedCrs)
                {
                    if (item == int.Parse(c.Name))
                    {
                        checkedCrs.Remove(item);
                        break;
                    }
                }
            }
        }
        private void dept_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            foreach (var item in dic)
            {
                if (dept.SelectedItem.ToString() == item.Value)
                {
                    deptId = item.Key;
                    break;
                }
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (stdName.Text == null 
                    || stdName.Text == "" 
                    || stdName.Text.Length <= 3 
                    || lastname.Text.Length <= 3 
                    || lastname.Text ==null 
                    || lastname.Text =="" 
                    || DeptName.Text == null 
                    || DeptName.Text == ""
                    ) 
                { MessageBox.Show(" ^_^ please Enter a Correct Data & the name must be more or equal 3 ^_^"); }
                else
                {
                    
                    SqlCommand edit = new SqlCommand("updateStudent", ExamDB);
                    edit.CommandType = CommandType.StoredProcedure;
                    edit.Parameters.AddWithValue("@id", SqlDbType.Int).Value = stdID.SelectedItem;
                    edit.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = stdName.Text;
                    edit.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value = lastname.Text;
                    edit.Parameters.AddWithValue("@bod", SqlDbType.DateTime).Value = dob.Value.Date.ToString().Split(' ')[0];
                    edit.Parameters.AddWithValue("@add", SqlDbType.NVarChar).Value = address.Text;
                    edit.Parameters.AddWithValue("@dept", SqlDbType.Int).Value = deptId;
                    edit.ExecuteNonQuery();
                    MessageBox.Show("^_^ You Updated New Student ^_^");
                    ExamDB.Close();
                    dob.Text = address.Text = DeptName.Text = stdName.Text = lastname.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
                dob.Text = address.Text = DeptName.Text = stdName.Text = lastname.Text = string.Empty;

            }
            ExamDB.Close();
            getStdData();
            getStdName();
        }
        private void DeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            stdID.Items.Clear();
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getstdID", ExamDB);

                std.CommandType = CommandType.StoredProcedure;
                foreach (var item in deptNamedic)
                {
                    if (DeptName.SelectedItem.ToString() == item.Value)
                    {
                        deptId = item.Key;
                        break;
                    }
                }
                std.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deptId;

                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    stdID.Items.Add(Std["St_id"]).ToString();
                }
                Std.Close();

                dob.Text = address.Text = DeptName.Text = stdName.Text = lastname.Text = string.Empty;

            }
            catch
            {
                MessageBox.Show("^_^ This Department Has No Student ^_^");
                dob.Text = address.Text = DeptName.Text = stdName.Text = lastname.Text = string.Empty;
            }
            
            ExamDB.Close();
            getStdName();
        }
        private void stdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            dob.Text = address.Text = DeptName.Text = stdName.Text = lastname.Text = string.Empty;
            try
            {
                ExamDB.Open();
                SqlCommand find = new SqlCommand("getStudent", ExamDB);
                find.CommandType = CommandType.StoredProcedure;
                find.Parameters.AddWithValue("@id", SqlDbType.Int).Value = stdID.SelectedItem;
                SqlDataReader Find = find.ExecuteReader();
                while (Find.Read())
                {
                    stdName.Text = Find["fname"].ToString();
                    lastname.Text = Find["lname"].ToString();
                    address.Text = Find["Address"].ToString();
                    dob.Text = Find["BirthDate"].ToString();
                }
                Find.Close();
                ExamDB.Close();

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
        }       
        int stid = 0;
        private void nameStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                avCrs.Items.Clear();
                crsdic.Clear();
                ExamDB.Open();
                SqlCommand std = new SqlCommand("getAvailableCrs", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                foreach (var item in stdnameDic)
                {
                    if (nameStd.SelectedItem.ToString() == item.Value)
                    {
                        stid = item.Key;
                        break;
                    }
                }
                std.Parameters.AddWithValue("@id", SqlDbType.Int).Value = stid;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    crsdic.Add(int.Parse(Std["Crs_id"].ToString()), Std["Crs_name"].ToString());
                    avCrs.Items.Add(Std["Crs_name"]).ToString();
                }        

                Std.Close();
                ExamDB.Close();

            }
            catch
            {
                MessageBox.Show("^_^ This Student is enrolled to all courses ^_^");
            }

        }
        int crsid;
        Dictionary<int,string> crsesIds = new Dictionary <int,string>();
        private void avCrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in crsdic)
            {
                if (item.Value == avCrs.SelectedItem.ToString())
                {
                    crsid = item.Key;
                    if (!enrolledCrs.Items.Contains(item.Value))
                    {
                        crsesIds.Add(item.Key, item.Value);
                        enrolledCrs.Items.Add(item.Value);
                    }
                    break;
                }
            }
        }
        private void enrollbtn_Click(object sender, EventArgs e)
        {
            int Find = 0;
            try
            {
                ExamDB.Open();
                foreach (var item in crsesIds)
                {
                    SqlCommand find = new SqlCommand("addStudentCourse", ExamDB);
                    find.CommandType = CommandType.StoredProcedure;
                    find.Parameters.AddWithValue("@st_id", SqlDbType.Int).Value = stid;
                    find.Parameters.AddWithValue("@crs_id", SqlDbType.Int).Value = item.Key;
                    Find += find.ExecuteNonQuery();
                }
               
                
               
                if (Find < 1)
                {
                    MessageBox.Show("^_^ Courses not added ^_^");
                }
                else
                {
                    enrolledCrs.Items.Clear();
                    MessageBox.Show("^_^ Courses is added ^_^");
                }
                ExamDB.Close();
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }
        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {           
            // Character Validation(only Character allowed)
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Char is allowed ^_^");
            }          

        }
    }
}
