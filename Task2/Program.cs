// Задача 2. Напишите программу, которая принимает на вход
// трёхзначное число и производит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры:
// 487 ⇒ 8^7 = 2 097 152
// 254 ⇒ 5^4 = 625
// 617 ⇒ 1^7 = 1

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int middleDigit = number / 10 % 10;
    int rightDigit = number % 10;
    int power = 1;
    
    for ( ; rightDigit > 0; rightDigit--)
    {
        // middleDigit *= middleDigit  - однако такой вариант не подходит, 
        // потому что в таком случае при каждой иттерации будет изменяться и число
        // если сначала это будет 7, потом 7*7, а дальше это будет 49 * 49. Поэтому
        // Для хранения результата целесообразно вывести отдельную переменную (power = 1)
        // *= - это middleDigit = middleDigit * middleDigit
        power *= middleDigit;
    }
    System.Console.WriteLine(power);
    // Так же может быть такой вариант, когда переменная задаётся внутри цикла:
    // for (int rightDigit = number % 10; rightDigit > 0; rightDigit--)
}
else
{
    System.Console.WriteLine("Число НЕ трёхзначное !!!");
}