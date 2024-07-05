using System;
using System.Windows.Forms;
using lol_kek.practice_2;
using Timer = System.Windows.Forms.Timer;

namespace lol_kek
{
    public partial class Form1 : Form
    {
        Deque deque = new Deque();
        int[] array = new int[10];
        QSort qSort = new QSort();
        Timer sortTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            qSort.StepCompleted += OnSortStepCompleted;
            sortTimer.Interval = 1000; // (1 �������)
            sortTimer.Tick += OnSortStep;
        }

        private void buttonAddFront_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value1 = random.Next(1, 100);
            deque.AddFront(value1);
            MessageBox.Show($"��������� {value1} � ������.");
            UpdateTextBox();
        }

        private void buttonAddBack_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1, 100);
            deque.AddBack(value);
            MessageBox.Show($"��������� {value} � �����.");
            UpdateTextBox();
        }

        private void buttonRemoveFront_Click(object sender, EventArgs e)
        {
            try
            {
                deque.RemoveFront();
                MessageBox.Show($"������� �� ������.");
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
                MessageBox.Show($"������� �� ������.");
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
            }
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
        private List<int> bfsResult;

        private void DisplayBFSResult()
        {

            // ��������� ������� 
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)
                {
                    Label labelValue = new Label();
                    labelValue.Text = adjacencyMatrix[i, j].ToString();
                    labelValue.AutoSize = true;
                    labelValue.Location = new Point(50 + j * 22, i * 22 + 2);
                    panelBFS.Controls.Add(labelValue);
                }
            }

            Label labelResult = new Label();
            labelResult.Text = "��������� ������ ����� � ������:";
            labelResult.AutoSize = true;
            labelResult.Location = new Point(40, adjacencyMatrix.GetLength(0) * 22 + 2);
            panelBFS.Controls.Add(labelResult);

            // ��������� ���������� BFS
            for (int i = 0; i < bfsResult.Count; i++)
            {
                Label labelVertex = new Label();
                labelVertex.Text = bfsResult[i].ToString();
                labelVertex.AutoSize = true;
                labelVertex.Location = new Point(50 + i * 22, adjacencyMatrix.GetLength(0) * 22 + 22);
                panelBFS.Controls.Add(labelVertex);
            }
        }

        private void buttonStartBFS_Click(object sender, EventArgs e)
        {
            adjacencyMatrix = new int[,]
            {
            {0, 0, 0, 1, 0},
            {0, 1, 0, 0, 0},
            {1, 0, 0, 1, 1},
            {1, 0, 0, 0, 1},
            {0, 0, 1, 1, 0},

            };

            BFS bfs = new BFS(adjacencyMatrix);
            bfsResult = bfs.BreadthFirstSearch(0); // ������� ����� � 0 �������

            DisplayBFSResult();
        }
    }
}