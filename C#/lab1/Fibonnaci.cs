namespace lab1
{
    public class Fibonnaci
    {
        public void fibonacciFunc(int nb1, int nb2, int end)
        {
            int result = 0;
            Console.Write(nb1 + " " + nb2 + " ");
            for (int i = 0; i < end; i++)
            {
                result = nb1 + nb2;
                Console.Write(result + " ");
                nb1 = nb2;
                nb2 = result;

            }
        }
    }
}