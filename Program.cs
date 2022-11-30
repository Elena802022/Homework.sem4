//1. Напишите цикл, который принимает на вход 2 числа (А и B) и возводит числа в натуральную степень B.
/*
Console.WriteLine("Enter a number: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} to the power of {B} = {Pow(A,B)}");

int Pow(int num, int rank)
{
if (B == 0) return 1;
int result = num;
for (int i = 2; i<=rank; i++)
{
    result*=num; 
}
return result;
}
*/
//2. Напищите программу, которая принимает на вход число N и выводит сумму цифр этого числа.
/*
Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits is = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number>0)
    {
        sum=sum+number%10;
        number=number/10;
    }
    return sum;

}
*/
//3. Создать массив из 8 элементов, который выводится на экран.
/*
int [] array = GetRandomArray(8,0,100);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i<size; i++)
    {
        result [i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}
*/
