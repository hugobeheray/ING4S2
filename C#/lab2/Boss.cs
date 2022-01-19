namespace lab2
{
    public class Boss : Employee2
    {
        private int percentage;
        private int turnover;

        public Boss(string matricule, string firstname, string lastname, string date, int percentage, int turnover) : base(matricule, firstname, lastname, date)
        {
            this.percentage = percentage;
            this.turnover = turnover;
        }

        public override string ToString()
        {
            return base.ToString() + " " + percentage + " " + turnover;
        }

        public override int GetSalary()
        {
            int salary = 0;
            return salary = turnover * percentage / 100;
        }
    }
}