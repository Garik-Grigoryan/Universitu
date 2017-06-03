using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universitu
{
    class Student
    {
        public string Name { set; get; }
        public int Cours { set; get; }
        public int Age { set; get; }
        public Student(string nm = "Vazgen",int cr = 1,int ag = 21)
        {
            Name = nm;
            Cours = cr;
            Age = ag;
        }
        public override string ToString()
        {
            return Name + "\t Cours -" + Cours + "\t Age -" + Age;
        }
    }
}
