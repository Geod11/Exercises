using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class BubbleSort
    {
        public List<int> BubbleSortNumbers (List<int> numbers)
        {         
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 1; j < numbers.Count - i; j++)
                {
                    if (numbers[j] < numbers[j-1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j-1];
                        numbers[j-1] = temp;
                    }
                }
            }
            return numbers;
        }

        public static List<string> BubbleSortWords (List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 1; j < words.Count - i; j++)
                {
                    if (words[j].CompareTo(words[j-1]) < 0)
                    {
                        string temp = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = temp;
                    }
                }
            }
            return words;
        }
    }
}
