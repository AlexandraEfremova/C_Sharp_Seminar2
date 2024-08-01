// Задача 3.  Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число
// квадратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры:
// 14, 5 ⇒ нет, 4
// 16, 8 ⇒ да
// 4, 3 ⇒ нет, 1

System.Console.WriteLine("Введите первое число");
int firstValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondValue = Convert.ToInt32(Console.ReadLine());

// Если при делении первого числа на второе мы в остатке получаем ноль, значит оно кратно
if (firstValue % secondValue == 0)
{
    System.Console.WriteLine($"{firstValue}, {secondValue} => Да");
}
else
{
    // В данном случае используем форматированную строку для вывода инфы
    System.Console.WriteLine($"{firstValue}, {secondValue} => Нет, {firstValue % secondValue}");
}