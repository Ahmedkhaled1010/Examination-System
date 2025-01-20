using System.Diagnostics;
using C43_G03_EXAM02;

internal class Program
{
    private static void Main(string[] args)
    {
       Subject subject = new Subject(1, "oop");
        subject.createExam();
        Console.Clear();
        int choice;
        bool flag;
        do
        {
            Console.WriteLine("start Exam ......?  1 if yes or 2 if no");
            flag=int.TryParse(Console.ReadLine(), out choice);
        }
        while (!flag && choice is 1 or 2);
        if (choice==1)
        {
            Console.Clear();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            subject.Exam.ShowExam();
            stopwatch.Stop();
            Console.WriteLine($"Time = {stopwatch.Elapsed}");

        }

    }
}