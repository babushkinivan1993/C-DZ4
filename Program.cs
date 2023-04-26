// Task1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// int Construction(int a, int b)
// {
//     int result = Convert.ToInt32(Math.Pow(a,b));
//     return result;
// }
// Console.WriteLine("Please enter the number being erected");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please enter the degree to which you want to raise the number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a} to the extent of {b} is {Construction(a,b)}");

// Task2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int Summ(int number)
// {
//     int ost = 0;
//     int result = 0;
//     while (number>10)
//     {
//         ost = number%10;
//         number = number/10;
//         result = result+ost;
//     }
// result = result+number;
// return result;
// }
// Console.WriteLine("Please enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The sum of the digits of the number is " + Summ(number));

// Task3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] EnterArray (int size)
// {
//     int[] array = new int [size];

//     for(int i = 0; i<size; i++)
//     {
//         Console.WriteLine($"Please enter the {i+1}' element of massiv");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for(int i=0; i<array.Length;i++)
//     {
//         Console.Write(" " + array[i]+ " ");
//     }
// }
// int[] array = EnterArray(8);
// ShowArray(array);
