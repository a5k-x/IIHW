/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 

значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
try{
Console.Write("Введите b1 ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1 ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2 ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2 ");
double k2 = int.Parse(Console.ReadLine());
double y = getY(k1, b1, k2, b2);
double x = getX(y, b1, k1);
Console.Write($"{x};{y}");
} catch (Exception e){
    Console.Write($"Ошибка {e.Message}");
}

double getY(double k1, double b1, double k2, double b2){
    return (-k2*b1+b2*k1)/(k1-k2);
}

double getX(double y, double b1, double k1){
    return (y-b1)/k1;
}

