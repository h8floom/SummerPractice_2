using System;
using System.Collections.Generic;

namespace lol_kek
{
    public class QSort
    {
        public event Action<int[]> StepCompleted;
        public event Action<int> SortCompleted; // Событие для завершения сортировки

        private int[] array;
        private Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        public int StepCount { get; private set; } // Свойство для счётчика шагов

        public void StartSort(int[] array)
        {
            this.array = array;
            stack.Clear();
            stack.Push(Tuple.Create(0, array.Length - 1));
            StepCount = 0; // Сброс счётчика шагов
        }

        public bool SortStep()
        {
            if (stack.Count == 0)
            {
                SortCompleted?.Invoke(StepCount); // Вызов события при завершении сортировки
                return false;
            }

            var range = stack.Pop();
            int left = range.Item1;
            int right = range.Item2;

            if (left < right)
            {
                int pivot = Partition(array, left, right);
                stack.Push(Tuple.Create(left, pivot - 1));
                stack.Push(Tuple.Create(pivot + 1, right));
            }

            StepCount++; // Увеличение счётчика шагов
            StepCompleted?.Invoke(array);
            return stack.Count > 0;
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;

            return i + 1;
        }
    }
}
