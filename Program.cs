//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
if (first > second) {
    Console.WriteLine("Первое число больше второго");
} else if (first < second) {
    Console.WriteLine("Второе число больше первого");
} else {
    Console.WriteLine("Числа равны");
} 

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
int max = a;
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Третье число: ");
int c = int.Parse(Console.ReadLine());
if (max <= b) {
    max = b;
} 
if ( max <= c){
    max = c;
} 
Console.WriteLine($"Максимальное число: {max}"); 

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine("Число четное ");
} else {
    Console.WriteLine("Число нечетное ");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

while (a >= 0) {
    a--;
    if (a % 2 == 0) {
        Console.WriteLine($"{a}; ");
    }
    
}