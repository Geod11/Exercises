using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 333, 111, 777, 555, 222, 999, 444, 666, 888 };
            List<string> words = new List<string>() { "Zion", "basketball", "Korn", "Asparagus", "cubism", "iPhone", "Market" };

            Console.WriteLine("Bubble Sort Algorithm for a list of Numbers in action: ");
            BubbleSort BS = new BubbleSort();
            BS.BubbleSortNumbers(numbers);
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Bubble Sort Algorithm for a list of Words in action: ");
            BubbleSort.BubbleSortWords(words);
            foreach (var item in words)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
