using Tyuiu.ChepragaDM.Sprint3.Task6.V16.Lib;


namespace Tyuiu.ChepragaDM.Sprint3.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [5, 16] количество всех делителей                     *");
            Console.WriteLine("*                                                                         *");
           



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");




            int i, i1;
            
            i = 5;
            i1 = 16;
           

            
            Console.WriteLine("Начало отрезка:  " + i);
            Console.WriteLine("Конец отрезка: " + i1);
            








            double res = ds.GetSumTheDivisors(i, i1);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}