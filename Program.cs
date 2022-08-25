//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: ");
int NumberB = int.Parse(Console.ReadLine());
int result1 = NumberB / 10;
int result2 = result1 / 10;
int result = result2 % 10;
if (NumberB < 100)
Console.WriteLine("Третьей цифры нет");   
else
Console.WriteLine($"Третья цифра {result}");
