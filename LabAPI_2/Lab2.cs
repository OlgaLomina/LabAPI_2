using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAPI_2
{
    public class Lab2
    {
        /// <summary>
        /// smoosh() takes an array of ints.  On completion the array contains   
        /// the same numbers, but wherever the array had two or more consecutive
        /// duplicate numbers, they are replaced by one copy of the number.Hence,   
        /// after smoosh() is done, no two consecutive numbers in the array are the   
        /// same.
        /// 
        /// Any unused elements at the end of the array are set to -1.   
        ///  
        /// For example, if the input array is [ 0 0 0 0 1 1 0 0 0 3 3 3 1 1 0 ],   
        /// it reads[0 1 0 3 1 0 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1 - 1] after smoosh()
        /// completes.
        /// </summary>
        /// <param name="ints">the input array</param>
        public static void Smoosh(int[] ints)
        {
            int i = 0, j = 0, len;
            len = ints.Length;
            while (j < ints.Length-1)
            {
                j++;
                if (ints[i] == ints[j])
                {
                    len--;
                }
                else
                {
                    i++;
                    ints[i] = ints[j];
                }
            }

            for(int k = len; k < ints.Length; k++)
            {
                ints[k] = -1;
            }
            foreach (int l in ints)
            {
                Console.Write("{0} ", l);
            }
            


        }

    }

}
