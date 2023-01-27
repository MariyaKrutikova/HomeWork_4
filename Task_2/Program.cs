/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber (string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены некорректные данные. Повторите ввод.");
        }
    }
    return Math.Abs(result);
}


int GetDigit(int number)
{
    string text = number.ToString();
    int count = text.Length;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum  = sum + Int32.Parse(text[i].ToString());
    }
    return sum;
}

int number = GetNumber("Введите число: "); 
int sum = GetDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} составляет {sum}");


 
