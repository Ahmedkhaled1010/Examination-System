using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_EXAM02
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }
        public enum typeExam
        {
            Final,
            Practical
        }

        public void createExam()
        {
            int typeOfExam, eTime, numQuestion;
            bool flag;
            do
            {
                Console.WriteLine("Please Enter The Type Of Exam 1 for Final ,2 for Practical  ");
              flag=  int.TryParse(Console.ReadLine(), out typeOfExam);
                
            }
            while (!flag&& typeOfExam is 1 or 2);

            do
            {
                Console.WriteLine("Please Enter The time  Of Exam  from (1 min  to 120 min)  ");
                flag = int.TryParse(Console.ReadLine(), out eTime);

            }
            while (!flag && eTime>=15 && eTime<=120);
            do
            {
                Console.WriteLine("Please Enter The Num Of Question  ");
                flag = int.TryParse(Console.ReadLine(), out numQuestion);

            }
            while (!flag && numQuestion>0);
            if (typeOfExam==1)
            {
                Exam = new FinalExam(eTime,numQuestion);
            }
            else
            {
                Exam=new PracticalExam(eTime,numQuestion);
            }
            Console.Clear();

            Exam.CreateQuestions();

        }
    }
}
