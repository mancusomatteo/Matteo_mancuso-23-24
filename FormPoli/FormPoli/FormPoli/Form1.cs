using System.Windows.Forms;

namespace FormPoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Unità disponibili : " + terreno.Unita_disponibili;
            label2.Text = "Guadagno : " + terreno.Guadagno;
        }

        Terreno terreno = new Terreno(20);

        private void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (Edificio edificio in terreno.Edifici)
            {
                listBox1.Items.Add(edificio);
            }
            label1.Text = "Unità disponibili : " + terreno.Unita_disponibili;
            label2.Text = "Guadagno : " + terreno.Guadagno;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if(terreno.Unita_disponibili < 2)
            {
                MessageBox.Show("Non puoi piu allocale bilocali, spazio esaurito", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bilocale b = new Bilocale();
                terreno.alloca_ed(b);
                aggiorna();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (terreno.Unita_disponibili < 3)
            {
                MessageBox.Show("Non puoi piu allocale trilocali, spazio esaurito", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Trilocale t = new Trilocale();
                terreno.alloca_ed(t);
                aggiorna();
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (terreno.Unita_disponibili < 3)
            {
                MessageBox.Show("Non puoi piu allocale trilocali, spazio esaurito", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Quadrilocale q = new Quadrilocale();
                terreno.alloca_ed(q);
                aggiorna();
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona un edificio da deallocare");
                return;
            }
            terreno.dealloca_ed((Edificio)listBox1.SelectedItem);
            aggiorna();
        }
    }
}

