using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    class Question
    {
        public int Qid;
        public string question;
        public List<Choice> choices;


        public Question(int _qid , string _question )
        {
            Qid = _qid;
            question = _question;
            
        }

    }
}
