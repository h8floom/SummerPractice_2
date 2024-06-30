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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(28, 51);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 0;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(265, 51);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(100, 23);
            textBoxN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Значение X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 33);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество слагаемых n:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(150, 117);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(99, 32);
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
            panel1.Location = new Point(55, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 177);
            panel1.TabIndex = 6;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 270);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxN;
        private Label label1;
        private Label label2;
        private Button buttonCalculate;
        private Panel panel1;
    }
}