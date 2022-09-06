//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
 
 Console.WriteLine("Введите число больше 10: ");
 try {
    String? a = Console.ReadLine();
    Console.WriteLine(secondChar(a));
 } catch (Exception e) {
    Console.WriteLine("Введите число");
 }

String secondChar(String? number){
    if (number != null && number.Length >= 2) {
        return number.ToString().Substring(1,1);
    } else {
        return "Число меньше 10";
    }
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число больше 99: ");
 try {
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(threeChar(a.ToString()));
 } catch (Exception e) {
    Console.WriteLine("Введите число");
 }

String threeChar(String? number){
    if (number != null && number.Length >= 3) {
        return number.ToString().Substring(2,1);
    } else {
        return "третьей цифры нет";
    }
} 

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число число недели: ");
try {
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(checkNumberDayWeek(a));
 } catch (Exception e) {
    Console.WriteLine("Введите число");
 }
String checkNumberDayWeek(int numberWeekDay){
        if (numberWeekDay == 6 || numberWeekDay == 7) {
            return "Да";
        } else {
            return "Нет";
        }
}