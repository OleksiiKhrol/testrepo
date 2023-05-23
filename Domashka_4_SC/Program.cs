using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arrayN = new int[n];
        int j = 0, k = 0;
        int indexA = 0, indexB = 0;

        for (int i = 0; i < arrayN.Length; i++)
        {
            arrayN[i] = new Random().Next(1, 27);
        }

        int[] arrayAnumbers = new int[n]; // массив для четных номеров
        int[] arrayBnumbers = new int[n]; // массив для не четных номеров
        char[] arrayA = new char[n];
        char[] arrayB = new char[n];
        for (int i = 0; i < arrayN.Length; i++)
        {
            if (arrayN[i] % 2 == 0)
            {
                arrayAnumbers[indexA] = arrayN[i];
                indexA++;
            }
            else
            {
                arrayBnumbers[indexB] = arrayN[i];
                indexB++;
            }
        }

        Array.Resize(ref arrayAnumbers, indexA); // изменяем размер массивов, убирая пустые элементы
        Array.Resize(ref arrayBnumbers, indexB);

        for (int i = 0; i < arrayAnumbers.Length; i++) // заменяем цифры в массивах на маленькие буквы, используя кодировку ASCII
        {
            char letter = (char)(arrayAnumbers[i] + 96);
            if (letter == 'a' | letter == 'e' | letter == 'i' | letter == 'd' | letter == 'h' | letter == 'j') // Замена на заглавные
            {
                char letterBig = char.ToUpper(letter);
                arrayA[i] = letterBig;
                j++;
            }
            else
            {
                arrayA[i] = letter;
            }
        }

        for (int i = 0; i < arrayBnumbers.Length; i++)
        {
            char letter = (char)(arrayBnumbers[i] + 96);
            if (letter == 'a' || letter == 'e' | letter == 'e' | letter == 'd' | letter == 'h' | letter == 'j')
            {
                char letterBig = char.ToUpper(letter);
                arrayB[i] = letterBig;
                k++;
            }
            else
            {
                arrayB[i] = letter;
            }
        }

        if (j > k) // выводим на экран массив с бОльшим количеством заглавных букв
        {
            Console.Write("В массиве \"А\" больше заглавных букв: ");
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write(arrayA[i] + " ");
            }
        }
        else if (j == k)
        {
            Console.Write("В массивах \"А\" и \"B\" одинаковое количество заглавных букв");
        }
        else
        {
            Console.Write("В массиве \"B\" больше заглавных букв: ");
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write(arrayB[i] + " ");
            }
        }

        Console.WriteLine();
        Console.Write("Массив \"А\": "); // Выводим на экран массив А
        for (int i = 0; i < arrayA.Length; i++)
        {
            Console.Write(arrayA[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Массив \"B\": "); // Выводим на экран массив B
        for (int i = 0; i < arrayB.Length; i++)
        {
            Console.Write(arrayB[i] + " ");
        }

        Console.ReadKey();
    }
}



