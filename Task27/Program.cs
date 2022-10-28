// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = default;

int ArrCount(int n)
{

    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}
int arrcount = ArrCount(num);

int[] arr = new int[arrcount];

int ArrMade(int n)
{
    int counter = 1;
    int sum = default;
    for (int i = 0; i < arrcount; i++)
    {
        arr[i] = (n / counter) % 10;
        //Console.Write($"{arr[i]}  ");
        counter *= 10;
        sum = sum + arr[i];
    }
    return sum;

}
System.Console.WriteLine($"{ArrMade(num)}");