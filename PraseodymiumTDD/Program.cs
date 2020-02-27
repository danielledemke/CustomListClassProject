using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> numberStrings = new CustomList<string>();
            numberStrings.Add("7");
            numberStrings.Add("27");
            CustomList<string> strings = new CustomList<string>();
            strings.Add("Hello");
            strings.Add("What is up man?!");

            CustomList<string> answer = new CustomList<string>();
            answer = numberStrings + strings;

            Console.WriteLine(answer);
            Console.WriteLine();
            Console.ReadLine();



            

            
        }
    }
}
