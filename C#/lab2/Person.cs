namespace lab2
{
    public class Person
    {
        public Person(string firstname, string lastname, string dateOfBirth)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.DateOfBirth = dateOfBirth;
        }
        protected string Firstname;
        protected string Lastname;
        protected string DateOfBirth;

        public virtual void Display()
        {
            System.Console.WriteLine(this.Firstname);
            System.Console.WriteLine(this.Lastname);
            System.Console.WriteLine(this.DateOfBirth);
        }


    }
}