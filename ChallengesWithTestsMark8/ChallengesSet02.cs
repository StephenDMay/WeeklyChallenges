using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0) sum += num;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var result = Sum(numbers.ToArray());
            return result % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number >= 0) ? number / 2 : 0;
        }
    }
}
