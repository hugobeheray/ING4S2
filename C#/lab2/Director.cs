namespace lab2
{
    public class Director : Manager
    {
        private string Company;

        public Director(string firstname, string lastname, string dateOfBirth, double salary, string department, string company) : base(firstname, lastname, dateOfBirth, salary, department)
        {
            this.Company = company;
        }

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine(this.Company);
        }
    }
}