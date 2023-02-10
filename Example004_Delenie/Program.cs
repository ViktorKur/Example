// Деление целочисленных и вещественных чисел
Console.WriteLine ("Ведите делимое число?");
int numA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите делитель?");
int numB = Convert.ToInt32 (Console.ReadLine());
int rez = numA/numB;
Console.WriteLine ("целочисленное деление: {0} / {1} = {2}", numA, numB, rez);
double rez2 = Convert.ToDouble (numA) / Convert.ToDouble (numB);
Console.WriteLine ("вещественное деление: {0} / {1} = {2}", numA, numB, rez2);