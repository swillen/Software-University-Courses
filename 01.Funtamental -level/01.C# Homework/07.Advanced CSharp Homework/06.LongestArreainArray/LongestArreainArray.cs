using System;
using System.Linq;
using System.Collections.Generic;
class LongestArreainArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Array [{0}] = ", i);
            array[i] = Console.ReadLine();
        }

        //Add variables for the final result
        int maxSequence = 0;
        string value = null;

        //The outer loop is rotated only once and for every index count,
        //the inner loop is comparing every element with the next one
        //(again and again till the end of array's length)

        for (int i = 0; i < array.Length; i++)
        {
            //The countSequence variable counts the lenght of equal elements, until a new element appears
            int countSequence = 0;

            //The inner one starts from the same position, like the outer loop
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    countSequence++;

                    //Check if this sequence is bigger than the maximum sequence and
                    //if true (first time, it's always true, because maxSequence = 0;)
                    //rewrites the old ones with the new counter values
                    //(counter and the current sequence element)

                    if (maxSequence < countSequence)
                    {
                        maxSequence = countSequence;
                        value = array[i];
                    }
                }
                else
                {
                    break; //break and starts again from the next index of the outer loop.
                }
            }
        }

        Console.WriteLine("\nThe element of maximal sequence is \"{0}\", repeated {1} times", value, maxSequence);
    }
}

