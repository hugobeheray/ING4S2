namespace lab2
{
    public abstract class Employee2
    {
        protected string Matricule;
        protected string Firstname;
        protected string Lastname;
        protected string DateOfBirth;

        protected Employee2(string matricule, string firstname, string lastname, string dateOfBirth)
        {
            Matricule = matricule;
            Firstname = firstname;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
        }

        public virtual new string ToString()
        {
            return " " + Matricule + " " + Firstname + " " + Lastname + " " + DateOfBirth;
        }
        public abstract int GetSalary();
    }
}