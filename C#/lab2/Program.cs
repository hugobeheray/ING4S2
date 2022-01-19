using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Part1

            // Vectors2D v1 = new Vectors2D(10, 10, 1);
            // Vectors2D v2 = new Vectors2D(v1);
            // Vectors3D v3 = new Vectors3D(10, 10, 10, 1);
            // Vectors3D v4 = new Vectors3D(v3);
            // Console.WriteLine(v1.ToString());
            // Console.WriteLine(v1.Equals());
            // Console.WriteLine(v1.computeNorm());
            // Console.WriteLine(v2.ToString());
            // Console.WriteLine(v2.Equals());
            // Console.WriteLine(v2.computeNorm());
            // Console.WriteLine(v3.ToString());
            // Console.WriteLine(v3.Equals());
            // Console.WriteLine(v3.computeNorm());
            // Console.WriteLine(v4.ToString());
            // Console.WriteLine(v4.Equals());
            // Console.WriteLine(v4.computeNorm());

            //Part2
            // Person p1 = new Employee("Jean", "Didier", "12/12/12", 1200);
            // Person p2 = new Employee("Stoffel", "Rattel", "11/11/11", 1250);
            // Person p3 = new Employee("Michel", "Carre", "10/10/10", 1300);
            // Person p4 = new Employee("Monique", "Douze", "09/09/09", 1350);
            // Person p5 = new Employee("Zoe", "Crouzet", "08/08/08", 1400);
            // Person p6 = new Manager("Benji", "Rattel", "03/03/03", 9000, "IT");
            // Person p7 = new Manager("Zoe", "Crouzet", "02/02/02", 9000, "IT");
            // Person p8 = new Director("Hugo", "Beheray", "01/01/01", 10000, "IT", "Bouygues Telecom");
            // ArrayList list = new ArrayList();

            // list.Add(p1);
            // list.Add(p2);
            // list.Add(p3);
            // list.Add(p4);
            // list.Add(p5);
            // list.Add(p6);
            // list.Add(p7);
            // list.Add(p8);



            // foreach (Person p in list)
            // {
            //     p.Display();
            //     System.Console.WriteLine();
            // }

            //Part3
            Worker e1 = new Worker("AAAA", "Jean", "Michel", "12/12/12", "2021");
            Executive exe = new Executive("BBBB", "Stoffel", "Rattel", "11/11/11", 2);
            Boss boss = new Boss("CCCC", "Hugo", "Beheray", "10/10/10", 50, 100);

            System.Console.WriteLine(e1.ToString());
            System.Console.WriteLine(exe.ToString());
            System.Console.WriteLine(boss.ToString());

            System.Console.WriteLine(e1.GetSalary());
            System.Console.WriteLine(exe.GetSalary());
            System.Console.WriteLine(boss.GetSalary());

        }
    }
}

