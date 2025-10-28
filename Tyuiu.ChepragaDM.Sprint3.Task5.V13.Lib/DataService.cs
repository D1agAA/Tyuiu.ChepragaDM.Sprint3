﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChepragaDM.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    res = res + (Math.Cos(x) + (j/2.0));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
