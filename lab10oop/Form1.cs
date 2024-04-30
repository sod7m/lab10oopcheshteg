using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10oop
{
    public partial class Form1 : Form
    {
        Matrix matrix;

        public Form1()
        {
            InitializeComponent();
            matrix = new Matrix(3, 5); // Створюємо прямокутну матрицю 3x5
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix.GenerateMatrix();
            label1.Text = matrix.MatrixToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nonZeroRows = matrix.CountNonZeroRows();
            int maxRepeatedNumber = matrix.FindMaxRepeatedNumber();
            label2.Text = $"Кількість рядків, які не містять нульових елементів: {nonZeroRows}\nМаксимальне число, яке зустрічається більше одного разу: {maxRepeatedNumber}";
        }
    }
}