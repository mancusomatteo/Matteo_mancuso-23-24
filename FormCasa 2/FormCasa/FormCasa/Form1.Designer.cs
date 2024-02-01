namespace FormCasa
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(223, 20);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 1;
            button1.Text = "ALLOCA BILOCALE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(340, 22);
            button2.Name = "button2";
            button2.Size = new Size(111, 48);
            button2.TabIndex = 2;
            button2.Text = "ALLOCA TRILOCALE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(457, 22);
            button3.Name = "button3";
            button3.Size = new Size(111, 48);
            button3.TabIndex = 3;
            button3.Text = "ALLOCA QUADRILOCALE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(223, 88);
            button4.Name = "button4";
            button4.Size = new Size(111, 48);
            button4.TabIndex = 4;
            button4.Text = "DISALLOCA BILOCALE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(340, 88);
            button5.Name = "button5";
            button5.Size = new Size(111, 48);
            button5.TabIndex = 5;
            button5.Text = "DISALLOCA TRILOCALE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(457, 88);
            button6.Name = "button6";
            button6.Size = new Size(111, 48);
            button6.TabIndex = 6;
            button6.Text = "DISALLOCA QUADRILOCALE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(19, 255);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(240, 154);
            listBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 155);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "GUADAGNO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 155);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 9;
            label2.Text = ". . .";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(279, 255);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(240, 154);
            listBox3.TabIndex = 10;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(548, 255);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(240, 154);
            listBox4.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 186);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 12;
            label3.Text = "SPAZIO DISPONIBILE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 186);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 13;
            label4.Text = ". . .";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 237);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "BILOCALI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 237);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 15;
            label6.Text = "TRILOCALI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 237);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 16;
            label7.Text = "QUADRILOCALI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
