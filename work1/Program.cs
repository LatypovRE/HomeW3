/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = (number % 10); //последнее
int num2 = (number / 10000); //первое
int num3 = (number / 1000) % 10; //число 2
int num4 = (number / 10) % 10; //число 4

if(num1==num2 && num3==num4)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
} 
