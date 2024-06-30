namespace lol_kek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            richTextBoxDequeDescription = new RichTextBox();
            label1 = new Label();
            textBoxDeque = new TextBox();
            groupBox2 = new GroupBox();
            buttonRemoveBack = new Button();
            buttonAddBack = new Button();
            groupBox1 = new GroupBox();
            buttonRemoveFront = new Button();
            buttonAddFront = new Button();
            panel2 = new Panel();
            labelSteps = new Label();
            label3 = new Label();
            textBoxArrayAfterSort = new TextBox();
            buttonQuickSort = new Button();
            buttonFillArray = new Button();
            textBoxArrayBeforeSort = new TextBox();
            label2 = new Label();
            richTextBoxQuickSortDescription = new RichTextBox();
            panel3 = new Panel();
            buttonStartBFS = new Button();
            panelBFS = new Panel();
            label4 = new Label();
            richTextBoxBFSDescription = new RichTextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richTextBoxDequeDescription);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDeque);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 426);
            panel1.TabIndex = 0;
            // 
            // richTextBoxDequeDescription
            // 
            richTextBoxDequeDescription.Location = new Point(3, 354);
            richTextBoxDequeDescription.Name = "richTextBoxDequeDescription";
            richTextBoxDequeDescription.Size = new Size(225, 69);
            richTextBoxDequeDescription.TabIndex = 5;
            richTextBoxDequeDescription.Text = "Двусторонняя очередь (Deque) — это структура данных, которая сочетает в себе особенности стека и очереди. Она позволяет добавлять и удалять элементы как с начала, так и с конца структуры данных.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 336);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Описание";
            // 
            // textBoxDeque
            // 
            textBoxDeque.Location = new Point(6, 244);
            textBoxDeque.Multiline = true;
            textBoxDeque.Name = "textBoxDeque";
            textBoxDeque.Size = new Size(225, 69);
            textBoxDeque.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonRemoveBack);
            groupBox2.Controls.Add(buttonAddBack);
            groupBox2.Location = new Point(3, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Конец";
            // 
            // buttonRemoveBack
            // 
            buttonRemoveBack.Location = new Point(116, 34);
            buttonRemoveBack.Name = "buttonRemoveBack";
            buttonRemoveBack.Size = new Size(103, 44);
            buttonRemoveBack.TabIndex = 1;
            buttonRemoveBack.Text = "Удалить";
            buttonRemoveBack.UseVisualStyleBackColor = true;
            buttonRemoveBack.Click += buttonRemoveBack_Click;
            // 
            // buttonAddBack
            // 
            buttonAddBack.Location = new Point(6, 34);
            buttonAddBack.Name = "buttonAddBack";
            buttonAddBack.Size = new Size(94, 44);
            buttonAddBack.TabIndex = 0;
            buttonAddBack.Text = "Добавить";
            buttonAddBack.UseVisualStyleBackColor = true;
            buttonAddBack.Click += buttonAddBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonRemoveFront);
            groupBox1.Controls.Add(buttonAddFront);
            groupBox1.Location = new Point(3, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Начало";
            // 
            // buttonRemoveFront
            // 
            buttonRemoveFront.Location = new Point(116, 34);
            buttonRemoveFront.Name = "buttonRemoveFront";
            buttonRemoveFront.Size = new Size(103, 44);
            buttonRemoveFront.TabIndex = 1;
            buttonRemoveFront.Text = "Удалить";
            buttonRemoveFront.UseVisualStyleBackColor = true;
            buttonRemoveFront.Click += buttonRemoveFront_Click;
            // 
            // buttonAddFront
            // 
            buttonAddFront.Location = new Point(6, 34);
            buttonAddFront.Name = "buttonAddFront";
            buttonAddFront.Size = new Size(94, 44);
            buttonAddFront.TabIndex = 0;
            buttonAddFront.Text = "Добавить";
            buttonAddFront.UseVisualStyleBackColor = true;
            buttonAddFront.Click += buttonAddFront_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelSteps);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxArrayAfterSort);
            panel2.Controls.Add(buttonQuickSort);
            panel2.Controls.Add(buttonFillArray);
            panel2.Controls.Add(textBoxArrayBeforeSort);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(richTextBoxQuickSortDescription);
            panel2.Location = new Point(269, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 426);
            panel2.TabIndex = 1;
            // 
            // labelSteps
            // 
            labelSteps.AutoSize = true;
            labelSteps.Location = new Point(95, 252);
            labelSteps.Margin = new Padding(2, 0, 2, 0);
            labelSteps.Name = "labelSteps";
            labelSteps.Size = new Size(38, 15);
            labelSteps.TabIndex = 13;
            labelSteps.Text = "Steps:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 180);
            label3.Name = "label3";
            label3.Size = new Size(204, 15);
            label3.TabIndex = 12;
            label3.Text = "Массив после быстрой сортировки";
            // 
            // textBoxArrayAfterSort
            // 
            textBoxArrayAfterSort.Location = new Point(4, 198);
            textBoxArrayAfterSort.Name = "textBoxArrayAfterSort";
            textBoxArrayAfterSort.Size = new Size(253, 23);
            textBoxArrayAfterSort.TabIndex = 11;
            // 
            // buttonQuickSort
            // 
            buttonQuickSort.Location = new Point(80, 118);
            buttonQuickSort.Name = "buttonQuickSort";
            buttonQuickSort.Size = new Size(90, 23);
            buttonQuickSort.TabIndex = 10;
            buttonQuickSort.Text = "Сортировать";
            buttonQuickSort.UseVisualStyleBackColor = true;
            buttonQuickSort.Click += buttonQuickSort_Click;
            // 
            // buttonFillArray
            // 
            buttonFillArray.Location = new Point(61, 60);
            buttonFillArray.Name = "buttonFillArray";
            buttonFillArray.Size = new Size(131, 23);
            buttonFillArray.TabIndex = 9;
            buttonFillArray.Text = "Заполнить массив";
            buttonFillArray.UseVisualStyleBackColor = true;
            buttonFillArray.Click += buttonFillArray_Click;
            // 
            // textBoxArrayBeforeSort
            // 
            textBoxArrayBeforeSort.Location = new Point(4, 89);
            textBoxArrayBeforeSort.Name = "textBoxArrayBeforeSort";
            textBoxArrayBeforeSort.Size = new Size(253, 23);
            textBoxArrayBeforeSort.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 336);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Описание";
            // 
            // richTextBoxQuickSortDescription
            // 
            richTextBoxQuickSortDescription.Location = new Point(3, 354);
            richTextBoxQuickSortDescription.Name = "richTextBoxQuickSortDescription";
            richTextBoxQuickSortDescription.Size = new Size(253, 69);
            richTextBoxQuickSortDescription.TabIndex = 6;
            richTextBoxQuickSortDescription.Text = resources.GetString("richTextBoxQuickSortDescription.Text");
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonStartBFS);
            panel3.Controls.Add(panelBFS);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(richTextBoxBFSDescription);
            panel3.Location = new Point(531, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 426);
            panel3.TabIndex = 2;
            // 
            // buttonStartBFS
            // 
            buttonStartBFS.Location = new Point(29, 244);
            buttonStartBFS.Name = "buttonStartBFS";
            buttonStartBFS.Size = new Size(188, 36);
            buttonStartBFS.TabIndex = 10;
            buttonStartBFS.Text = "Обход графа в ширину";
            buttonStartBFS.UseVisualStyleBackColor = true;
            buttonStartBFS.Click += buttonStartBFS_Click;
            // 
            // panelBFS
            // 
            panelBFS.BorderStyle = BorderStyle.Fixed3D;
            panelBFS.Location = new Point(3, 60);
            panelBFS.Name = "panelBFS";
            panelBFS.Size = new Size(251, 161);
            panelBFS.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 336);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Описание";
            // 
            // richTextBoxBFSDescription
            // 
            richTextBoxBFSDescription.Location = new Point(3, 354);
            richTextBoxBFSDescription.Name = "richTextBoxBFSDescription";
            richTextBoxBFSDescription.Size = new Size(251, 69);
            richTextBoxBFSDescription.TabIndex = 7;
            richTextBoxBFSDescription.Text = resources.GetString("richTextBoxBFSDescription.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxDeque;
        private GroupBox groupBox2;
        private Button buttonRemoveBack;
        private Button buttonAddBack;
        private GroupBox groupBox1;
        private Button buttonRemoveFront;
        private Button buttonAddFront;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox richTextBoxDequeDescription;
        private RichTextBox richTextBoxQuickSortDescription;
        private Label label2;
        private Button buttonFillArray;
        private TextBox textBoxArrayBeforeSort;
        private TextBox textBoxArrayAfterSort;
        private Button buttonQuickSort;
        private Label label3;
        private Panel panelBFS;
        private Label label4;
        private RichTextBox richTextBoxBFSDescription;
        private Button buttonStartBFS;
        private Label labelSteps;
    }
}
