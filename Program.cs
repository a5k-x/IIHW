/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*

int[] array= new int[getSizeArray()];

int getSizeArray(){
     Random rnd = new Random();
    return rnd.Next(1,10);
}

int getRandomeNumber(){
    Random rnd = new Random();
    return rnd.Next(100,999);
}

void setArrayNumbers(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = getRandomeNumber();
    }
}

int checkCountNumber(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
      if (array[i] % 2 == 0) {
        count++;
      }
    }
    return count;
}

//Знаю не красиво, но просто что бы увидеть первоночальное состояние массива, для наглядности))
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

setArrayNumbers(array);
getArray(array);
Console.Write($"Колличество четных чисел в массиве = {checkCountNumber(array)}"); 

*/

/*

Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int[] array= new int[getSizeArray()];

int getSizeArray(){
     Random rnd = new Random();
    return rnd.Next(1,10);
}

int getRandomeNumber(){
    Random rnd = new Random();
    return rnd.Next(100,999);
}

void setArrayNumbers(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = getRandomeNumber();
    }
}

int sumElement(int[] array){
    int summ = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0){
            summ += array[i];
        }
    }    
    return summ;    
}

//Знаю не красиво, но просто что бы увидеть первоночальное состояние массива, для наглядности))
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

setArrayNumbers(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sumElement(array)}" + "\n");
getArray(array); 

*/

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

/*
int[] array= new int[getSizeArray()];

int getSizeArray(){
     Random rnd = new Random();
    return rnd.Next(2,10);
}

int getRandomeNumber(){
    Random rnd = new Random();
    return rnd.Next(0,5);
}

void setArrayNumbers(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = getRandomeNumber();
    }
}

int[] multiplication(int[] array){
    int[] newArray = new int[array.Length/2];
    int multiplication = 0;
    for (int i = 0; i < array.Length/2; i++){
        multiplication = array[i] * array[array.Length-1-i];
        newArray[i] = multiplication;
    }
    return newArray;
}

void getArray(int[] array){
    Console.Write("[");
     for(int i =0; i < array.Length; i++){
       if (i != array.Length-1) {
        Console.Write(array[i]+ ", ");
       } else {
        Console.Write(array[i]);
       }
    }
    Console.Write("]"+ "\n");
}

setArrayNumbers(array);
 Console.WriteLine($"Старый массив:");
 getArray(array);
  Console.WriteLine("Новый массив:");
getArray(multiplication(array));

*/

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/*

int[] array= new int[getSizeArray()];

int getSizeArray(){
     Random rnd = new Random();
    return rnd.Next(2,10);
}

int getRandomeNumber(){
    Random rnd = new Random();
    return rnd.Next(0,5);
}

void setArrayNumbers(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = getRandomeNumber();
    }
}

//Знаю не красиво, но просто что бы увидеть первоночальное состояние массива, для наглядности))
void getArray(int[] array){
    Console.Write("[");
     for(int i =0; i<= array.Length-1; i++){
       if (i != array.Length-1) {
        Console.Write(array[i]+ ", ");
       } else {
        Console.Write(array[i]);
       }
    }
    Console.Write("]" + "\n");
}

int maxElementArray(int[] array){
    return array.Max();
}

int minElementArray(int[] array){
    return array.Min();
}

int delta(int max, int min){
    return max - min;
}

setArrayNumbers(array);
getArray(array);
int d = delta(maxElementArray(array),minElementArray(array));
Console.WriteLine($"Разница между максимальным и минимальным элементов = {d}");

*/