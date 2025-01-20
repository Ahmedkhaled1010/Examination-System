using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal abstract class Question
    {

        public abstract string? Header { get;  }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answer[]? Answers { get; set; }
        public Answer? UserAnswer { get; set; }

        public Answer? RightAnswer { get; set; }

        protected Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }


        public abstract void addQuestion();

        public override string ToString()
        {
            return $"Header :{Header}  ,Mark :{Mark} ,Body :{Body}";
        }
    }
}
