using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int n = 0; n < array.Length; n++)
            {
                int min = array[n];
                int minIndex = n;
                for (int i = n + 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }

                (array[n], array[minIndex]) = (array[minIndex], array[n]);
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            int startIndex = 0;
            while (startIndex < array.Length)
            {
                int min = array[startIndex];
                bool isСhanged = false;
                int changeIndex = 0;
                for (int i = startIndex + 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        changeIndex = i;
                        isСhanged = true;
                    }
                }

                if (isСhanged)
                {
                    (array[startIndex], array[changeIndex]) = (array[changeIndex], array[startIndex]);
                    RecursiveSelectionSort(array);
                }

                startIndex++;
            }
        }
    }
}
