using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Universitu
{
    class University
    {
        private static Random rd = new Random();
        private static String[] name = { "Hrach", "Vlad", "Elen", "Gor", "Anna", "Meri" };
        List<Student> student = new List<Student>();
        internal List<Student> SList
        {
            get => student;
            set => student = value;
        }

        public University(int n = 7)
        {
            for (int i = 0; i < n; i++)
            {
                string nm = name[rd.Next(name.Length)];
                int ag = rd.Next(16, 30);
                int cr = rd.Next(1, 4);
                Student stu = new Student(nm, cr, ag);
                student.Add(stu); 
            }
        }
        public int Count
        {
            get => student.Count;
        }
        public Student this[int i]
        {
            get => student[i];
            set => student[i] = value;
        }

        public Student this[string s]
        {
            get
            {
                for(int i = 0; i < student.Count; i++)
                {
                    if(student[i].Name == s)
                    {
                        return student[i];
                    }
                }
                throw new Exception(s + " not found");
            }
            set
            {
                for(int i = 0; i < student.Count; i++)
                {
                    if (student[i].Name == s) student[i] = value;
                    
                }
                throw new Exception(s + " Not Found");
            }
        }


        public IEnumerable GetEnum(bool b)
        {
            if (b)
            {
                for(int i = 0; i < student.Count; i++)
                {
                    yield return student[i];
                }
            }
            else
            {
                for(int i = student.Count - 1; i>=0;i--)
                {
                    yield return student[i];
                }
            }
        }
    }
}
