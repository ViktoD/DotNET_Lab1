using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Exam
    {
        private string _nameSubject;
        private int _grade;
        private DateOnly _dateExam;

        public string NameSubject
        {
            get
            {
               return _nameSubject;
            }

            set
            {
                _nameSubject = value;
            }
        }

        public int Grade
        {
            get
            {
                return _grade;
            }

            set
            {
                _grade = value;
            }
        }

        public DateOnly DateExam
        {
            get
            {
                return _dateExam;
            }

            set
            {
                _dateExam = value;
            }
        }

        public Exam(string nameSubject, int grade, DateOnly dateExam)
        {
            NameSubject = nameSubject;
            Grade = grade;
            DateExam = dateExam;
        }

        public Exam():this(nameSubject: "English language",grade:4,dateExam:new DateOnly(2020, 12, 19)) { }

        public override string ToString()
        {
            return $"\nSubject: {NameSubject}\nGrade: {Grade} \nDate exam: {DateExam}\n";
        }
    }

}
