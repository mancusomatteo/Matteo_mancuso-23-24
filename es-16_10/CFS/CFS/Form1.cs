namespace CFS
{
    public partial class Form1 : Form
    {
        string scelta = "";
        string sceltaComputer = "";
        int punti;
        int puntiComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scelta = "carta";
            gioco();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            scelta = "sasso";
            gioco();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            scelta = "forbice";
            gioco();

        }
        private void gioco()
        {
            var rand = new Random();
            int a = rand.Next(1, 4);

            if (a == 1)
            {
                sceltaComputer = "carta";


            }
            if (a == 2)
            {
                sceltaComputer = "sasso";


            }
            if (a == 3)
            {
                sceltaComputer = "forbice";


            }
            if (scelta == "carta" && sceltaComputer == "sasso")
            {
                punti += 1;
                textBox1.Text = punti.ToString();
                pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");
                pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");

            }
            if (scelta == "sasso" && sceltaComputer == "forbice")
            {
                punti += 1;
                textBox1.Text = punti.ToString();
                pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");
                pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");


                if (scelta == "forbice" && sceltaComputer == "carta")
                {
                    puntiComputer += 1;
                    textBox2.Text = puntiComputer.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");

                }
                if (scelta == "forbice" && sceltaComputer == "sasso")
                {
                    puntiComputer += 1;
                    textBox2.Text = puntiComputer.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");

                }
                if (scelta == "sasso" && sceltaComputer == "carta")
                {
                    puntiComputer += 1;
                    textBox2.Text = puntiComputer.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");

                }
                if (scelta == "carta" && sceltaComputer == "forbice")
                {
                    puntiComputer += 1;
                    textBox2.Text = puntiComputer.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");

                }
                if (scelta == "carta" && sceltaComputer == "carta")
                {
                    puntiComputer += 0;
                    punti += 0;
                    textBox2.Text = puntiComputer.ToString();
                    textBox1.Text = punti.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\carta.png\"");

                }
                if (scelta == "forbice" && sceltaComputer == "forbice")
                {
                    puntiComputer += 0;
                    punti += 0;
                    textBox2.Text = puntiComputer.ToString();
                    textBox1.Text = punti.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\forbice.png\"");

                }
                if (scelta == "sasso" && sceltaComputer == "sasso")
                {
                    puntiComputer += 0;
                    punti += 0;
                    textBox2.Text = puntiComputer.ToString();
                    textBox1.Text = punti.ToString();
                    pictureBox4.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");
                    pictureBox5.Load("\"C:\\Users\\Matteo\\OneDrive - IIS G. Marconi\\Desktop\\esericizi 16-10\\CFS\\immagini\\sasso.png\"");

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}