using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovik
{
    public partial class Form1 : Form
    {
        private DirectedGraph _graph;
        private Graphics _graphics;
        private const int NodeRadius = 20;
        private const int NodeSpacing = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateGraph_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что поле ввода не пустое
                if (string.IsNullOrWhiteSpace(txtVertices.Text))
                {
                    throw new ArgumentException("Сначала введите количество вершин");
                }

                // Пытаемся преобразовать ввод в число
                if (!int.TryParse(txtVertices.Text, out int vertices))
                {
                    throw new FormatException("Введите положительное число");
                }

                // Проверяем, что число положительное и не больше 9
                if (vertices <= 0)
                {
                    throw new ArgumentOutOfRangeException("Введите положительное число");
                }

                if (vertices > 9)
                {
                    throw new ArgumentOutOfRangeException("Слишком большое число, введите число меньше 9");
                }

                // Создаем граф
                _graph = new DirectedGraph(vertices);
                MessageBox.Show($"Граф с {vertices} вершинами создан.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawGraph();
                panel1.Visible = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Недопустимое значение: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка формата: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка ввода: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Обработка других непредвиденных исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEdge_Click_1(object sender, EventArgs e)
        {
            if (_graph == null)
            {
                MessageBox.Show("Сначала создайте граф.");
                return;
            }

            // Считываем ребро из текстового поля
            var edgeInput = txtEdge.Text.Split(',');
            if (edgeInput.Length == 2 &&
                int.TryParse(edgeInput[0], out int start) &&
                int.TryParse(edgeInput[1], out int end))
            {
                
                if (start >= 0 && start < _graph.GetVertexCount() && end >= 0 && end < _graph.GetVertexCount())
                {
                    _graph.AddEdge(start, end);
                    MessageBox.Show($"Ребро {start} -> {end} добавлено.", "Успех!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DrawGraph();
                }
                else
                {
                    MessageBox.Show("Вершины должны быть в пределах количества вершин графа.", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите ребро в формате: начальная,конечная (например: 1,2).", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            if (_graph == null)
            {
                MessageBox.Show("Сначала создайте граф.");
                return;
            }

            try
            {
                var sorter = new TopologicalSorter(_graph);
                var order = sorter.Sort();
                txtResult.Text = "Топологическая сортировка: " + string.Join(", ", order);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения сортировки: " + ex.Message);
            }
        }
        private void DrawGraph()
{
    if (_graphics == null)
    {
        _graphics = pictureBox1.CreateGraphics();
    }

    _graphics.Clear(Color.White);

    var nodeCount = _graph.GetVertexCount();
    var nodeDistance = pictureBox1.Width / (nodeCount + 1);

    // Определяем уровни
    var levelY = new int[]
    {
        pictureBox1.Height / 4,   // Верхний уровень
        pictureBox1.Height / 2,   // Центральный уровень
        3 * pictureBox1.Height / 4 // Нижний уровень
    };

    for (int i = 0; i < nodeCount; i++)
    {
        // Определяем координаты вершины
        var nodeX = nodeDistance * (i + 1);
        var nodeY = levelY[i % 3]; // Распределяем вершины по уровням (0 - верхний, 1 - центральный, 2 - нижний)

        // Рисуем вершину
        _graphics.FillEllipse(Brushes.Black, nodeX - NodeRadius, nodeY - NodeRadius, NodeRadius * 2, NodeRadius * 2);

                // Рисуем номер вершины
                _graphics.DrawString(i.ToString(), new Font("Arial", 12), Brushes.White, nodeX - NodeRadius / 2, nodeY - NodeRadius / 2);

                // Рисуем ребра
                var neighbors = _graph.GetAdjacencyList()[i];
        foreach (var neighbor in neighbors)
        {
            // Определяем координаты соседней вершины
            var neighborX = nodeDistance * (neighbor.Value + 1);
            var neighborY = levelY[neighbor.Value % 3];

            // Рисуем линию
            _graphics.DrawLine(Pens.Black, nodeX, nodeY, neighborX, neighborY);
        }
    }
}
    }

}

