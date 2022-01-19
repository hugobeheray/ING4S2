namespace Assignment
{
    public class Item
    {
        protected string Code;
        protected string Designation;
        protected double Price;
        protected string Category;



        public void setCode(string code)
        {
            this.Code = code;
        }

        public void setDesignation(string des)
        {
            this.Designation = des;
        }

        public void setPrice(double price)
        {
            try
            {
                this.Price = price;
            }
            catch (System.Exception ex) // not implemented
            {
                System.Console.WriteLine();
            }
        }

        public void setCategory(string cat)
        {
            this.Category = cat;
        }

        public string getCode()
        {
            return this.Code;
        }

        public string getDesignation()
        {
            return this.Designation;
        }

        public virtual double getPrice()
        {
            return this.Price;
        }

        public string getCategory()
        {
            return this.Category;
        }

        public Item()
        {

        }

        public virtual int getDiscount()
        {
            return 0;
        }

        public Item(string code, string designation, double price, string category) //  param Constructor
        {
            this.Code = code;
            this.Designation = designation;
            this.Price = price;
            this.Category = category;
        }

        public Item(Item item) // copy constructor
        {
            this.Code = item.Code;
            this.Designation = item.Designation;
            this.Price = item.Price;
            this.Category = item.Category;
        }

        public override string ToString()
        {
            return this.Code + "; " + this.Designation + "; " + this.Price + "; " + this.Category;
        }

        public override bool Equals(object? obj) //we check if the object is an item and if all the attribute are equals
        {
            return obj is Item item &&
                   Code == item.Code &&
                   Designation == item.Designation &&
                   Price == item.Price &&
                   Category == item.Category;
        }

        [Serializable]
        class CategoryInvalidException : Exception // we created our exception
        {
            public CategoryInvalidException() { }

            public CategoryInvalidException(string category)
                : base(String.Format("Invalid category: {0}", category))
            {

            }
        }
    }
}