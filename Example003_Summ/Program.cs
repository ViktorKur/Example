//Вычисление суммы чисел введеных из терминала
Console.WriteLine("Введите 1е число?");
int festNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число?");
int SecNum =  Convert.ToInt32(Console.ReadLine());
int Summ = festNum+SecNum;
Console.WriteLine("{0} + {1} = {2}", festNum, SecNum, Summ);