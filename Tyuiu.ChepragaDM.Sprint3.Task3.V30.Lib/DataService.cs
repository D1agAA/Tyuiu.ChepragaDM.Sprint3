using System;
using System.Reflection;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChepragaDM.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            
            int count = 1;
            int index = 0;
            int maxCount = 1;
            foreach (char c in value)
            {
                if (index == 0)
                {
                    index++;
                    continue;
                }

                if (c == value[index - 1])
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else
                {
                    count = 1;
                }

                index++;
            }

            return maxCount;
        }
    }

}
        

