using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART2.1
            // List<string> data = new List<string>();

            // data.Add("ROME");
            // data.Add("LONDON");
            // data.Add("NAIROBI");
            // data.Add("CALIFORNIA");
            // data.Add("ZURICH");
            // data.Add("AMSTERDAM");

            // Console.WriteLine("Enter first letter");
            // string firstLetter = Console.ReadLine();
            // Console.WriteLine("Enter last letter");
            // string lastLetter = Console.ReadLine();

            // for (var i = 0; i < data.Count; i++)
            // {
            //     if (data[i].StartsWith(firstLetter) && data[i].EndsWith(lastLetter))
            //     {
            //         Console.WriteLine(data[i]);

            //     }
            // }

            //PART2.2
            // List<int> data = new List<int>();

            // Console.WriteLine("Input the number of members on the List");
            // int input = Int32.Parse(Console.ReadLine());

            // for (int i = 0; i < input; i++)
            // {
            //     Console.WriteLine("Member " + i);
            //     int nb = Int32.Parse(Console.ReadLine());
            //     data.Add(nb);
            // }

            // Console.WriteLine("Input the value above you want to display the members of the List :");
            // int nb2 = Int32.Parse(Console.ReadLine());


            // for (var i = 0; i < data.Count; i++)
            // {
            //     if (nb2 < data[i])
            //     {
            //         Console.WriteLine(data[i]);

            //     }
            // }

            //PART2.3
            List<int> data = new List<int>();
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(1);
            data.Add(10);
            data.Add(50);
            data.Add(39);
            data.Add(45);
            data.Add(34);


            System.Console.WriteLine("The members of the list are :");
            for (var i = 0; i < data.Count; i++)
            {
                System.Console.WriteLine(data[i]);
            }

            System.Console.WriteLine("How many records you want to display ? ");
            int input = Int32.Parse(Console.ReadLine());
            data.Sort();

            for (var i = 0; i < input; i++)
            {

                System.Console.WriteLine(data[i]);
            }



        }
    }
}


