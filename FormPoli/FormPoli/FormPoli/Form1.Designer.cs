namespace FormPoli
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
            listBox1 = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(260, 169);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(467, 46);
            button1.Name = "button1";
            button1.Size = new Size(105, 54);
            button1.TabIndex = 1;
            button1.Text = "ALLOCA BILOCALE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(467, 106);
            button3.Name = "button3";
            button3.Size = new Size(105, 54);
            button3.TabIndex = 3;
            button3.Text = "ALLOCA TRILOCALE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(467, 226);
            button4.Name = "button4";
            button4.Size = new Size(105, 54);
            button4.TabIndex = 4;
            button4.Text = "DEALLOCA EDIFICIO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(467, 166);
            button5.Name = "button5";
            button5.Size = new Size(105, 54);
            button5.TabIndex = 5;
            button5.Text = "ALLOCA QUADRILOCALE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 338);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "UNITA DISPONIBILI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 366);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "GUADAGNO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 60);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "LISTA EDIFICI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 246);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 9;
            label4.Text = "(Devi selezionare l'edificio)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
