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
    public partial class MngDept : Form
    {
        public MngDept()
        {
            InitializeComponent();
        }
        Dictionary<int, string> instructordic = new Dictionary<int, string>();
        Dictionary<int, string> mngDic = new Dictionary<int, string>();
        Dictionary<int, string> manger = new Dictionary<int, string>();
        int mngID;
        int deptID;
        int depID;
        private void MngDept_Load(object sender, EventArgs e)
        {
            GetDeptData();
            GetInsDept();
            GetDeptName();
            GetDeptMng();
        }
        private void GetDeptMng()
        {
            //instructordic.Clear();
            ExamDB.Open();
            try
            {                 
                SqlCommand std = new SqlCommand("getDeptIns", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    instructordic.Add(int.Parse(Std["Ins_id"].ToString()), Std["Name"].ToString());
                    deptMng.Items.Add(Std["Name"]).ToString();
                }
                Std.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }
        //page of dept'sStd
        private void GetDeptName()
        {
            nameDept.Items.Clear();
            manger.Clear();
            ExamDB.Open();
            try
            {                
                SqlCommand std = new SqlCommand("getdept", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    manger.Add(int.Parse(Std["Manger Code"].ToString()), Std["Department Name"].ToString());
                    nameDept.Items.Add(Std["Department Name"]).ToString();
                }
                Std.Close();
            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
        }
        //get load of instructor dept data in combo box
        private void GetInsDept()
        {
            stdName.Items.Clear();
            mngDic.Clear();
            ExamDB.Open();
            try
            {                 
                SqlCommand std = new SqlCommand("getdept", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                SqlDataReader Std = std.ExecuteReader();
                while (Std.Read())
                {
                    mngDic.Add(int.Parse(Std["Manger Code"].ToString()), Std["Department Name"].ToString());
                    stdName.Items.Add(Std["Department Name"]).ToString();
                }
                Std.Close();
                
            }
            catch
            {
                MessageBox.Show("^_^ please enter valid data ^_^");
            }
            ExamDB.Close();

        }
        //dataload of department
        private void GetDeptData()
        {
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getdept", ExamDB);
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
        //new department
        private void save_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                if (deptName.Text==null|| deptName.Text==""|| deptName.Text.Length<2)
                {
                    MessageBox.Show("^_^ The Data you Enterd is too Short ^_^");
                }
                else {
                    SqlCommand cmd = new SqlCommand("addDepartment", ExamDB);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dname", SqlDbType.NVarChar).Value = deptName.Text.ToString().Trim();
                    cmd.Parameters.AddWithValue("@mgr_id", SqlDbType.Int).Value = mngID;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("^_^ You Added New Department ^_^");

                    deptName.Text = deptMng.Text = String.Empty;
                }

            }
            catch
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            GetDeptData();
            GetDeptName();
            GetInsDept();
        }
        //newdept page droplist
        private void mgr_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in instructordic)
            {
                if (deptMng.SelectedItem.ToString() == item.Value)
                {
                    mngID = item.Key;
                    break;
                }
            }
        }
        //only show data of department's instructor
        private void stdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var item in mngDic)
            {
                if (stdName.SelectedItem.ToString() == item.Value)
                {
                    deptID = item.Key;
                    break;
                }
            }
            ExamDB.Open();
            try
            {
                
                SqlCommand std = new SqlCommand("getcourInInstr", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dTable = new DataTable();
                std.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = deptID;
                dTable.Load(std.ExecuteReader());
                dataGridView2.DataSource = dTable;
                std.Parameters.Clear();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
               // MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();

        }
        private void nameDept_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            foreach (var item in manger)
            {
                if (nameDept.SelectedItem.ToString() == item.Value)
                {
                    depID = item.Key;
                    break;
                }
            }
            ExamDB.Open();
            try
            {               
                SqlCommand std = new SqlCommand("getStudentByDept", ExamDB);
                std.CommandType = CommandType.StoredProcedure;
                DataTable dTable = new DataTable();               
                std.Parameters.AddWithValue("@deptId", SqlDbType.VarChar).Value = depID;
                dTable.Load(std.ExecuteReader());
                dataGridView3.DataSource = dTable;
                
            }
            catch(Exception)
            {
                MessageBox.Show("^_^ Please Enter Valid Data ^_^");
            }
            ExamDB.Close();
            GetDeptData();

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
        private void delete_Click(object sender, EventArgs e)
        {
            ExamDB.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("deleteDeparment", ExamDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = deptID;
                int affRows = cmd.ExecuteNonQuery();
                if (affRows > 0)
                {
                    MessageBox.Show("^_^ You Deleted The Department ^_^");
                    ExamDB.Close();
                    dataGridView2.DataSource=null;
                    dataGridView2.Refresh();
                   
                    GetInsDept();
                    
                    

                }
                else
                {
                    MessageBox.Show("^_^ select department at first ^_^");
                    ExamDB.Close();


                }
               

            }

            catch (Exception)
            {
                MessageBox.Show("Can't Delete Departement With Students !! ");
            }
           

        }
        private void deptName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("^_^ Only Char is allowed ^_^");
            }
        }
    }
}
