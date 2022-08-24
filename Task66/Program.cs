// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Insert a natural number 'M' greater than 0: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberM < 1)
{
    Console.WriteLine("The number 'M' does not meet the conditions. Repeat input.");
}
else
{
    Console.WriteLine("Insert a natural number 'N' greater than 0: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN < 1)
    {
        Console.WriteLine("The number 'N' does not meet the conditions. Repeat input.");
    }
    else
    {
        int sum = 0;
        Console.WriteLine("The sum of natural numbers = ");
        SumOfNaturalNumbers(numberM, numberN, sum);
    }
}

void SumOfNaturalNumbers(int numberM, int numberN, int sum)
{
    Console.WriteLine(sum);
    if (numberM > numberN) return;
    {
        sum += numberM;
    }
    numberM++;
    SumOfNaturalNumbers(numberM, numberN, sum);
}
