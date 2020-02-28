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
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(5);
            numbers.Add(15);
            CustomList<int> numbers2 = new CustomList<int>();
            numbers2.Add(10);
            numbers2.Add(20);

            CustomList<int> answer = new CustomList<int>();
            answer.Zip(numbers, numbers2);
            Console.WriteLine(answer);

            Console.ReadLine();



            

            
        }
    }
}
