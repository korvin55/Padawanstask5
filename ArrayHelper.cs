using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            else if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                int count = 0;
                for (int i = 0; i < (int)source.Length / 2; i++)
                {
                    if (source[i] == source[source.Length - 1 - i])
                    {
                        count++;
                    }
                }
                if (count == (int)source.Length / 2)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
    }
}
