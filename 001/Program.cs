//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    Console.WriteLine("Большее число: " + num2);
    Console.WriteLine("Меньшее число: " + num1);
}
else if (num2 == max)
{
        Console.WriteLine("Числа равны");

}
else
{
    Console.WriteLine("Большее число: " + num1);
    Console.WriteLine("Меньшее число: " + num2);
}