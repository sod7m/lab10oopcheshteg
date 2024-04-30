using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10oop
{
    public class Matrix
    {
        private int[,] matrix; // Двовимірний масив для зберігання матриці
        private int rows; // Кількість рядків матриці
        private int columns; // Кількість стовпців матриці

        // Конструктор класу, який приймає кількість рядків та стовпців як параметри
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns]; // Ініціалізація матриці
        }

        // Метод для генерації випадкових чисел в матриці
        public void GenerateMatrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-9, 10); // Генеруємо числа від -9 до 9
                }
            }
        }

        // Метод для перетворення матриці в рядок
        public string MatrixToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += matrix[i, j] + "\t"; // Додаємо кожне число в рядок
                }
                result += "\n"; // Додаємо новий рядок після кожного рядка матриці
            }
            return result;
        }

        // Метод для підрахунку кількості рядків, які не містять нулів
        public int CountNonZeroRows()
        {
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (!Enumerable.Range(0, columns).Any(j => matrix[i, j] == 0))
                {
                    count++; // Якщо рядок не містить нулів, збільшуємо лічильник
                }
            }
            return count;
        }

        // Метод для знаходження максимального числа, яке зустрічається більше одного разу
        public int FindMaxRepeatedNumber()
        {
            var numbers = matrix.Cast<int>().GroupBy(x => x); // Групуємо всі числа
            return numbers.Where(x => x.Count() > 1).Max(x => x.Key); // Знаходимо максимальне число, яке зустрічається більше одного разу
        }
    }
}