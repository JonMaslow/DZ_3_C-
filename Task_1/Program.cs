/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

void GetNumber(string numN)
{
    if (int.Parse(numN) >= 10000 && int.Parse(numN) < 100000)
    {
        if (numN[0] == numN[4])
        {
            if (numN[1] == numN[3])
                Console.Write($"\nЧисло {numN} является палиндромом");
        }
        else
            Console.Write($"\nЧисло {numN} НЕ является палиндромом");
    }
    else
        Console.WriteLine("\nВведите валидное пятизначное число");
}
Console.Write("\nВведите пятизначное число для проверки палиндромности: ");
GetNumber(Console.ReadLine() ?? "");
