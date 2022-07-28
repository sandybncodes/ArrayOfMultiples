using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare vars and set random values
            int startNumber = 7, length = 5, aux = startNumber; // store the firts number value in an auxiliar var

            // declare vector of type int
            int[] listOfNumbers = new int[length];

            // for loop
            for(int i = 0; i < listOfNumbers.Length; i++)
            {
                listOfNumbers[i] = startNumber; // save number in declared vector
                startNumber = startNumber + aux; // increment the start number
            }

            // print the Array Of Multiples
            // expected result: [7 14 21 28 35]
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                Console.Write(listOfNumbers[i] + " ");
            }

            Console.ReadLine(); // click to close
        }
    }
}
