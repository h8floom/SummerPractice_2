using System;
using System.Drawing; 
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace lol_kek
{
    public partial class Form1 : Form
    {
        Deque deque = new Deque();
        int[] array = new int[10];
        QSort qSort = new QSort();
        Timer sortTimer = new Timer();
        Label labelStepCount = new Label(); 

        public Form1()
        {
            InitializeComponent();
            qSort.StepCompleted += OnSortStepCompleted;
            qSort.SortCompleted += OnSortCompleted;
            sortTimer.Interval = 1000; 
            sortTimer.Tick += OnSortStep;

            // Инициализация Label для вывода количества шагов
            labelStepCount.AutoSize = true;
            labelStepCount.Location = new Point(10, 200);
            this.Controls.Add(labelStepCount);
        }

        private void buttonAddFront_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value1 = random.Next(1, 100);
            deque.AddFront(value1);
            MessageBox.Show($"Added {value1} to front.");
            UpdateTextBox();
        }

        private void buttonAddBack_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1, 100);
            deque.AddBack(value);
            MessageBox.Show($"Added {value} to back.");
            UpdateTextBox();
        }

        private void buttonRemoveFront_Click(object sender, EventArgs e)
        {
            try
            {
                deque.RemoveFront();
                MessageBox.Show($"Removed from front.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateTextBox();
        }

        private void buttonRemoveBack_Click(object sender, EventArgs e)
        {
            try
            {
                deque.RemoveBack();
                MessageBox.Show($"Removed from back.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            textBoxDeque.Text = deque.ToString();
        }

        private void buttonFillArray_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            UpdateArrayTextBox();
        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            qSort.StartSort(array);
            sortTimer.Start();
            
        }

        private void OnSortStepCompleted(int[] array)
        {
            UpdateArrayAfterSortTextBox();
        }

        private void OnSortStep(object sender, EventArgs e)
        {
            if (!qSort.SortStep())
            {
                sortTimer.Stop();

                MessageBox.Show($"Sort completed in {qSort.StepCount} steps.");
            }
            labelSteps.Text = $"Steps: {qSort.StepCount}";

        }

        private void OnSortCompleted(int steps)
        {
            MessageBox.Show($"Sort completed in {steps} steps.");
        }

        private void UpdateArrayTextBox()
        {
            textBoxArrayBeforeSort.Text = string.Join(", ", array);
        }

        private void UpdateArrayAfterSortTextBox()
        {
            textBoxArrayAfterSort.Text = string.Join(", ", array);
        }

        private int[,] adjacencyMatrix;
        private List<int> dfsResult;

        private void DisplayDFSResult()
        {
            // Отображение матрицы
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)
                {
                    Label labelValue = new Label();
                    labelValue.Text = adjacencyMatrix[i, j].ToString();
                    labelValue.AutoSize = true;
                    labelValue.Location = new Point(50 + j * 22, i * 22 + 2);
                    panelDFS.Controls.Add(labelValue);
                }
            }

            Label labelResult = new Label();
            labelResult.Text = "Результат обхода в глубину:";
            labelResult.AutoSize = true;
            labelResult.Location = new Point(40, adjacencyMatrix.GetLength(0) * 22 + 2);
            panelDFS.Controls.Add(labelResult);

            // Отображение результата DFS
            for (int i = 0; i < dfsResult.Count; i++)
            {
                Label labelVertex = new Label();
                labelVertex.Text = dfsResult[i].ToString();
                labelVertex.AutoSize = true;
                labelVertex.Location = new Point(50 + i * 22, adjacencyMatrix.GetLength(0) * 22 + 22);
                panelDFS.Controls.Add(labelVertex);
            }
        }

        private void buttonStartBFS_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[,]
            {        /*A*/ /*B*/ /*C*/ /*D*/
                /*A*/{ 0,    1 ,   0 ,   1 },
                /*B*/{ 1 ,   0 ,   1 ,   0 },
                /*C*/{ 0 ,   1 ,   0 ,   0 },
                /*D*/{ 1  ,  0 ,   0 ,   0 },
            };

            DFS dfs = new DFS(adjacencyMatrix);
            dfsResult = dfs.DepthFirstSearch(0);

            DisplayDFSResult();
        }
    }
}
