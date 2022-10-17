/* Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using static System.Console;

Clear();
WriteLine("Введите номер строки: ");
int lines = int.Parse(ReadLine()!);
WriteLine("Введите номер столбца: ");
int columns = int.Parse(ReadLine()!);

int[,] numbers = new int[10,10];
GetArrayRandomNumbers(numbers);

if(lines > numbers.GetLength(0) || columns > numbers.GetLength(1)) {
    WriteLine("Элемент отсутсвует");
}
else{
    WriteLine($"значение элемента строки {lines} и столбца {columns} равно {numbers[lines-1,columns-1]}");
}

PrintArray(numbers);

void GetArrayRandomNumbers(int[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = new Random().Next(-100, 100 / 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}