using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal class MCQ : Question
    {
        public override string? Header =>"MCQ";


        public MCQ(int numberOfQuestion)
        { 
            Answers= new Answer[numberOfQuestion];
        
        }
        public override void addQuestion()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("enter body");
                Body=Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(Body));
            bool flag;
            int m;
            do
            {
                Console.WriteLine("enter the mark of question");
                flag = int.TryParse(Console.ReadLine(), out m);
                
            }
            while (!flag&& m > 0);
            Mark = m;

            Console.WriteLine("enter choice of question");
            for (int i = 0; i < Answers?.Length; i++)
            {
                Answers[i] = new Answer() { Id = i + 1 };

             
                do
                {
                    Console.WriteLine($"enter choice num {i+1} ");
                    Answers[i].Text = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(Answers[i].Text));
            }

            int rightAnswerId;
           
            do
            {
                Console.WriteLine(" Enter The Right Answer Id ");
             flag=   int.TryParse(Console.ReadLine(), out rightAnswerId);

            } while (!flag && rightAnswerId>Answers?.Length  );

            RightAnswer!.Id = rightAnswerId;
            RightAnswer.Text = Answers![rightAnswerId - 1].Text;
            Console.Clear();
        }
    }
}
