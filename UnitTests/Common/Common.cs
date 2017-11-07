using System;

namespace UnitTests
{
    public class Common
    {
        /// <summary>
        /// Method return array with random integer elements with fixed length
        /// </summary>
        /// <param name="amount">length of array</param>
        /// <returns>Array with randomg integer values</returns>
        public int[] GetRandomArray(int amount, int leftBoundary, int rightBoundary)
        {
            Random random = new Random();
            int[] array = new int[amount];
            try
            {
                for (int i = 0; i < amount; i++)
                {
                    array[i] = random.Next(leftBoundary, rightBoundary);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); return null; }

            return array;
        }
    }
}
