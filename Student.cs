using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Student
    {
        private Person _person;
        private Education _education;
        private int _group;
        private Exam[] _exams;

        public Student(Person person, Education education, int group)
        {
            _person = person;
            _education = education;
            _group = group;
        }

        public Student():this(person:new Person(),education:Education.Bachelor,group:101)
        {
            _exams = new Exam[] { new Exam(), new Exam("Programming", 5, new DateOnly(2021, 6, 3)) };

        }

        public Person Students
        {
            get
            {
                return _person;
            }

            init
            {
                _person = value;
            }

        }

        public Education Educate
        {
            get
            {
                return _education;
            }

            init
            {
                _education = value;
            }
        }

        public int Group
        {
            get
            {
                return _group;
            }

            init
            {
                _group = value;
            }
        }

        public Exam[] Exams
        {
            get
            {
                return _exams;
            }

            set
            {
                _exams = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                double average = 0;
                if (Exams == null || Exams.Length == 0) return 0;
                foreach(Exam exam in Exams){
                    average += exam.Grade;
                }
                return average / Exams.Length;
            }
        }

        public bool this[Education educate]
        {
            get
            {
                return educate==Educate;
            }
        }

        public void AddExams(Exam[] new_exams)
        {

            Exam[] newExams = new Exam[Exams.Length + new_exams.Length];
            int i = -1, j=0;
            while (j < Exams.Length)
            {
                newExams[++i] = Exams[j];
                j++;
            }

            j = 0;
            while(j < new_exams.Length)
            {
                newExams[++i] = new_exams[j];
                j++;
            }

            Exams = newExams;
                
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

      
            foreach(Exam ex in Exams)
            {

                sb.Append(ex);

            }

            return $"Info about student:\n{Students}\nEducation: {Educate}\nGroup: {Group}\nList exams:\n\n{sb}\n";
        }

        public string ToShortString()
        {
            return $"Info about student:\n{Students}\nEducation: {Educate}\nGroup: {Group}\nAverage grade: {AverageGrade}\n";
        }
    }
}
