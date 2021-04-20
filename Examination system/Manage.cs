using Examination_system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }              
        private void MngStd_Click(object sender, EventArgs e)
        {
            MngStd frm = new MngStd();
            hideForm(frm);
        }
        private void MngCrs_Click(object sender, EventArgs e)
        {
            MngCrs frm = new MngCrs();
            hideForm(frm);
        }
        private void MngDept_Click(object sender, EventArgs e)
        {
            MngDept frm = new MngDept();
            hideForm(frm);
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            ManageExam me = new ManageExam();
            hideForm(me);
        }

        private void btnins_Click(object sender, EventArgs e)
        {
            MngIns frm = new MngIns();
            hideForm(frm);
        }

        private void report_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            hideForm(frm);
        }


        private void hideForm(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
