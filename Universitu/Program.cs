using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Universitu
{
    class Program
    {
        static void Main(string[] args)
        {
            University un = new University(15);
            for(int i = 0; i < un.Count; i++)
            {
                Console.WriteLine(un[i]);
            }
            Console.WriteLine("////////////////////////");
            foreach(Student a in un.GetEnum(true))
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("////////////////////////");
            
            Console.WriteLine("Do you want search element? press Enter");
            while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Write name");
                string sn = Console.ReadLine();
                Console.WriteLine(un[sn]);
            }

        }
    }
}
