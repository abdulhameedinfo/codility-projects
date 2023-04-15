using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    public class BinaryGap
    {
        public BinaryGap(int number)
        {
            var binary = Convert.ToString(number, 2);
            var gap = 0;
            var searchStartIndex = -1;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    if (searchStartIndex != -1)
                    {
                        var newGap = i - searchStartIndex - 1;

                        if (newGap > gap)
                        {
                            gap = newGap;
                        }
                    }

                    searchStartIndex = i;
                }
            }

            Console.WriteLine("Maximum gap found: " + gap);
        }
    }
}
