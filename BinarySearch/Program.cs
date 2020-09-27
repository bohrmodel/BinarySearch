using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BinarySearch
{
    class Program
    {


        static int binary(int[] array, int desired)
        {
            int first = 0;
            int end = array.Length - 1;

            int midIndex = (int )Math.Ceiling((double)(first + end) / 2.0); //Taking the midIndex, we round up for selecting midIndex. 
            int tempMidPoint = -1;

            while (true)
            {
                if (array[midIndex] == desired)
                {
                    return midIndex;
                }

                else if (array[midIndex] < desired)
                {
                    first = midIndex + 1;
                }

                else if (array[midIndex] > desired)
                {
                    end = midIndex - 1;
                }

                tempMidPoint = (int)Math.Ceiling((double)(first + end) / 2.0);
                if (midIndex == tempMidPoint)
                {
                    break; // If the midIndex gets repeated, that means there is no index that matches the desired int, thus, -1 should be returned. Thus, we break the while loop.
                }
                else
                {
                    midIndex = tempMidPoint;
                }

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = {  6,7,8,9,10 };
            int desired = 6;
            Console.WriteLine("Hello World!");
            Console.WriteLine(binary(array, desired));
            Console.WriteLine(Math.Ceiling(2.0));
        }
    }
}
