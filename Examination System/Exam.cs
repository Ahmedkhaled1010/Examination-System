using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal abstract  class Exam
    {

        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int _Time, int _NumOfQuestions)
        {
            Time = _Time;
            NumOfQuestions = _NumOfQuestions;
        }

        public abstract void CreateQuestions();
        public abstract void ShowExam();
    }
}
