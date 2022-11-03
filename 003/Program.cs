// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ostatok = num % 2;
if(ostatok == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");