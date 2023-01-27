/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

float GetNumber (string message)
{
    float result = 0;
    Console.WriteLine(message);
    while (true)
    {
        if (float.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены некорректные данные. Повторите ввод.");
        }
    }
    return result;
}

int GetPower (string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены некорректные данные. Повторите ввод.");
        }
    }
    return result;
}

float FindPower(float numberA, int numberB)
{
    float PowerA = 1;
    for (int i = 1; i <= numberB; i++)
    {
        PowerA = numberA*PowerA; 
    }
    return PowerA;
}



float numberA = GetNumber("Введите число А: ");
int numberB = GetPower("Введите число B: ");
float resultpower = FindPower(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} будет {resultpower}");