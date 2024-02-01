namespace es_27
{
    public partial class Form1 : Form
    {
        private List<Libro> libri = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }
        public void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (Libro l in libri)
            {
                listBox1.Items.Add(l);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string autore = textBox2.Text;
            int n_pagine = (int)numericUpDown1.Value;
            string genere = textBox4.Text;


            try
            {
                Libro nuovoLibro = new Libro(n_pagine, titolo, autore, genere);
                libri.Add(nuovoLibro);
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                numericUpDown1.Value = 1;
                aggiorna();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("devi selezionare un libro da cancellare.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                libri.RemoveAt(listBox1.SelectedIndex);
                aggiorna();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libro l = (Libro)listBox1.SelectedItem;
            string g = listBox1.Text.ToString();
            try
            {
                 
            }
            catch (Exception)
            {
                MessageBox.Show("Devi selezionare un libro da modificare.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 1;
            textBox4.Clear();
            aggiorna();
        }
    }
}