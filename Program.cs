using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace practical_number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logical logical = new Logical();
            logical.AddStudent("j", "f", "f");
            logical.AddStudent("jf", "ff", "ff");
            Console.WriteLine(logical.GetAll());
            Console.ReadKey();
        }
    }
}
