namespace lab1
{
    public class Ex3
    {
        public void doExercice()
        {
            int size = 0;
            float mean = 0;
            int median = 0;
            Console.WriteLine("Enter the amount of Data");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + i + "]:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                mean += array[i];

            }
            mean = mean / size;
            Console.WriteLine("Mean: " + mean);

            Array.Sort(array);
            median = array[size / 2];
            Console.WriteLine("Median: " + median);
            //Console.WriteLine(array[0] + " " + array[1]);

        }
    }
}