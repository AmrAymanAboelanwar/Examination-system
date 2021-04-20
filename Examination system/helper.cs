using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system
{
    class Helper:Form
    {

        public static void back(Form current , Form pre)
        {
            current.Hide();
            pre.ShowDialog();
            current.Close();
        }
    }
}
