using System.Windows.Forms;

namespace es_24_11
{
    public partial class Form1 : Form
    {
        Cassa cassa1;
        Cassa cassa2;
        Cassa cassa3;
        public Form1()
        {
            InitializeComponent();
            cassa1 = new Cassa();
            cassa2 = new Cassa();
            cassa3 = new Cassa();
        }


        private void VenditaSingola(Cassa c)
        {
            try
            {
                c.VendiBiglietto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AggiornaTotBV();
        }

        private void VenditaMultipla(Cassa c, int n)
        {
            try
            {
                c.VendiBiglietto(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AggiornaTotBV();
        }

        private void AnnulaSingola(Cassa c)
        {
            try
            {
                c.AnnullaBiglietto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AggiornaTotBV();
        }
        private void AnnullaMultipla(Cassa c, int n)
        {
            try
            {
                c.AnnullaBiglietto(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AggiornaTotBV();
        }

        public void AggiornaTotBV()
        {
            label4.Text = Cassa.TotBiglVend.ToString();
            label8.Text = Cassa.TotBiglVend.ToString();
            label12.Text = Cassa.TotBiglVend.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VenditaSingola(cassa1);
            label2.Text = cassa1.NumB.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            VenditaMultipla(cassa1, 5);
            label2.Text = cassa1.NumB.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AnnulaSingola(cassa1);
            label2.Text = cassa1.NumB.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AnnullaMultipla(cassa1, (int)numericUpDown1.Value);
            label2.Text = cassa1.NumB.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            VenditaSingola(cassa2);
            label6.Text = cassa2.NumB.ToString();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            VenditaMultipla(cassa2, 7);
            label6.Text = cassa2.NumB.ToString();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            AnnulaSingola(cassa2);
            label6.Text = cassa2.NumB.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AnnullaMultipla(cassa2, (int)numericUpDown2.Value);
            label7.Text = cassa2.NumB.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            VenditaSingola(cassa3);
            label10.Text = cassa3.NumB.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            VenditaMultipla(cassa3, 3);
            label10.Text = cassa3.NumB.ToString();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            AnnulaSingola(cassa3);
            label10.Text = cassa3.NumB.ToString();
        }
        private void button12_Click_1(object sender, EventArgs e)
        {
            AnnullaMultipla(cassa3, (int)numericUpDown3.Value);
            label10.Text = cassa3.NumB.ToString();
        }
    }
}
