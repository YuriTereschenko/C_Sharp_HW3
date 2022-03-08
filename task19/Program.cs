/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

int[] array = new int[5];
Console.WriteLine("Введите 5ти значное число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = array.Length - 1; i >= 0; i-- ) //преобразуем число в массив
{
    array[i]= number % 10;
    number /= 10;
}

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}