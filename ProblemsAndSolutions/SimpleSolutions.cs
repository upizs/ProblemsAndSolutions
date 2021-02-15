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






    }
}
