// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2*number2 || number1 * number1 == number2)
{
Console.Write("Да");
}
else
{
Console.Write("Нет");
}