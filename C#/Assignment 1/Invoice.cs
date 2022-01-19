using System.Collections;
using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace Assignment
{
    public class Invoice
    {
        private int Number;
        private DateTime Date;
        private ArrayList PurchaseCollection = new ArrayList(); // arraylist of purchase

        public Invoice()
        {
        }

        public Invoice(DateTime date, ArrayList PurchaseCollection) // param constructor
        {
            this.Number = Interlocked.Increment(ref this.Number);
            this.Date = date;
            this.PurchaseCollection = PurchaseCollection;
        }

        public Invoice(Invoice i) // copy constuctor
        {
            this.Number = i.Number;
            this.Date = i.Date;
            this.PurchaseCollection = i.PurchaseCollection;
        }

        public int getNumber()
        {
            return this.Number;
        }

        public DateTime getDate()
        {
            return this.Date;
        }

        public ArrayList getPurchaseCollection()
        {
            return this.PurchaseCollection;
        }

        public void setDate(DateTime d)
        {
            this.Date = d;
        }

        public void setNumber(int n)
        {
            this.Number = n;
        }

        public void setPurchaseCollection(ArrayList pc)
        {
            this.PurchaseCollection = pc;
        }

        public void Add(Purchase a)
        {
            bool b = false;
            for (int i = 0; i < PurchaseCollection.Count; i++) // we iterate throught the whole collection 
            {
                if (a.CompareTo(PurchaseCollection[i])) // we check if the purchase exists 
                {
                    b = true;
                }
            }

            if (!b)
            {
                PurchaseCollection.Add(a);// we add it to the collection
            }
            else
            {
                System.Console.WriteLine("The purchase already exists"); //or not
            }
        }

        public double InvoiceAmount()
        {
            double amount = 0;
            foreach (Purchase p in PurchaseCollection)//iterate throught the collection
            {
                amount += p.getItem().getPrice() * p.getQuantity(); //price * quantity
            }
            return amount;
        }

        public void Save_Purchase(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Invoice));
            XmlTextWriter writer = new XmlTextWriter(filename, Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            ser.Serialize(writer, this);
            writer.Close();
        }

        public override string ToString() // format to a readable string the invoice
        {
            string str = "Invoice number " + Number + "invoice date " + Date + "\nList of purchases:\nDesignation   Discount%   Price(in Euro)  Quantity    Price Total\n";

            foreach (Purchase p in PurchaseCollection)
            {
                // if(p.getItem() is ItemOnSale)
                // {
                //     ItemOnSale item = new ItemOnSale();
                //     string discount = p.getItem().getDiscount();
                // }
                str += p.getItem().getDesignation() + "      " + p.getItem().getDiscount() + "            " + p.getItem().getPrice() + "            " + p.getQuantity() + "            " + p.getItem().getPrice() * p.getQuantity() + "\n";
            }
            str += "Invoice amount: " + InvoiceAmount();
            return str;
        }
    }
}