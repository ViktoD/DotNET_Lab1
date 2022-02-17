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
            student = new Student() { Person = new Person("Oleh", "Petrenko", new DateOnly(2003, 10, 30)), Educate = Education.SecondEducation, Group = 202, Exams = new Exam[] { new Exam("Math", 4, new DateOnly(2021, 6, 8)), new Exam(), new Exam("Python", 5, new DateOnly(2021, 12, 8)) } };
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


            Exam[] OneMasiv = new Exam[nRows * nColumns];
            for (int i = 0; i < nRows * nColumns; i++) OneMasiv[i] = new Exam();

            Exam[][] TwoMasiv = new Exam[nRows][];
            for(int i = 0; i < nRows; i++)
            {
                TwoMasiv[i] = new Exam[nColumns];
                for(int j = 0; j < nColumns; j++)
                {
                    TwoMasiv[i][j] = new Exam();
                }
            }

            int start, end;
            int count = 0;
            int sum = (nRows / 2) * (nRows - 1);

            if(sum < nRows * nColumns)
            {
                Exam[][] JaggedMasiv = new Exam[nRows + 1][];
                
                for(int i = 0; i<=nRows; i++)
                {   ++count;
                    JaggedMasiv[i] = new Exam[count];
                    for(int j = 0; j < count; j++)
                    {
                        JaggedMasiv[i][j] = new Exam();
                    }
                }
            
                start = Environment.TickCount;
                for (int i = 0; i <= JaggedMasiv.Length-1; i++)
                {
             
                    for (int j = 0; j < JaggedMasiv[i].Length; j++)
                    {
                        JaggedMasiv[i][j].Grade = 5;

                    }

                }
                end = Environment.TickCount;
                WriteLine($"Execution time for jagged masiv: {end - start} ms");
                
            }

            else
            {
                Exam[][] JaggedMasiv = new Exam[nRows][];

                for (int i = 0; i < nRows; i++)
                {
                    ++count;
                    JaggedMasiv[i] = new Exam[count];
                    for (int j = 0; j < count; j++)
                    {
                        JaggedMasiv[i][j] = new Exam();
                    }
                }
             
                start = Environment.TickCount;
                for (int i = 0; i < JaggedMasiv.Length-1; i++)
                {
                   
                    for (int j = 0; j < JaggedMasiv[i].Length; j++)
                    {
                        JaggedMasiv[i][j].Grade = 5;

                    }

                }
                end = Environment.TickCount;
                WriteLine($"Execution time for jagged masiv: {end - start} ms");
               
            }

            start = Environment.TickCount;
            for (int i = 0; i < OneMasiv.Length; i++) OneMasiv[i].Grade = 5;
            end = Environment.TickCount;
            WriteLine($"Execution time for one dimension masiv: {end-start} ms");

            start = Environment.TickCount;
            for(int i = 0; i < TwoMasiv.Length; i++)
            {
                for (int j = 0; j < TwoMasiv[i].Length; j++)
                {
                    TwoMasiv[i][j].Grade = 5;
                }
            }
            end = Environment.TickCount;
            WriteLine($"Execution time for two dimension masiv: {end - start} ms");
            WriteLine("---------------------------------------");


        }

    }
}
