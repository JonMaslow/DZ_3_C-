/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetCoordinete(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную координату!\n");
    }
    return result;
}

int xa = GetCoordinete("\nВведите координату X точки А:");
int ya = GetCoordinete("\nВведите координату Y точки А:");
int za = GetCoordinete("\nВведите координату Z точки А:");
int xb = GetCoordinete("\nВведите координату X точки B:");
int yb = GetCoordinete("\nВведите координату Y точки B:");
int zb = GetCoordinete("\nВведите координату Z точки B:");

void DistanceBetweenPoints()
{
    double distanceAB = Math.Sqrt(
        Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)
    );
    Console.WriteLine(
        $"\nРасстояние между точкой A с координатой ({xa}, {ya}, {za})\n и точкой B с координатой ({xb}, {yb}, {za}) будет равно {distanceAB}\n"
    );
}

DistanceBetweenPoints();
