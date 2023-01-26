/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

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
    return result;
}

int FindPower (int numberA, int numberB)
{
    int PowerA = 1;
    for (int i = 1; i <= numberB; i++)
    {
        PowerA = numberA*PowerA; 
    }
    return PowerA;
}



int numberA = GetNumber("Введите число А: ");
int numberB = GetNumber("Введите число B: ");
int resultpower = FindPower(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} будет {resultpower}");