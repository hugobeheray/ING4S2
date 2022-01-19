namespace Assignment
{
    public class Purchase
    {
        private Item Item;
        private int Quantity;
        private string Code;

        public void setQuantity(int q)
        {
            this.Quantity = q;
        }

        public void setItem(Item i)
        {
            this.Item = i;
        }

        public void setCode(string c)
        {
            this.Code = c;
        }

        public Item getItem()
        {
            return this.Item;
        }

        public int getQuantity()
        {
            return this.Quantity;
        }

        public string getCode()
        {
            return this.Code;
        }


        public Purchase() // default constructor
        {
        }

        public Purchase(Item i, int quantity, string code) //param constructor
        {
            Item = i;
            Quantity = quantity;
            Code = code;
        }

        public Purchase(Purchase p) //copy constructor
        {
            this.Item = p.Item;
            this.Quantity = p.Quantity;
            this.Code = p.Code;
        }

        public bool CompareTo(Object? obj) //we compare the object to see if it is a purchase and if the othe attribute are equals
        {
            return obj is Purchase p &&
                   Item == p.Item &&
                   Quantity == p.Quantity;
        }
    }
}