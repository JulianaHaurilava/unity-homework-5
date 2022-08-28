using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public void SumOfEvenNumbers()
    {
        int sum = 0;
        for (int i = 7; i < 22; i++)
            if (i % 2 == 0)
            {
                sum += i;
            }
        Debug.Log($"Сумма четных чисел в диапазоне от 7 до 21 равна {sum}");
    }

    public void SumOfEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int sum = 0;

        foreach (int digit in array)
        {
            if (digit % 2 == 0)
            {
                sum += digit;
            }
        }
        Debug.Log($"Сумма четных чисел массива равна {sum}");
    }

    public void FindDigit()
    {
        int[] array_1 = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int[] array_2 = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };

        int digit_1 = 34, digit_2 = 55;

        Debug.Log($"Индекс первого вхождения числа {digit_1} в первый массив: {Array.IndexOf(array_1, digit_1)}");
        Debug.Log($"Индекс первого вхождения числа {digit_2} в первый массив: {Array.IndexOf(array_2, digit_2)}");
    }

    public void SelectionSort()
    {
        int[] array = { 6, 8, 3, 5, 9, 10, 7, 2, 4, 1 };
        string outputArray = "";
        foreach (int digit in array)
        {
            outputArray += $"{digit} ";
        }
        Debug.Log("Первоначальный массив:\n" +
                  outputArray);

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            int stakan = array[i];
            array[i] = array[min];
            array[min] = stakan;
        }

        outputArray = "";
        foreach (int digit in array)
        {
            outputArray += $"{digit} ";
        }
        Debug.Log("Отсортированный массив:\n" +
                  outputArray);
    }
}
