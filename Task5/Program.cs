// Задача 5. Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет
// Пример:
// 456 ⇒ 6
// 7812 ⇒ 1
// 91 ⇒ Третьей цифры нет

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
        // /= - аналог number = number /10
        number /= 10; 
    
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет!");
}