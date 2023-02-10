//Вычисление суммы чисел введеных из терминала
Console.WriteLine("Введите 1е число?");
int festNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число?");
int SecNum =  Convert.ToInt32(Console.ReadLine());
int Summ = festNum+SecNum;
Console.WriteLine("{0} + {1} = {2}", festNum, SecNum, Summ);
// Вычисление суммы дву случайных чисел из заданного пользователм интервала 
Console.WriteLine("Введите интервал для генерации случайного числа от - до");
Console.WriteLine("Введите начальное число?"); int nach = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число?"); int kon = Convert.ToInt32(Console.ReadLine());
int festNum1 = new Random().Next(nach, kon);
int SecNum1 = new Random().Next(nach, kon);
int Summ1 = festNum1+SecNum1;
Console.WriteLine("Сумма случайных чисел: {0} + {1} = {2}", festNum1, SecNum1, Summ1);
