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
            else
            {
                if ( source.Length % 2 != 0)
                {
                    return "No";
                }
                else
                {
                    int count = 0;
                    for ( int i = 0; i < source.Length /2; i++)
                    {
                        if ( source[i] == source[ source.Length - 1 - i])
                        {
                            count++;
                        }
                    }
                    if (count == source.Length / 2)
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
}
