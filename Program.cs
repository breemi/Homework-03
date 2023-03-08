// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("ввести пятизначное число ");

// string number = Console.ReadLine();

// if (number[0]==number[4] && number[1]==number[3])
// {System.Console.WriteLine("да");}
// else {
//     System.Console.WriteLine("нет");
// }



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите координату Х точки А ");
// int[] coordsA = new int[3];
// coordsA[0]=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки А ");
// coordsA[1]=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z точки А ");
// coordsA[2]=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Х точки B ");
// int[] coordsB = new int[3];
// coordsB[0]=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки А ");
// coordsB[1]=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z точки А ");
// coordsB[2]=Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt((Math.Pow(coordsB[0]-coordsA[0], 2))+(Math.Pow(coordsB[1]-coordsA[1], 2))+(Math.Pow(coordsB[2]-coordsA[2], 2)));

// System.Console.WriteLine(Math.Round(distance, 2));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("задать число ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=number; i++)
// {
//     System.Console.Write(Math.Pow(i, 3)+ ", ");
// }