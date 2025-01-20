using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumOfQuestions) : base(_Time, _NumOfQuestions)
        {
        }

        public override void CreateQuestions()
        {
            Questions=new Question[NumOfQuestions];
            for (int i = 0; i < Questions.Length; i++)
            {
                int choice;
                bool flag;
                do
                {
                    Console.WriteLine("choose the type of question 1 Mcq or 2 (True or  False)");
                    flag=int.TryParse(Console.ReadLine(), out choice);
                }
                while (!flag && choice is 1 or 2 or 3);
                Console.Clear();

                if (choice == 1)
                {
                    Questions[i] = new MCQ(4);
                    Questions[i].addQuestion();
                }
                else
                {
                    Questions[i] = new TrueFalse();
                    Questions[i].addQuestion();
                }
            }

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
                if (Questions[i]?.GetType() == typeof(MCQ))
                {
                    do
                    {
                        Console.WriteLine("please Enter Answer Id");
                        ansFlag = int.TryParse(Console.ReadLine(), out ans);
                    }
                    while (!ansFlag && ans is 1 or 2 or 3 or 4);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("please Enter Answer Id (1 For True or 2 For False)");
                        ansFlag = int.TryParse(Console.ReadLine(), out ans);
                    }
                    while (!ansFlag && ans is 1 or 2);
                    
                }
                Questions[i].UserAnswer.Id = ans;
                Questions[i].UserAnswer.Text = Questions[i].Answers[ans - 1].Text;
            }
            Console.Clear();

            int degree = 0, totalMarks = 0;

            for (int i = 0; i < Questions?.Length; i++)
            {
                totalMarks += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id == Questions[i].RightAnswer.Id)
                {
                    degree += Questions[i].Mark;
                }

                Console.WriteLine($"Question {i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {Questions[i].UserAnswer.Text}");
                Console.WriteLine($"Right Answer => {Questions[i].RightAnswer.Text}");
            }

            Console.WriteLine($"Your Degree Is {degree} From {totalMarks}");
        }
    }
}
    