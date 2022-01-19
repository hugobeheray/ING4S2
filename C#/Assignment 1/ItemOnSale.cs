namespace Assignment
{
    public class ItemOnSale : Item // the class is heriting from Item
    {
        private int Discount;

        public void setDiscount(int discount)
        {
            this.Discount = discount;
        }

        public override int getDiscount()
        {
            return this.Discount;
        }

        public ItemOnSale()
        {

        }
        public ItemOnSale(string code, string designation, double price, string category, int discount) : base(code, designation, price, category)
        {
            this.Discount = discount; // param constructor
        }

        public ItemOnSale(ItemOnSale i) : base(i)
        {
            this.Discount = i.Discount; // copy constructor
        }

        public override double getPrice() // we override the method getPrice because it is alraedy emplemented in the class item
        {
            return Price - (Price * (Discount / 100));
        }
    }
}