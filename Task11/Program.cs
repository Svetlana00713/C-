//Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 999);
Console.WriteLine($"Ваше случайное число: {number}");

int furst = number/100;
int last = number%10;

Console.Write($"Число: {furst}{last}");
