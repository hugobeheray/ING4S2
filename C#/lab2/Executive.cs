namespace lab2
{
    public class Executive : Employee2
    {
        private int index;

        public Executive(string matricule, string firstname, string lastname, string date, int index) : base(matricule, firstname, lastname, date)
        {
            this.index = index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + index;
        }

        public override int GetSalary()
        {
            int salary = 0;
            switch (index)
            {
                case 1:
                    salary = 13000;
                    break;
                case 2:
                    salary = 15000;
                    break;
                case 3:
                    salary = 17000;
                    break;
                case 4:
                    salary = 20000;
                    break;
                default:
                    break;
            }

            return salary;

        }
    }
}