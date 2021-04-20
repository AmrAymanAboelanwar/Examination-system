using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class Choice
    {

        public int choicID;
        public int Q_id;
        public string choice;

        public Choice(int _cId, string _choice, int qId)
        {
            this.choicID = _cId;
            this.Q_id = qId;
            this.choice = _choice;
        }

    }
}
