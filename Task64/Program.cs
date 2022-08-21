// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа кратные 3-ём в промежутке от M до N.
//M = 1; N = 9. -> "3, 6, 9"
//M = 13; N = 20. -> "15, 18"

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
        Console.WriteLine("Natural numbers are multiples of three: ");
        MultiplesOf3(numberM, numberN);
        Console.WriteLine("\b\b. ");
    }
}

void MultiplesOf3(int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberM % 3 == 0)
    {
        Console.Write(numberM + ", ");
    }
    numberM++;
    MultiplesOf3(numberM, numberN);
}
