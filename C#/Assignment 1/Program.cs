using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 04, 20);
            ArrayList al = new ArrayList();
            Item item = new Item("abc", "Computer", 200, "Office Automation");
            Item ios = new ItemOnSale("abcd", "Keyboard", 50, "Computer Science", 20);
            Purchase p = new Purchase(item, 2, "dvhsjkjldkhj");
            Purchase p2 = new Purchase(ios, 3, "fhggjdhkjhjgjfshkjj");
            Invoice i = new Invoice(date, al);
            //item.ToString();
            i.Add(p); //we had a purchase in the arraylist
            i.Add(p2);
            System.Console.WriteLine(i.ToString());
            i.Save_Purchase("save.xml");

        }
    }
}
