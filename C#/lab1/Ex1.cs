namespace lab1
{
    public class Ex1
    {
        public void doExercice()
        {

            int calculateBill(int change, int coin)
            {
                int nbBill = change / coin;
                for (int i = 0; i < nbBill; i++)
                {
                    Console.Write(coin + " ");
                }

                int rest = change % coin;

                return rest;
            }

            int price;
            Console.WriteLine("Price ?");
            price = Convert.ToInt32(Console.ReadLine());

            int paid;
            Console.WriteLine("Paid ?");
            paid = Convert.ToInt32(Console.ReadLine());

            int change = paid - price;

            Console.Write("Your change is " + change + " : ");

            if (change >= 100)
            {
                change = calculateBill(change, 100);
            }
            if (change >= 50)
            {
                change = calculateBill(change, 50);
            }
            if (change >= 20)
            {
                change = calculateBill(change, 20);
            }
            if (change >= 10)
            {
                change = calculateBill(change, 10);
            }
            if (change >= 5)
            {
                change = calculateBill(change, 5);
            }
            if (change >= 2)
            {
                change = calculateBill(change, 2);
            }
            if (change >= 1)
            {
                calculateBill(change, 1);
            }
        }
    }
}