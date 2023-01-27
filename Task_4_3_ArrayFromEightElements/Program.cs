/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

// int GetArray(string message)
// {
//     int result = 0;
//     Console.WriteLine(message);
//     while(true)
//     {
//         string number = Console.ReadLine();
//         if (int.TryParse(number, out result) & number.Length == 8)
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели некорректные данные. Повторите ввод.");
//         }
//     }
//     return result;
// }


int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < 8; i++)
{
    arr[i] = rnd.Next(0,10);
}
Console.WriteLine(string.Join(", ", arr));