using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int _Time, int _NumOfQuestions) : base(_Time, _NumOfQuestions)
        {
        }

        public override void CreateQuestions()
        {
            Questions = new MCQ[NumOfQuestions];
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i]=new MCQ(4);
                Questions[i].addQuestion();

            }
            Console.Clear();

        }

        public override void ShowExam()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);

                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine(Questions[i].Answers[j]);
                }
                int ans;
                bool ansFlag;
                
                    do
                    {
                        Console.WriteLine("please Enter Answer Id");
                        ansFlag = int.TryParse(Console.ReadLine(), out ans);
                    }
                    while (!ansFlag && ans is 1 or 2 or 3 or 4);
               
                Questions[i].UserAnswer.Id = ans;
                Questions[i].UserAnswer.Text = Questions[i].Answers[ans - 1].Text;
            }
            Console.Clear();

            Console.WriteLine("Right Answers");

            for (int i = 0; i < Questions?.Length; i++)
            {
                Console.WriteLine($"Question Number {i + 1} : {Questions[i].Body}");

                Console.WriteLine($"Right Answer : {Questions[i].RightAnswer.Text}");

            }

        }
    }
}
