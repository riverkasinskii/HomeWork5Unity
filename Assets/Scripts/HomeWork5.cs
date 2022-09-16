using System;
using System.Linq;
using UnityEngine;

public class HomeWork5 : MonoBehaviour
{
    /// <summary>
    /// Метод обработки события OnClick кнопки "Сумма четных чисел заданного диапазона"
    /// </summary>
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        int want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
    }

    /// <summary>
    /// Метод вычисляет сумму четных чисел в заданном диапазоне
    /// </summary>
    /// <param name="min">Минимальное значение диапазона</param>
    /// <param name="max">Максимальное значение диапазона</param>
    /// <returns>Сумма чисел четных чисел</returns>
    private int SumEvenNumbersInRange(int min, int max)
    {
        int got = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                got += i;
            }            
        }        
        return got;
    }
    /// <summary>
    /// Метод обработки события OnClick кнопки "Сумма четных чисел в заданном массиве"
    /// </summary>
    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат неверный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }

    /// <summary>
    /// Метод вычисляет сумму четных чисел в массиве
    /// </summary>
    /// <param name="array">Исходный массив чисел</param>
    /// <returns>Сумма чисел четных чисел</returns>
    private int SumEvenNumbersInArray(int[] array)
    {
        int got = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                got += array[i];
            }
        }
        return got;
    }
    /// <summary>
    /// Метод обработки события OnClick кнопки "Поиск первого вхождения числа в массив"
    /// </summary>
    public void OnFirstOccurrence()
    {
        // Первый тест, число присутствует в массиве
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? $"Результат верный, число {value} есть в массиве"
            : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс числа {value} в массиве: {got} - {message}");

        // Второй тест, число не присутствует в массиве
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        value = 55;
        want = -1;
        got = FirstOccurrence(array, value);
        message = want == got ? $"Результат верный, числа {value} нет в массиве"
            : $"Результат неверный, ожидается {want}";
        Debug.Log($"Индекс числа {value} в массиве: {got} - {message}");
    }

    /// <summary>
    /// Метод производит поиск первого вхождения числа в массив
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="value">Искомое число</param>
    /// <returns>Индекс искомого числа в массиве или -1 если число отсутствует</returns>
    private int FirstOccurrence(int[] array, int value)
    {        
        for (int i = 0; i < array.Length; i++)
        {
            if (value == array[i])
            {                
                return i;
            }
        }
        return -1;
    }

    /// <summary>
	/// Метод обработки события OnClick кнопки "Сортировка выбором"
	/// </summary>
	public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
    }

    /// <summary>
    /// Метод сортировки выбором
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    private int[] SelectionSort(int[] array)
    {
        int minIndex;
        for (int i = 0; i < array.Length; i++)
        {
            minIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[minIndex] > array[j])
                {
                    minIndex = j;
                }
            }
            if (array[minIndex] == array[i])
            {
                continue;
            }
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
        return array;
    }

}
