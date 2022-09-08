/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */

 Console.WriteLine("Введите число");
int number = Math.Abs(int.Parse(Console.ReadLine()));
if (number >= 10000 && number <= 99999) {
    Array ar = getArray(number);
    Console.WriteLine(checkPalindrom(ar));
} else {
    Console.WriteLine("Введите 5ти значное число");
}

Array getArray(int number){
   int num = number;
   int[] array = new int[5];
   for(int i = 0 ; i <= 4 ; i++){
        array[i] = num % 10;
        num = num / 10;
    }
    Array.Reverse(array);
    return array;
}

String checkPalindrom(Array a){
    int n = a.Length;
    Boolean flag = false;
    for (int i = 0; i <= n / 2; i++){
        if (a.GetValue(i).Equals(a.GetValue(n-i-1))) {
            flag = true;
        } else {
            flag = false;
            break;
        }
    }
    if (flag) {
        return "ДА";
    } else {
        return "НЕТ";
    }  
} 

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
//Формируем первый массив
int[] t1 = new int[3];
int[] t2 = new int[3];
try { 
String[] dict = {"X","Y","Z"};
for (int i = 0; i < dict.Length; i++){
    Console.WriteLine($"Введите координату {dict[i]} для первой точки");
    t1[i]= int.Parse(Console.ReadLine());      
}
for (int i = 0; i < dict.Length; i++){
    Console.WriteLine($"Введите координату {dict[i]} для второй точки");
    t2[i] = int.Parse(Console.ReadLine());
}

Console.Write(Math.Round(distance(t1,t2),2));
Double distance(int[] t1, int[] t2){
    Double x = Math.Pow((t2[0] - t1[0]),2);
    Double y = Math.Pow((t2[1] - t1[1]),2);
    Double z = Math.Pow((t2[2] - t1[2]),2);
    return Math.Sqrt(x+y+z);
}

 } catch (Exception e) {
        Console.Write("Ввели не правильное число");
    }

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
try {
    Console.WriteLine("Сколько нужно чисел ?");
int n = int.Parse(Console.ReadLine());
getPow(n);
void getPow(int n){
    for (int i = 1; i <= n; i ++){
        Double result = Math.Pow(i,3); 
        Console.Write($" {result},");  
    } 
}
} catch (Exception e) {
    Console.Write("Ввели не правильное число");
}

