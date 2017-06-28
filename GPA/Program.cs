using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figure Out Your GPA!");
            Console.WriteLine("Please answer just a few quick questions.");

            Console.WriteLine("How many Classes did you have?");
            double classes = double.Parse(Console.ReadLine());

            Console.WriteLine("In many classes did you recieve an A");
            int As = int.Parse(Console.ReadLine()) * 4;

            Console.WriteLine("In many classes did you recieve a B");
            int Bs = int.Parse(Console.ReadLine()) * 3;

            Console.WriteLine("In many classes did you recieve a C");
            int Cs = int.Parse(Console.ReadLine()) * 2;

            Console.WriteLine("In many classes did you recieve a D");
            int Ds = int.Parse(Console.ReadLine()) * 1;

            Console.WriteLine("In many classes did you recieve a F");
            int Fs = int.Parse(Console.ReadLine()) * 0;

            double gpa = ((As + Bs + Cs + Ds + Fs) / classes);
            Console.WriteLine("Your current GPA is {0}", gpa);

    

        }
    }
}
