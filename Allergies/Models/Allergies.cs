using System;
namespace Allergies.Models
{
    public class AllergiesClass
    {
        public static int CalculateScore(bool[] inputarray)
        {
            int total = 0;
            for(int i=0; i< inputarray.Length; i++)
            {
                if(inputarray[i] == true)
                {
                    total+= (int)Math.Pow((double)2, (double)i);
                }
            }
            return total;
        }
    }
}