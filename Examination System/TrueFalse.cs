using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal class TrueFalse : Question
    {
        public override string? Header => "True or False";

        public TrueFalse()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }
        public override void addQuestion()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("enter body");
                Body = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(Body));
            bool flag;
            int m;
            do
            {
                Console.WriteLine("enter the mark of question");
                flag = int.TryParse(Console.ReadLine(), out m);

            }
            while (!flag && m>0);
            Mark = m;
            int rightAnswerId;

            do
            {
                Console.WriteLine(" Enter The Right Answer 1 True | 2 False ");
                flag = int.TryParse(Console.ReadLine(), out rightAnswerId);

            } while (!flag && rightAnswerId is 1 or 2);

            RightAnswer!.Id = rightAnswerId;
            RightAnswer.Text = Answers![rightAnswerId - 1].Text;
            Console.Clear();

        }
    }
}
