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
            panel5 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            buttonShow = new Button();
            listBoxSofa = new ListBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            buttonCreateObject = new Button();
            textBoxHeight = new TextBox();
            textBoxWidth = new TextBox();
            textBoxColor = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задание №1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(6, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(50, 52);
            panel5.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(listBoxSofa);
            panel2.Location = new Point(406, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 345);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(buttonShow);
            panel4.Location = new Point(89, 277);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 47);
            panel4.TabIndex = 6;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(3, 3);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(154, 39);
            buttonShow.TabIndex = 4;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // listBoxSofa
            // 
            listBoxSofa.FormattingEnabled = true;
            listBoxSofa.ItemHeight = 15;
            listBoxSofa.Location = new Point(3, 4);
            listBoxSofa.Name = "listBoxSofa";
            listBoxSofa.Size = new Size(331, 259);
            listBoxSofa.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBoxHeight);
            panel1.Controls.Add(textBoxWidth);
            panel1.Controls.Add(textBoxColor);
            panel1.Location = new Point(29, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 262);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 138);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 12;
            label3.Text = "Высота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Ширина";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 10;
            label1.Text = "Цвет";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonCreateObject);
            panel3.Location = new Point(75, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 55);
            panel3.TabIndex = 9;
            // 
            // buttonCreateObject
            // 
            buttonCreateObject.Location = new Point(3, 3);
            buttonCreateObject.Name = "buttonCreateObject";
            buttonCreateObject.Size = new Size(119, 47);
            buttonCreateObject.TabIndex = 0;
            buttonCreateObject.Text = "Создать объект";
            buttonCreateObject.UseVisualStyleBackColor = true;
            buttonCreateObject.Click += buttonCreateObject_Click;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(75, 135);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(127, 23);
            textBoxHeight.TabIndex = 2;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(75, 81);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(127, 23);
            textBoxWidth.TabIndex = 1;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(75, 21);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(127, 23);
            textBoxColor.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Задание №2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Задание №3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBoxSofa;
        private Button buttonShow;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private TextBox textBoxColor;
        private TabPage tabPage3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button buttonCreateObject;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}