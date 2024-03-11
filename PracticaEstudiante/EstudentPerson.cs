using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEstudiante
{
    internal class EstudentPerson : Person
    {
        private string schoolid;
        public string ID
        {
            get { return schoolid; }
            set { schoolid = value; }
        }
        private string career;

        public string Career
        {
            get { return career; }
            set { career = value; }
        }

        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public EstudentPerson(string name, string motherlastname, string lastname, DateTime birthdate, string schoolid, string career, int grade) : base(name, motherlastname, lastname, birthdate)
        {
            this.schoolid = schoolid;
            this.career = career;
            this.grade = grade;

        }

        public override string ToString()
        {
            return base.ToString() + $" \n ID: {schoolid}\n Career: {career}\n Grade: {grade}";
        }



    }
}
