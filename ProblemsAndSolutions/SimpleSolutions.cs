using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemsAndSolutions
{
    //Level1 and Level2 Problem Solutions
    public class SimpleSolutions
    {
        //Fill the missing numbers
        //Input: 1,3,5,6,7,8
        //Output: 1,2,3,4,5,6,7,8
        public List<int> FillMissingNumbers(List<int> numbers)
        {
            List<int> output = new List<int>();
            for (var i = numbers.First(); i <= numbers.Last(); i++)
            {
                output.Add(i);
            }
            return output;

            //Better practice
            //return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();
        }

        //write me a function stringy that takes a size and returns a string of alternating '1s' and '0s'.
        //the string should start with a 1.
        //a string with size 6 should return :'101010'.
        //with size 4 should return : '1010'.
        //with size 12 should return : '101010101010'.
        //The size will always be positive and will only use whole numbers.

        public string Stringy(int size)
        {

            string output = "";
            for (int i = 1; i < size / 2; i++)
            {
                output += "10";
            }
            
            if (size%2 == 1)
            {
                output += '1';
            }

            return output;
        }

        //Given an array of integers, return a new array with each value doubled.
        public static int[] Maps(int[] x)
        {
            //Map method
            return x.Select(x => x * 2).ToArray();
        }

        //Given a non-empty array of integers, return the result of multiplying the values together in order.
        //public int Grow(int[] x)
        //{
        //    var ordered = x.OrderByDescending(c => c);
        //    int output = 1;
        //    foreach (var number in ordered)
        //    {
        //        output* number;
        //    }
        //    return output;
        //}




    }
}
