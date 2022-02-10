namespace lab2
{
    public class student
    {
        string fullname;
        double avgGrade;
        int nbCourse;

        public student()
        {
        }

        public student(string fullname, double avgGrade, int nbCourse)
        {
            this.fullname = fullname;
            this.avgGrade = avgGrade;
            this.nbCourse = nbCourse;
        }

        public static void AvgChanged(double avg)
        {

        }
    }
}