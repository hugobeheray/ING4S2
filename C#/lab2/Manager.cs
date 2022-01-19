namespace lab2
{
    public class Manager : Employee
    {
        public Manager(string firstname, string lastname, string dateOfBirth, double salary, string department) : base(firstname, lastname, dateOfBirth, salary)
        {
            this.Department = department;
        }
        protected string Department;

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine(this.Department);
        }
    }
}