using Tyuiu.ChepragaDM.Sprint3.Task3.V30.Lib;


namespace Tyuiu.ChepragaDM.Sprint3.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чепрага Д. М. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Чепрага Дмитрий Максимович | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh       *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            
            char x = 'y';
            Console.WriteLine("Искомый символ: " + x);

            string y = "fyyklbtyn ygrc vfyyyyh";
            Console.WriteLine("Строка: " + y);






            double res = ds.GetMaxCharCount(y, x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}