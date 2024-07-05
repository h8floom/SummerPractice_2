namespace lol_kek.practice_5
{
    partial class Form5
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
            textBoxX = new TextBox();
            textBoxN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCalculate = new Button();
            panel1 = new Panel();
            textBoxLogs = new TextBox();
            buttonShowLogs = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(52, 109);
            textBoxX.Margin = new Padding(6, 6, 6, 6);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(182, 39);
            textBoxX.TabIndex = 0;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(492, 109);
            textBoxN.Margin = new Padding(6, 6, 6, 6);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(182, 39);
            textBoxN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 70);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 3;
            label1.Text = "Значение X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 70);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 32);
            label2.TabIndex = 4;
            label2.Text = "Количество слагаемых n:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(279, 250);
            buttonCalculate.Margin = new Padding(6, 6, 6, 6);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(184, 68);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Посчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonCalculate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxN);
            panel1.Controls.Add(textBoxX);
            panel1.Location = new Point(102, 87);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 506);
            panel1.TabIndex = 6;
            // 
            // textBoxLogs
            // 
            textBoxLogs.Location = new Point(952, 87);
            textBoxLogs.Multiline = true;
            textBoxLogs.Name = "textBoxLogs";
            textBoxLogs.Size = new Size(623, 506);
            textBoxLogs.TabIndex = 7;
            // 
            // buttonShowLogs
            // 
            buttonShowLogs.Location = new Point(1163, 636);
            buttonShowLogs.Name = "buttonShowLogs";
            buttonShowLogs.Size = new Size(235, 74);
            buttonShowLogs.TabIndex = 8;
            buttonShowLogs.Text = "Вывести логи";
            buttonShowLogs.UseVisualStyleBackColor = true;
            buttonShowLogs.Click += buttonShowLogs_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 925);
            Controls.Add(buttonShowLogs);
            Controls.Add(textBoxLogs);
            Controls.Add(panel1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxN;
        private Label label1;
        private Label label2;
        private Button buttonCalculate;
        private Panel panel1;
        private TextBox textBoxLogs;
        private Button buttonShowLogs;
    }
}