/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
try{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    natural(number);
}catch (Exception e){
    Console.Write($"Ошибка {e.Message}");
}

void natural(int N){
    if (N > 0){
        Console.Write($"{N}, ");
        natural(N-1);
    }
}
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
/*
try{
    Console.Write("Введите первое число: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int N = int.Parse(Console.ReadLine());
    int result = getSumm(M,N);
    Console.Write($"Сумма = {result}");
}catch (Exception e){
    Console.Write($"Ошибка {e.Message}");
}

int getSumm(int M, int N){
    int sum = 0;
    for(int i = M; i <= N; i++){
        sum += i;
    }
    return sum;
}
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
try{
    Console.Write("Введите первое положительное число: ");
    int M = int.Parse(Console.ReadLine());
    if (M < 0) {
    throw new Exception("Первое число положительное отрицательное");
    }
    Console.Write("Введите второе число: ");
    int N = int.Parse(Console.ReadLine());
    if (N < 0) {
    throw new Exception("Второе число отрицательное");
    }

    long result = getAcerman(M,N);
    Console.Write($"Число Акермана = {result}");
}catch (Exception e){
    Console.Write($"Ошибка {e.Message}");
}

long getAcerman(int M, long N){
    if (M == 0){
       return ++N;
    } else if (M > 0 && N == 0){
        return getAcerman(M-1, 1);
    } else if (M > 0 && N > 0){
        return getAcerman(M - 1, getAcerman(M, N - 1));
    } else return 1;
}

*/