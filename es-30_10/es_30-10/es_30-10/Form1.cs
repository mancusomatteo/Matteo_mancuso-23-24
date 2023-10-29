using System.Windows.Forms;

namespace es_30_10
{
    public partial class Form1 : Form
    {
        private List<Playlist> playlist = new List<Playlist>();
        public Form1()
        {
            InitializeComponent();
        }

        public void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (Playlist p in playlist)
            {
                listBox1.Items.Add(p);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string artista = textBox2.Text;
            int durata = (int)numericUpDown1.Value;
            string titoloAlbum = textBox4.Text;
            int n_tracce_album = (int)numericUpDown2.Value;
            bool ghost = checkBox1.Checked;

            try
            {
                Playlist Nuovaplaylist = new Playlist(titolo, titoloAlbum, artista, durata, n_tracce_album, ghost);
                playlist.Add(Nuovaplaylist);
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 1;
                textBox4.Clear();
                numericUpDown2.Value = 1;
                checkBox1.Checked = false;
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
                MessageBox.Show("devi selezionare un brano da cancellare.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                playlist.RemoveAt(listBox1.SelectedIndex);
                aggiorna();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Playlist p = (Playlist)listBox1.SelectedItem;
            string t = listBox1.Text.ToString();

            try
            {
                p.Modifica(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, textBox4.Text, (int)numericUpDown2.Value, checkBox1.Checked);
            }
            catch (Exception)
            {
                MessageBox.Show("Devi selezionare un brano da modificare.", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 1;
            textBox4.Clear();
            numericUpDown2.Value = 1;
            checkBox1.Checked = false;

            aggiorna();
        }


    }
}