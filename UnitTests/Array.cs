using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    public class Array
    {
        /// <summary>
        /// Method compare 2 arrays and get common elemnts in both arrays
        /// </summary>
        /// <param name="array1">Array 1</param>
        /// <param name="array2">Array 2</param>
        /// <returns>Result array with commmon elements</returns>
        public int[] GetCommonElemets1(int[] array1, int[] array2)
        {
            List<int> resultList = new List<int>();
            if (array1 == null || array2 == null) { Console.WriteLine("One of the arrays is null."); return resultList.ToArray(); }
            try
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            resultList.Add(array1[i]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultList.ToArray();
        }

        /// <summary>
        /// Method for getting common elements of arrays. More fast and stable solusion on LINQ technology built.
        /// </summary>
        /// <param name="array1">Array 1</param>
        /// <param name="array2">Array 2</param>
        /// <returns>Result array with commmon elements</returns>
        public int[] GetCommonElemets2(int[] array1, int[] array2)
        {
            List<int> resultList = new List<int>();
            if (array1 == null || array2 == null) { Console.WriteLine("One of the arrays is null."); return resultList.ToArray(); }
            try
            {
               resultList = array1.Intersect(array2).ToList() ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return resultList.ToArray();
        }
    }
}
