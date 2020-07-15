using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = {-11, 12, -42, 0, 1, 90, 68, 6, -9};
            SelectionSort.Sort(integerValues);
            System.Console.WriteLine(string.Join(" | ", integerValues));

            string[] stringValues = {"Mary", "Marcin", "Ann", "James", "George", "Nicole"};
            SelectionSort.Sort(stringValues);
            System.Console.WriteLine(string.Join(" | ", stringValues));

            System.Console.WriteLine("O(n^2) complexity");
        }
    }

    public static class SelectionSort
    {
        // T is generic Type
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];

                for(int j = i + 1; j <array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                        System.Console.WriteLine(minIndex);
                        System.Console.WriteLine(minValue);
                    }
                }
                Swap(array, i, minIndex);
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
