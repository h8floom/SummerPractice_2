namespace lol_kek.practice_4
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            textBoxInitialPrisoners = new TextBox();
            label1 = new Label();
            buttonCalculate = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 289);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxInitialPrisoners
            // 
            textBoxInitialPrisoners.Location = new Point(18, 45);
            textBoxInitialPrisoners.Name = "textBoxInitialPrisoners";
            textBoxInitialPrisoners.Size = new Size(191, 23);
            textBoxInitialPrisoners.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 2;
            label1.Text = "Начальное кол-во заключенных:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(313, 35);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(93, 41);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Посчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonCalculate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxInitialPrisoners);
            panel1.Location = new Point(146, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 99);
            panel1.TabIndex = 4;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxInitialPrisoners;
        private Label label1;
        private Button buttonCalculate;
        private Panel panel1;
    }
}