// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// РЕШЕНИЕ:

// Console.WriteLine("Введите количество строк массива: ");
// int gorizont = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int vertical = int.Parse(Console.ReadLine()!);
// double[,] array = GetArray (gorizont, vertical, -10, 10);
// PrintArray(array);

// double[,] GetArray(int m, int n, int min, int max){
//     double[,] result = new double[m, n];
//     for(int i = 0; i < m; i++ ){
//         for(int j = 0; j < n; j++){
//             result[i, j] = new Random().NextDouble()*(max-min);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray){
//     for(int i = 0; i < inArray.GetLength(0); i++){
//         for(int j = 0; j < inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// __________________________________________________________________________________________________________________________________________________
// Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// РЕШЕНИЕ:

// Console.WriteLine("Введите количество строк массива: ");
// int gorizont = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int vertical = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray (gorizont, vertical, 0, 10);
// PrintArray(array);
// Console.WriteLine("Введите значение элемента: ");

// int element = int.Parse(Console.ReadLine()!);
// if(FindElement(array, element)!){
//     Console.WriteLine("Элемент найден");
// }
// else{
//     Console.WriteLine("Элемент не найден");
// }
// int[,] GetArray(int n, int m, int min, int max){
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(min, max+1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray){
//     for(int i = 0; i < inArray.GetLength(0); i++){
//         for(int j = 0; j < inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// bool FindElement(int[,] array, int element){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(array[i, j]==element) return true;
//         }
//     }
//     return false;
// }

// __________________________________________________________________________________________________________________________________________________
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// РЕШЕНИЕ:

// Console.WriteLine("Введите количество строк массива: ");
// int gorizont = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов массива: ");
// int vertical = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray (gorizont, vertical, 0, 10);
// PrintArray(array);
// double[] averageVertical = GetResultArray(array);
// Console.WriteLine($"Среднее значение столбцов = {String.Join("; ",averageVertical)} ");

// int [,] GetArray(int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for(int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(min, max +1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray){
//     for( int i = 0; i < inArray.GetLength(0); i++){
//         for( int j = 0; j < inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] GetResultArray(int[,] array){
//     double[] result = new double[array.GetLength(1)];
//     for(int i = 0; i < array.GetLength(1); i++){
//         double sum = 0;
//         for( int j = 0; j < array.GetLength(0); j++){
//             sum = array[j,i];
//         }
//         result[i] = Math.Round(sum/array.GetLength(0),2);
//     }
//     return result;
// }
// __________________________________________________________________________________________________________________________________________________