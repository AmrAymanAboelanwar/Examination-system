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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int code = 0;
        private void loginBtn_Click(object sender, EventArgs e)
        {
           // check value format
            checkedCode(codeTxt.Text.ToString()); 
        }

        private void checkedCode(string val)
        {
            if (!int.TryParse(val, out this.code))
            {
                
                showMsgErr("Enter only number");
              
            }
            else
            {
               
                // admin  11111
                if (code == 11111)
                 {
                    Manage mang = new Manage();
                    this.Hide();
                    mang.ShowDialog();
                    this.Close();
                }

                else
                {
                    int stId =  checkedStudentCode();
                    if (stId != 0) {
                        ReadyToExam rte = new ReadyToExam(stId);
                        this.Hide();
                        rte.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        showMsgErr("Code not correct");
                    }
                }
            }
        }

        private int checkedStudentCode()
        {
            string sel = $"select St_id from Student where Code = {code}";
            sqlCommand1.CommandText = sel;
            sqlConnection1.Open();
            SqlDataReader sdr = sqlCommand1.ExecuteReader();
            int St_id = 0;
            while (sdr.Read())
            {
                St_id = int.Parse(sdr["St_id"].ToString());
            }

            sdr.Close();
            sqlConnection1.Close();
            return St_id;
        }


        private void showMsgErr(String val)
        {
            msg.Text = val;
            msg.ForeColor = Color.Red;
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

        
    }
}
