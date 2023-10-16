using System.Windows.Forms;

namespace esercizio_3
{
    public partial class Form1 : Form
    {
        private int[] array = new int[1000];
        private int lungh_array = 0;
        int min = 1000000000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (lungh_array < 1000)
                {
                    array[lungh_array] = numero;
                    lungh_array++;
                    listBox1.Items.Add(numero);
                    textBox1.Clear();

                    AggiornaMinimoMassimo();
                }
                else
                {
                    MessageBox.Show("l'array è pieno, non è possibile aggiungere ulteriori valori.");
                }
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido.");
            }
        }
        private void AggiornaMinimoMassimo()
        {
            if (lungh_array > 0)
            {
                
                min = array[0];
                int max = array[0];

                
                for (int i = 1; i < lungh_array; i++)
                {
                    if (array[i] < min)
                        min = array[i];

                    if (array[i] > max)
                        max = array[i];
                }

                
                label4.Text = "Minimo: " + min;
                label5.Text = "Massimo: " + max;
            }
        }


        private int cerca(int[] vett, int numero)
        {
            int count = 0;
            foreach (int val in vett)
            {
                if (val == numero)
                    count++;
            }
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int numero))
            {
                int occ = cerca(array, numero);
                MessageBox.Show("il numero " + numero + " è presente " + occ + " volte nell'array");
            }
            else
            {
                MessageBox.Show("inserisci un numero valido.");
            }
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}

