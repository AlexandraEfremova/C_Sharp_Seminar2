// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа
// Примеры:
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    // Ишем первую цифру
    int leftDigit = number / 100;
    // Ищем вторую циру
    int rightDigit = number % 10;
    int result = leftDigit * 10 + rightDigit;
    // Склеиваем значения
    // System.Console.WriteLine(leftDigit + "" + rightDigit);
    System.Console.WriteLine(result);  
}
else
{
    Console.WriteLine("Число НЕ трёхзначное!!!");
}