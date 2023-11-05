namespace es_06_11
{
    public partial class Form1 : Form
    {
        private List<Videogiochi> videogiochi;
        public Form1()
        {
            InitializeComponent();
            videogiochi = new List<Videogiochi>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string _prezzoDiAcquisto = textBox2.Text;
            double prezzo = 0;
            string _dataDiAcquisto = textBox3.Text;
            DateTime data = DateTime.Now;
            string console = textBox4.Text;
            Videogiochi b = null;
            try
            {
                prezzo = double.Parse(_prezzoDiAcquisto);
                data = DateTime.Parse(_dataDiAcquisto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("valore prezzo e/o data errata");
                return;
            }
            try
            {
                b = new Videogiochi(titolo, prezzo, data, console);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            videogiochi.Add(b);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            aggiorna();

        }
        private void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (Videogiochi b in videogiochi)
            {
                listBox1.Items.Add(b);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selezionato = listBox1.SelectedIndex;
            if (selezionato == -1)
            {
                MessageBox.Show("seelziona un videogioco");
            }
            else
            {
                videogiochi.RemoveAt(selezionato);
                aggiorna();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string _prezzoDiAcquisto = textBox2.Text;
            double prezzo = 0;
            string _dataDiAcquisto = textBox3.Text;
            DateTime data = DateTime.Now;
            string console = textBox4.Text;

            try
            {
                prezzo = double.Parse(_prezzoDiAcquisto);
                data = DateTime.Parse(_dataDiAcquisto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("valore prezzo e/o data errata");
                return;
            }
            Videogiochi b = videogiochi[listBox1.SelectedIndex];
            try
            {
                b.Titolo = titolo;
                b.DataDiAcquisto = data;
                b.PrezzoDiAcquisto = prezzo;
                b.Console = console;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            aggiorna();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selezionato = listBox1.SelectedIndex;
            if (selezionato == -1)
            {
                MessageBox.Show("seleziona un videogioco");
            }
            else
            {
                Videogiochi old = videogiochi[selezionato];
                Videogiochi newb = new Videogiochi(old);
                videogiochi.Add(newb);
                aggiorna();
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Videogiochi b = videogiochi[listBox1.SelectedIndex];
            textBox1.Text = b.Titolo;
            textBox2.Text = b.PrezzoDiAcquisto.ToString();
            textBox3.Text = b.DataDiAcquisto.ToString();
            textBox4.Text = b.Console;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (videogiochi.Count == 0)
            {
                MessageBox.Show("nessun videogioco da eliminare");
            }
            videogiochi.Clear();
            aggiorna();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           string consoleSelezionata=comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            foreach  (Videogiochi videogioco in videogiochi)
            {
                if(videogioco.Console == consoleSelezionata)
                listBox1.Items.Add(videogioco);
            }
        }
    }
}