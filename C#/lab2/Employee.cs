namespace lab2
{
    public class Employee : Person
    {
        public Employee(string firstname, string lastname, string dateOfBirth, double salary) : base(firstname, lastname, dateOfBirth)
        {
            this.Salary = salary;
        }
        protected double Salary;

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine(this.Salary);

        }



    }
}