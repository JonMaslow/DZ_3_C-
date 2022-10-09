/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void GetNumber (int number)
{  
    if (number >= 1)
    {   
        Console.Write($"\nТаблица кубов чисел от 1 до {number}:\n");
        for (int i = 1; i <= number; i++)    
        {
            double square = Math.Pow(i,3);
            Console.Write($" {square}");
        }
    }
    else
    Console.WriteLine("Введите валидное число, больше 1");
    
}
Console.WriteLine("\nВведите число больше 1, чтобы получить таблицу кубов предыдущих чисел:\n");
GetNumber(int.Parse(Console.ReadLine()??""));