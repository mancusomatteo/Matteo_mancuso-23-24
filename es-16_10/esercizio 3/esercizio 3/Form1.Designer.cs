namespace esercizio_3
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
            listBox1 = new ListBox();
            numero = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(312, 78);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 0;
            button1.Text = "aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 287);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 1;
            button2.Text = "esegui";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(472, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 319);
            listBox1.TabIndex = 2;
            // 
            // numero
            // 
            numero.AutoSize = true;
            numero.Location = new Point(25, 67);
            numero.Name = "numero";
            numero.Size = new Size(49, 15);
            numero.TabIndex = 3;
            numero.Text = "numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 255);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 7;
            label2.Text = "occorrenze di: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 319);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 8;
            label3.Text = "somma a tutti: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 152);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "minimo : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 204);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "massimo :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numero);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Label numero;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}