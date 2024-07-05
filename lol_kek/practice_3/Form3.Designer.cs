namespace lol_kek
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            listBoxSofa = new ListBox();
            panel1 = new Panel();
            comboBoxColor = new ComboBox();
            textBoxDelete = new TextBox();
            buttonDelete = new Button();
            buttonShow = new Button();
            buttonCreateObject = new Button();
            panel5 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHeight = new TextBox();
            textBoxColor = new TextBox();
            textBoxWidth = new TextBox();
            tabPage2 = new TabPage();
            panel8 = new Panel();
            pictureBoxFigures = new PictureBox();
            panel7 = new Panel();
            buttonDraw = new Button();
            panel6 = new Panel();
            groupBox2 = new GroupBox();
            labelSquareSize = new Label();
            textBoxSquareSize = new TextBox();
            buttonCreateSquare = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            buttonCreateOval = new Button();
            textBoxOvalHeight = new TextBox();
            textBoxOvalWidth = new TextBox();
            tabPage3 = new TabPage();
            panel10 = new Panel();
            textBoxCalculatorResult = new TextBox();
            panel9 = new Panel();
            buttonSqrt = new Button();
            buttonMultiply = new Button();
            label7 = new Label();
            label6 = new Label();
            textBoxSecondValue = new TextBox();
            textBoxFirstValue = new TextBox();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigures).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(22, 26);
            tabControl1.Margin = new Padding(6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1441, 909);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6);
            tabPage1.Size = new Size(1425, 855);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание №1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxSofa);
            panel2.Location = new Point(11, 13);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1404, 499);
            panel2.TabIndex = 14;
            // 
            // listBoxSofa
            // 
            listBoxSofa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listBoxSofa.FormattingEnabled = true;
            listBoxSofa.ItemHeight = 65;
            listBoxSofa.Location = new Point(6, 6);
            listBoxSofa.Margin = new Padding(6);
            listBoxSofa.Name = "listBoxSofa";
            listBoxSofa.Size = new Size(1389, 394);
            listBoxSofa.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBoxColor);
            panel1.Controls.Add(textBoxDelete);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonShow);
            panel1.Controls.Add(buttonCreateObject);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxHeight);
            panel1.Controls.Add(textBoxColor);
            panel1.Controls.Add(textBoxWidth);
            panel1.Location = new Point(11, 525);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 307);
            panel1.TabIndex = 13;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Items.AddRange(new object[] { "Желтый ", "Синий ", "Фиолетовый" });
            comboBoxColor.Location = new Point(436, 32);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(232, 40);
            comboBoxColor.TabIndex = 16;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(995, 234);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(200, 39);
            textBoxDelete.TabIndex = 15;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(718, 222);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(271, 62);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Удалить объект";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(983, 134);
            buttonShow.Margin = new Padding(6);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(156, 58);
            buttonShow.TabIndex = 13;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonCreateObject
            // 
            buttonCreateObject.Location = new Point(750, 113);
            buttonCreateObject.Margin = new Padding(6);
            buttonCreateObject.Name = "buttonCreateObject";
            buttonCreateObject.Size = new Size(221, 100);
            buttonCreateObject.TabIndex = 0;
            buttonCreateObject.Text = "Создать объект";
            buttonCreateObject.UseVisualStyleBackColor = true;
            buttonCreateObject.Click += buttonCreateObject_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(1298, 186);
            panel5.Margin = new Padding(6);
            panel5.Name = "panel5";
            panel5.Size = new Size(93, 111);
            panel5.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 215);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 12;
            label3.Text = "Высота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 154);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 11;
            label2.Text = "Ширина";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 87);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 32);
            label1.TabIndex = 10;
            label1.Text = "Цвет";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(436, 209);
            textBoxHeight.Margin = new Padding(6);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(232, 39);
            textBoxHeight.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(436, 81);
            textBoxColor.Margin = new Padding(6);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(232, 39);
            textBoxColor.TabIndex = 0;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(436, 147);
            textBoxWidth.Margin = new Padding(6);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(232, 39);
            textBoxWidth.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel8);
            tabPage2.Controls.Add(panel7);
            tabPage2.Controls.Add(panel6);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6);
            tabPage2.Size = new Size(1425, 855);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание №2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(pictureBoxFigures);
            panel8.Location = new Point(11, 13);
            panel8.Margin = new Padding(6);
            panel8.Name = "panel8";
            panel8.Size = new Size(1401, 373);
            panel8.TabIndex = 4;
            // 
            // pictureBoxFigures
            // 
            pictureBoxFigures.Location = new Point(6, 6);
            pictureBoxFigures.Margin = new Padding(6);
            pictureBoxFigures.Name = "pictureBoxFigures";
            pictureBoxFigures.Size = new Size(1385, 367);
            pictureBoxFigures.TabIndex = 0;
            pictureBoxFigures.TabStop = false;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(buttonDraw);
            panel7.Location = new Point(11, 403);
            panel7.Margin = new Padding(6);
            panel7.Name = "panel7";
            panel7.Size = new Size(1402, 151);
            panel7.TabIndex = 3;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(609, 36);
            buttonDraw.Margin = new Padding(6);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(182, 92);
            buttonDraw.TabIndex = 2;
            buttonDraw.Text = "Нарисовать";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(groupBox2);
            panel6.Controls.Add(groupBox1);
            panel6.Location = new Point(11, 563);
            panel6.Margin = new Padding(6);
            panel6.Name = "panel6";
            panel6.Size = new Size(1401, 275);
            panel6.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelSquareSize);
            groupBox2.Controls.Add(textBoxSquareSize);
            groupBox2.Controls.Add(buttonCreateSquare);
            groupBox2.Location = new Point(704, 6);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(682, 262);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Квадрат";
            // 
            // labelSquareSize
            // 
            labelSquareSize.AutoSize = true;
            labelSquareSize.Location = new Point(113, 77);
            labelSquareSize.Margin = new Padding(6, 0, 6, 0);
            labelSquareSize.Name = "labelSquareSize";
            labelSquareSize.Size = new Size(94, 32);
            labelSquareSize.TabIndex = 10;
            labelSquareSize.Text = "Размер";
            // 
            // textBoxSquareSize
            // 
            textBoxSquareSize.Location = new Point(72, 137);
            textBoxSquareSize.Margin = new Padding(6);
            textBoxSquareSize.Name = "textBoxSquareSize";
            textBoxSquareSize.Size = new Size(182, 39);
            textBoxSquareSize.TabIndex = 9;
            // 
            // buttonCreateSquare
            // 
            buttonCreateSquare.Location = new Point(397, 90);
            buttonCreateSquare.Margin = new Padding(6);
            buttonCreateSquare.Name = "buttonCreateSquare";
            buttonCreateSquare.Size = new Size(202, 96);
            buttonCreateSquare.TabIndex = 8;
            buttonCreateSquare.Text = "Создать квадрат";
            buttonCreateSquare.UseVisualStyleBackColor = true;
            buttonCreateSquare.Click += buttonCreateSquare_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonCreateOval);
            groupBox1.Controls.Add(textBoxOvalHeight);
            groupBox1.Controls.Add(textBoxOvalWidth);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(687, 262);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Овал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 181);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 4;
            label5.Text = "Высота";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 66);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 3;
            label4.Text = "Ширина";
            // 
            // buttonCreateOval
            // 
            buttonCreateOval.Location = new Point(414, 90);
            buttonCreateOval.Margin = new Padding(6);
            buttonCreateOval.Name = "buttonCreateOval";
            buttonCreateOval.Size = new Size(188, 96);
            buttonCreateOval.TabIndex = 2;
            buttonCreateOval.Text = "Создать овал";
            buttonCreateOval.UseVisualStyleBackColor = true;
            buttonCreateOval.Click += buttonCreateOval_Click;
            // 
            // textBoxOvalHeight
            // 
            textBoxOvalHeight.Location = new Point(126, 175);
            textBoxOvalHeight.Margin = new Padding(6);
            textBoxOvalHeight.Name = "textBoxOvalHeight";
            textBoxOvalHeight.Size = new Size(182, 39);
            textBoxOvalHeight.TabIndex = 1;
            // 
            // textBoxOvalWidth
            // 
            textBoxOvalWidth.Location = new Point(126, 60);
            textBoxOvalWidth.Margin = new Padding(6);
            textBoxOvalWidth.Name = "textBoxOvalWidth";
            textBoxOvalWidth.Size = new Size(182, 39);
            textBoxOvalWidth.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel10);
            tabPage3.Controls.Add(panel9);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Margin = new Padding(6);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(6);
            tabPage3.Size = new Size(1425, 855);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание №3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Controls.Add(textBoxCalculatorResult);
            panel10.Location = new Point(11, 13);
            panel10.Margin = new Padding(6);
            panel10.Name = "panel10";
            panel10.Size = new Size(1401, 535);
            panel10.TabIndex = 1;
            // 
            // textBoxCalculatorResult
            // 
            textBoxCalculatorResult.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCalculatorResult.Location = new Point(6, 6);
            textBoxCalculatorResult.Margin = new Padding(6);
            textBoxCalculatorResult.Multiline = true;
            textBoxCalculatorResult.Name = "textBoxCalculatorResult";
            textBoxCalculatorResult.Size = new Size(1382, 514);
            textBoxCalculatorResult.TabIndex = 0;
            textBoxCalculatorResult.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(buttonSqrt);
            panel9.Controls.Add(buttonMultiply);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(textBoxSecondValue);
            panel9.Controls.Add(textBoxFirstValue);
            panel9.Location = new Point(11, 565);
            panel9.Margin = new Padding(6);
            panel9.Name = "panel9";
            panel9.Size = new Size(1413, 269);
            panel9.TabIndex = 0;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Location = new Point(609, 205);
            buttonSqrt.Margin = new Padding(6);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(202, 49);
            buttonSqrt.TabIndex = 5;
            buttonSqrt.Text = "Извлечь корень";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(643, 143);
            buttonMultiply.Margin = new Padding(6);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(139, 49);
            buttonMultiply.TabIndex = 4;
            buttonMultiply.Text = "Умножить";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(828, 36);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 32);
            label7.TabIndex = 3;
            label7.Text = "Второе число";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 36);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 2;
            label6.Text = "Первое число";
            // 
            // textBoxSecondValue
            // 
            textBoxSecondValue.Location = new Point(810, 75);
            textBoxSecondValue.Margin = new Padding(6);
            textBoxSecondValue.Name = "textBoxSecondValue";
            textBoxSecondValue.Size = new Size(182, 39);
            textBoxSecondValue.TabIndex = 1;
            // 
            // textBoxFirstValue
            // 
            textBoxFirstValue.Location = new Point(425, 75);
            textBoxFirstValue.Margin = new Padding(6);
            textBoxFirstValue.Name = "textBoxFirstValue";
            textBoxFirstValue.Size = new Size(182, 39);
            textBoxFirstValue.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(tabControl1);
            Margin = new Padding(6);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigures).EndInit();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel5;
        private TextBox textBoxOvalWidth;
        private Panel panel6;
        private GroupBox groupBox1;
        private Button buttonCreateOval;
        private TextBox textBoxOvalHeight;
        private Button buttonCreateSquare;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Panel panel7;
        private Button buttonDraw;
        private Panel panel8;
        private PictureBox pictureBoxFigures;
        private Label labelSquareSize;
        private TextBox textBoxSquareSize;
        private Panel panel9;
        private Label label7;
        private Label label6;
        private TextBox textBoxSecondValue;
        private TextBox textBoxFirstValue;
        private Panel panel10;
        private TextBox textBoxCalculatorResult;
        private Button buttonSqrt;
        private Button buttonMultiply;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCreateObject;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private TextBox textBoxColor;
        private Panel panel2;
        private ListBox listBoxSofa;
        private Panel panel1;
        private Button buttonShow;
        private Button buttonDelete;
        private TextBox textBoxDelete;
        private ComboBox comboBoxColor;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
    }
}