/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. Решить задачу с использованием методов.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
try {
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите степень: ");
    int n = int.Parse(Console.ReadLine());
    natPow(a, n);
} catch (Exception e) {
    Console.Write("Ввели не правильное число");
}
void natPow(int a, int n){
    int p = a;
    for (int i = 1; i < Math.Abs(n); i++){
        p = p * a;
    }
    Console.WriteLine(p);
}
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */ 
try {
     Console.WriteLine("Введите число: ");
    int a = Math.Abs(int.Parse(Console.ReadLine()));
    getSumNumber(a);
} catch (Exception e) {
    Console.Write("Ввели не правильное число");
}

void getSumNumber(int number){
    int sum = 0;
    int num = number;
    while(num > 0){
        sum += num % 10;
        num = num / 10;
    }
    Console.WriteLine(sum);
}
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 Элементы массива вводятся пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

try {
   getArray(setArray()); 
} catch (Exception e) {
    Console.Write("Ошибка выполения операции");
}

int[] setArray(){
    int[] array = new int[8];
    for(int i = 0; i < 8; i++){
        Console.Write($"Введите {i} элемент: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
void getArray(int[] array){
    Console.Write("[");
     for(int i =0; i<= array.Length-1; i++){
       if (i != array.Length-1) {
        Console.Write(array[i]+ ", ");
       } else {
        Console.Write(array[i]);
       }
    }
    Console.Write("]");
}  