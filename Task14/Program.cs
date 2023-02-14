// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}