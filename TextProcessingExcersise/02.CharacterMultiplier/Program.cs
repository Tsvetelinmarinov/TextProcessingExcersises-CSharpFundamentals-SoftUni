/// <summary>
///  02.CharacterMultiplier
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine()!
                .Split()
                .ToList();

            Console.WriteLine(CombinedCharsSum(names[0], names[1]));
        }

        private static float CombinedCharsSum(string fString, string sString)
        {
            float sum = default;
            string longer = fString.Length > sString.Length ? fString : sString;
            string shorter = fString.Length > sString.Length ? sString : fString;
            
            for (int i = 0; i < longer.Length; ++i)
            {
                if (i <= shorter.Length - 1)
                {
                    sum += longer[i] * shorter[i];
                }
                else
                {
                    sum += longer[i];
                }
            }

            return sum;
        }
    }
}
