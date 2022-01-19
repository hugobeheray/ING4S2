namespace lab2
{
    public class Worker : Employee2
    {
        private string DateOFEntry;
        private int SMIG = 2500;

        public Worker(string matricule, string firstname, string lastname, string dateOfBirth, string dateOFEntry) : base(matricule, firstname, lastname, dateOfBirth)
        {
            DateOFEntry = dateOFEntry;
        }

        public override string ToString()
        {
            return base.ToString() + " " + DateOFEntry + " " + SMIG;
        }

        public override int GetSalary()
        {
            int salary = 0;
            salary = SMIG + (2022 - Int32.Parse(DateOFEntry)) * 100;
            if (salary > SMIG * 2)
            {
                return salary;
            }
            else return 0;
        }

    }
}