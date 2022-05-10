using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanCodingTest
{
    public class MaximumOutput
    {
       

        public int findMaxValuesStolen(int[] arr)
        { 
            int output;
            int n = arr.Length;
            if (n == 0)
                return 0;
            if (n == 1)
                return arr[0];
            if (n!=2)
            {

                int val1 = arr[0];
                int val2 = Math.Max(arr[0], arr[1]);
                int i = 2;

                do
                {
                    output = Math.Max((arr[i] + val1), val2);
                    val1 = val2;
                    val2 = output;
                    i++;

                } while (i < n);

                return output;
            }
            else
            {
                return Math.Max(arr[0], arr[1]);
            }
        }
    }
}
