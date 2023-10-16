namespace esercizio1
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
            label1 = new Label();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(338, 106);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "NUMERO :";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(305, 203);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(498, 244);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(27, 25);
            button1.Name = "button1";
            button1.Size = new Size(158, 79);
            button1.TabIndex = 3;
            button1.Text = "inserisci numero";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(27, 296);
            button2.Name = "button2";
            button2.Size = new Size(158, 73);
            button2.TabIndex = 4;
            button2.Text = "cancella numero";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}