//Задача 68: Напишите программу вычисления функуции Аккермана с помощью рекурсии для неотрицательных чисел.

Console.WriteLine("Insert a non-negative number m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberM < 0)
{
    Console.WriteLine("The number 'm' does not meet the conditions");
}
else
{
    Console.WriteLine("Insert a non-negative number n: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberN < 0)
    {
        Console.WriteLine("The number 'n' does not meet the conditions");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"A(m,n) = {A(numberM, numberN)}");
    }
}


static int A(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0) return A(numberM - 1, 1);
    else if (numberM > 0 && numberN > 0) return A(numberM - 1, A(numberM, numberN - 1));
    return A(numberM, numberN);
}