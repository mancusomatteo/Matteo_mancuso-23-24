namespace esercizio_07_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                if (string.IsNullOrEmpty(Convert.ToString(textBox1.Text)))
                {
                    MessageBox.Show("Non puoi lasciare il campo della temperatura vuoto ", "ERRORE !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                float temp = float.Parse(textBox1.Text);

                int tipoconv = comboBox1.SelectedIndex;
                if (tipoconv == 0)
                {
                    label4.Text = Temperatura.fahreneitToCelsius(temp).ToString() + " °C";
                }
                if (tipoconv == 1)
                {
                    label4.Text = Temperatura.fahreneitToKelvin(temp).ToString() + " K";
                }
                if (tipoconv == 2)
                {
                    label4.Text = Temperatura.kelvinToCelsius(temp).ToString() + " °C";
                }
                if (tipoconv == 3)
                {
                    label4.Text = Temperatura.kelvinToFahreneit(temp).ToString() + " °F";
                }
                if (tipoconv == 4)
                {
                    label4.Text = Temperatura.celsiusToKelvin(temp).ToString() + " K";
                }
                if (tipoconv == 5)
                {
                    label4.Text = Temperatura.celsiusToFahreneit(temp).ToString() + " °F";
                }
            }
        }
    }
}