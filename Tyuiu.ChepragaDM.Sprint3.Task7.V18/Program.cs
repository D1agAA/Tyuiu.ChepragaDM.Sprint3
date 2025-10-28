using Tyuiu.ChepragaDM.Sprint3.Task7.V18.Lib;


namespace Tyuiu.ChepragaDM.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление итоговых решений по спринту                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*            2x - 3                                                       *");
            Console.WriteLine("*  f(x) = -------------- + 5                                              *");
            Console.WriteLine("*           Cos(x) + x                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с         *");
            Console.WriteLine("* шагом 1. Произвести проверку деления на ноль. При делении на ноль       *");
            Console.WriteLine("* вернуть значение 0. Значения округлить до двух знаков после запятой.    *");
            Console.WriteLine("* Значения занести в массив!                                              *");
            Console.WriteLine("*                                                                         *");




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");




            int i, i1;

            i = -5;
            i1 = 5;



            Console.WriteLine("Начало диапозона:  " + i);
            Console.WriteLine("Конец диапозона: " + i1);

            int len = ds.GetMassFunction(i, i1).Length;
            double[] res;
            res = new double[len];





            res = ds.GetMassFunction(i, i1);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("+-------------+--------------+");
            Console.WriteLine("|      X      |     f(x)     |");
            Console.WriteLine("+-------------+--------------+");

            for (int x = 0; x<=len-1; x++)
            {
                Console.WriteLine("|    {0,5:d}    |     {1,5:f2}    |", i, res[x]);
                i++;
            }
            Console.WriteLine("+-------------+--------------+");




            Console.ReadKey();
        }
    }
}


