namespace lab1
{
    public class Ex3P3
    {

        public void print2dimArray()
        {
            int row = 5;
            int column = 5;
            int nb = 1;
            int[,] arr = new int[row, column];

            for (row = 0; row < 5; row++)
            {
                for (column = 0; column < 5; column++)
                {
                    arr[row, column] = nb;
                    nb++;
                }
            }
            for (row = 0; row < 4; row++)
            {
                for (column = 0; column < 4; column++)
                {
                    Console.WriteLine(arr[row, column]);
                }
            }
        }
    }
}