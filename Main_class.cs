using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab1
{
    internal class Main_class
    {


        public static void Main(string[] args)
        {
            //1)
            WriteLine("---------------------------------------");
            WriteLine("1)\n");
            Student student = new Student();
            WriteLine(student.ToShortString());
            WriteLine("---------------------------------------");

            //2)
            WriteLine("---------------------------------------");
            WriteLine("2)\n");
            WriteLine(student[Education.Master]);
            WriteLine(student[Education.Bachelor]);
            WriteLine(student[Education.SecondEducation]);
            WriteLine("---------------------------------------");

            //3)
            WriteLine("3)\n");
            student = new Student() { Students = new Person("Oleh", "Petrenko", new DateOnly(2003, 10, 30)), Educate = Education.SecondEducation, Group = 202, Exams = new Exam[] { new Exam("Math", 4, new DateOnly(2021, 6, 8)), new Exam(), new Exam("Python", 5, new DateOnly(2021, 12, 8)) } };
            WriteLine(student);
            WriteLine("---------------------------------------");


            //4)
            WriteLine("---------------------------------------");
            WriteLine("4)\n");
            Exam[] exams = new Exam[] { new Exam("C#", 5, new DateOnly(2022, 06, 11)), new Exam("Computer graphic",4,new DateOnly(2021,6,6)) };
            student.AddExams(exams);
            WriteLine(student);
            WriteLine("---------------------------------------");


            //5)
            WriteLine("---------------------------------------");
            WriteLine("5)\n");
            WriteLine("Enter nRows and nColumns. Split this numbers symbols ,;");
            string str = Console.ReadLine();

            string[] numbers = str.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int nRows = Convert.ToInt32(numbers[0]);
            int nColumns = Convert.ToInt32(numbers[1]);


            Exam[] One_masiv = new Exam[nRows * nColumns];
            for (int i = 0; i < nRows * nColumns; i++) One_masiv[i] = new Exam();

            Exam[][] Two_masiv = new Exam[nRows][];
            for(int i = 0; i < nRows; i++)
            {
                Two_masiv[i] = new Exam[nColumns];
                for(int j = 0; j < nColumns; j++)
                {
                    Two_masiv[i][j] = new Exam();
                }
            }

            int start, end;
            int count = 0;
            int sum = (nRows / 2) * (nRows - 1);

            if(sum < nRows * nColumns)
            {
                Exam[][] Jagged_masiv = new Exam[nRows + 1][];
                
                for(int i = 0; i<=nRows; i++)
                {   ++count;
                    Jagged_masiv[i] = new Exam[count];
                    for(int j = 0; j < count; j++)
                    {
                        Jagged_masiv[i][j] = new Exam();
                    }
                }
            
                start = Environment.TickCount;
                for (int i = 0; i <= Jagged_masiv.Length-1; i++)
                {
             
                    for (int j = 0; j < Jagged_masiv[i].Length; j++)
                    {
                        Jagged_masiv[i][j].Grade = 5;

                    }

                }
                end = Environment.TickCount;
                WriteLine($"Execution time for jagged masiv: {end - start} ms");
                
            }

            else
            {
                Exam[][] Jagged_masiv = new Exam[nRows][];

                for (int i = 0; i < nRows; i++)
                {
                    ++count;
                    Jagged_masiv[i] = new Exam[count];
                    for (int j = 0; j < count; j++)
                    {
                        Jagged_masiv[i][j] = new Exam();
                    }
                }
             
                start = Environment.TickCount;
                for (int i = 0; i < Jagged_masiv.Length-1; i++)
                {
                   
                    for (int j = 0; j < Jagged_masiv[i].Length; j++)
                    {
                        Jagged_masiv[i][j].Grade = 5;

                    }

                }
                end = Environment.TickCount;
                WriteLine($"Execution time for jagged masiv: {end - start} ms");
               
            }

            start = Environment.TickCount;
            for (int i = 0; i < One_masiv.Length; i++) One_masiv[i].Grade = 5;
            end = Environment.TickCount;
            WriteLine($"Execution time for one_dimension masiv: {end-start} ms");

            start = Environment.TickCount;
            for(int i = 0; i < Two_masiv.Length; i++)
            {
                for (int j = 0; j < Two_masiv[i].Length; j++)
                {
                    Two_masiv[i][j].Grade = 5;
                }
            }
            end = Environment.TickCount;
            WriteLine($"Execution time for two_dimension masiv: {end - start} ms");
            WriteLine("---------------------------------------");


        }

    }
}
