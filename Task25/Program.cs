// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число, которое будет возводиться в степень: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возводим? ");
int num2 = Convert.ToInt32(Console.ReadLine());


int Sum(int n1, int n2)
{
    int sum = 1;

    for (int i = 0; i < n2; i++)
    {
        sum = sum * n1;
    }
    return sum;
}
if (num == 0 && num2 == 0) Console.WriteLine("0 в степень 0? Рили?");
else Console.WriteLine($"{num} в степени {num2} = {Sum(num, num2)}");