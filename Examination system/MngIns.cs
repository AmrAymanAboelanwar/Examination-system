using DBProject;
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
    public partial class MngIns : Form
    {
        public MngIns()
        {
            InitializeComponent();
        }
        Dictionary<int, string> InsDic = new Dictionary<int, string>();
        Dictionary<int, string> deptDic = new Dictionary<int, string>();
        Dictionary<int, string> coursDic = new Dictionary<int, string>();
        int insId;
        private void MngIns_Load(object sender, EventArgs e)
        {
            GetInsDataOnLoad();
            GetCourseIns();
            GetNewStdDataOnLoad();
        }

        private void GetNewStdDataOnLoad()
        {
            deptDic.Clear();
            ExamDB.Open();
            SqlCommand std = new SqlCommand("getdept", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Std = std.ExecuteReader();
            while (Std.Read())
            {
                deptDic.Add(int.Parse(Std["Manger Code"].ToString()), Std["Department Name"].ToString());
                deptName.Items.Add(Std["Department Name"]).ToString();
                name_dept.Items.Add(Std["Department Name"]).ToString();
            }
            Std.Close();
            ExamDB.Close();
            ExamDB.Open();
            SqlCommand crs = new SqlCommand("getAllcours", ExamDB);
            std.CommandType = CommandType.StoredProcedure;
            SqlDataReader Crs = crs.ExecuteReader();
            while (Crs.Read())
            {
                coursDic.Add(int.Parse(Crs["Course Code"].ToString()), Crs["Course Name"].ToString());
            }
            Crs.Close();
            ExamDB.Close();
            int x = 10;
            foreach (var item in coursDic)
            {

                x += 30;
                CheckBox cb = new CheckBox();
                cb.AutoSize = true;
                cb.Location = new Point(800, 100 + x);
                cb.Text = item.Value;
                cb.Name = item.Key.ToString();
                cb.CheckedChanged += CourseName;
                tabPage2.Controls.Add(cb);
            }


        }

        //ins data on load
        private void GetInsDataOnLoad()
        {
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getInstructorData", ExamDB);
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
                    insName.Items.Add(Std["Name"]).ToString();
                }
                Std.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }
        private void insName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in InsDic)
            {
                if (insName.SelectedItem.ToString() == item.Value)
                {
                    insId = item.Key;
                    break;
                }
            }
            ExamDB.Open();
            try
            {

                
                SqlCommand std = new SqlCommand("getInstructorWithCourseAndNoStudent", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dTable = new DataTable();
                std.Parameters.AddWithValue("@InsId", SqlDbType.VarChar).Value = insId;
                dTable.Load(std.ExecuteReader());
                dataGridView2.DataSource = dTable;
               
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            addNewIns();
            GetInsDataOnLoad();
            GetCourseIns();
        }
        int ins_id;

        private void addNewIns()
        {
            ExamDB.Open();
            try
            {
                if (ins_Name.Text == null 
                    || ins_Name.Text == "" 
                    || ins_Name.Text.Length < 3 
                    || adress.Text == null 
                    || adress.Text == ""
                    || bod.Text == null 
                    || bod.Text == ""
                    )
                { MessageBox.Show(" ^_^ please Enter Data Frist ^_^"); }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("addInstructor", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@insName", SqlDbType.NVarChar).Value = ins_Name.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Decimal).Value = salary.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@hireDate", SqlDbType.Date).Value = hireData.Value.Date.ToString().Split(' ')[0];
                    cmd.Parameters.AddWithValue("@addr", SqlDbType.NVarChar).Value = adress.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.Date).Value = bod.Value.Date.ToString().Split(' ')[0];
                    cmd.Parameters.AddWithValue("@depId", SqlDbType.Int).Value = ins_id;
                    SqlDataReader CMD = cmd.ExecuteReader();
                    int Std = 0;
                    while (CMD.Read())
                    {
                        Std = int.Parse(CMD["Ins_id"].ToString());
                    }
                    CMD.Close();
                    ins_Name.Text = salary.Text = hireData.Text = bod.Text = adress.Text = String.Empty;
                    int Crs = 0;

                    for (int i = 0; i < checkedCrs.Count; i++)
                    {
                        SqlCommand chcrs = new SqlCommand("addCrsIns", ExamDB);
                        chcrs.CommandType = CommandType.StoredProcedure;
                        chcrs.Parameters.AddWithValue("@insid", SqlDbType.Int).Value = Std;
                        chcrs.Parameters.AddWithValue("@crsid", SqlDbType.Int).Value = checkedCrs[i];
                        Crs = chcrs.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("^_^ You Added New Instructor ^_^");
                }
            }
             catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
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
        int insID;
        private void deptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in deptDic)
            {
                if (deptName.SelectedItem.ToString()==item.Value)
                {
                    ins_id = item.Key;
                    break;
                }
            }
        }

        private void name_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDINS.Items.Clear();
            ExamDB.Open();
            try
            {
                
                SqlCommand ins = new SqlCommand("getInstructorID", ExamDB);
                ins.CommandType = CommandType.StoredProcedure;
                foreach (var item in deptDic)
                {
                    if (name_dept.SelectedItem.ToString() == item.Value)
                    {
                        insID = item.Key;
                        break;
                    }
                }
                ins.Parameters.AddWithValue("@id", SqlDbType.Int).Value = insID;
                SqlDataReader INS = ins.ExecuteReader();
                while (INS.Read())
                {
                    IDINS.Items.Add(INS["Ins_id"]).ToString();
                }
                INS.Close();
                
                DOB.Text = name.Text = sal.Text = ads.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("This Department has No Instructors");
            }
            ExamDB.Close();

        }

        private void IDINS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOB.Text = name.Text = sal.Text = ads.Text = string.Empty;
            ExamDB.Open();
            try
            {
                
                SqlCommand find = new SqlCommand("getInstructor", ExamDB);
                find.CommandType = CommandType.StoredProcedure;
                find.Parameters.AddWithValue("@id", SqlDbType.Int).Value = IDINS.SelectedItem;
                SqlDataReader Find = find.ExecuteReader();
                while (Find.Read())
                {
                    name.Text = Find["Name"].ToString();
                    sal.Text = Find["Salary"].ToString();
                    ads.Text = Find["Address"].ToString();
                    DOB.Text = Find["BirthDate"].ToString();
                }
                Find.Close();              

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (name.Text == null || name.Text == "" 
                    || name.Text.Length < 3 
                    || sal.Text == null || sal.Text == ""
                    || ads.Text == null || ads.Text == ""
                    ) { MessageBox.Show(" ^_^ please Enter Data Frist^_^"); }
                else
                {
                    
                    SqlCommand edit = new SqlCommand("updateInstructor", ExamDB);
                    edit.CommandType = CommandType.StoredProcedure;
                    edit.Parameters.AddWithValue("@id", SqlDbType.Int).Value = IDINS.SelectedItem;
                    edit.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name.Text;
                    edit.Parameters.AddWithValue("@salary", SqlDbType.Decimal).Value = sal.Text;
                    edit.Parameters.AddWithValue("@addr", SqlDbType.VarChar).Value = ads.Text;
                    edit.Parameters.AddWithValue("@BirthDate", SqlDbType.Date).Value = DOB.Value.Date.ToString().Split(' ')[0]; ;
                    edit.Parameters.AddWithValue("@depId", SqlDbType.Int).Value = insID;
                    edit.ExecuteNonQuery();
                    MessageBox.Show("^_^ You Updated The Instructor ^_^");
                    
                    name.Text = sal.Text = ads.Text  = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
                name.Text = sal.Text = ads.Text = string.Empty;

            }
            ExamDB.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Helper.back(this, new Manage());
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void ins_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Char is allowed ^_^");
            }
        }
        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Number is allowed ^_^");
            }
        }
    }
}
