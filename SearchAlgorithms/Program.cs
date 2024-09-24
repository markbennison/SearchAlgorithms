/* *************************************************************************** *
 * *************************************************************************** *
 *       __  ___           __       ____                   _                   *
 *      /  |/  /___ ______/ /__    / __ )___  ____  ____  (_)________  ____    *
 *     / /|_/ / __ `/ ___/ //_/   / __  / _ \/ __ \/ __ \/ / ___/ __ \/ __ \   *
 *    / /  / / /_/ / /  / ,<     / /_/ /  __/ / / / / / / (__  ) /_/ / / / /   *
 *   /_/  /_/\__,_/_/  /_/|_|   /_____/\___/_/ /_/_/ /_/_/____/\____/_/ /_/    *
 *                                                                             *
 * *************************************************************************** *
 * *************************************************************************** */

namespace SearchAlgorithms
{
    internal class Program
    {
        static Random randomGenerator = new Random();
        static Decimal milliseconds; 

        static void Main(string[] args)
        {
            List<double> listOfDoubles = new List<double>();

            PopulateListWithRandomDoubles(ref listOfDoubles, 10000000);
            //PrintList(listOfDoubles);

            RequestSearch(listOfDoubles);
            //PrintList(listOfDoubles);

            Console.ReadKey();
        }

        static Decimal GetMilliseconds()
        {
            return DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        static void RequestSearch(List<double> list)
        {
            Double searchValue;
            Console.WriteLine("What value would you like to search for? ");

            if (Double.TryParse(Console.ReadLine(), out searchValue))
            {
                milliseconds = GetMilliseconds();
                //int index = LinearSearch.Perform(searchValue, list);
                int index = BinarySearch.Perform(searchValue, list);
                milliseconds = GetMilliseconds() - milliseconds;
                Console.WriteLine("Time: " + milliseconds.ToString());

                if (index < 0)
                {
                    Console.WriteLine("NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Found at: " + index);
                }
            }
        }

        static void PopulateListWithRandomDoubles(ref List<double> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                double twoDigitDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00000"));
                list.Add(twoDigitDouble);
            }

            list.Sort();
        }

        static void PrintList(List<double> list)
        {
            Console.WriteLine("\n\nLIST PRINT:\n");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("  " + list[i].ToString());
            }

            Console.WriteLine("\nEND \n");
        }
    }
}
