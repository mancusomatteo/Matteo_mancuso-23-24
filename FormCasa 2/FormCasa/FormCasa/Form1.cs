using System.Drawing.Text;

namespace FormCasa
{
    public partial class Form1 : Form
    {
        Terreno c = new Terreno(35);
        private int guadagno = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Bilocale b = new Bilocale("nero", 1999);
            if(c.NUnita < 2)
            {
                MessageBox.Show("NON E POSSIBILE ALLOCARE ALTRI BILOCALI", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c.AllocaBi(b);
                listBox2.Items.Add(b);
                guadagno += 100;
                label2.Text = $"{guadagno:C}";
            }

            label4.Text = c.NUnita.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trilocale t = new Trilocale("bianco", 2006);
            if(c.NUnita < 3)
            {
                MessageBox.Show("NON E POSSIBILE ALLOCARE ALTRI TRILOCALI", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c.AllocaTri(t);
                listBox3.Items.Add(t);
                guadagno += 150;
                label2.Text = $"{guadagno:C}";
            }

            label4.Text = c.NUnita.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quadrilocale q = new Quadrilocale("rosso", 2013);
            if(c.NUnita < 4)
            {
                MessageBox.Show("NON E POSSIBILE ALLOCARE ALTRI QUADRILOCALI", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c.AllocaQua(q);
                listBox4.Items.Add(q);
                guadagno += 200;
                label2.Text = $"{guadagno:C}";
            }

            label4.Text = c.NUnita.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.DisallocaBi((Bilocale)listBox2.SelectedItem);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            guadagno -= 100;
            label2.Text = $"{guadagno:C}";
            label4.Text = c.NUnita.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.DisallocaTri((Trilocale)listBox3.SelectedItem);
            listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            guadagno -= 150;
            label2.Text = $"{guadagno:C}";
            label4.Text = c.NUnita.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.DisallocaQua((Quadrilocale)listBox4.SelectedItem);
            listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            guadagno -= 200;
            label2.Text = $"{guadagno:C}";
            label4.Text = c.NUnita.ToString();

        }
    }
}
