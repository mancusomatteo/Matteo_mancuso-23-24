namespace esercizio1
{
    public partial class Form1 : Form
    {
        List<string> numeri = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        void visualizza()
        {
            listBox1.Items.Clear();
            foreach (string num in numeri)
            {
                listBox1.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {
                string numero = textBox1.Text;
                numeri.Add(numero);
                visualizza();
                textBox1.Clear();

            }
            else
            {
                MessageBox.Show("ERRORE! inserisci un numero valido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {
                string numero = textBox1.Text;
                numeri.Remove(numero);
                visualizza();
                textBox1.Clear();

            }
            else
            {
                MessageBox.Show("ERRORE! inserisci un numero valido");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}