namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Not: Say�n hocam, ForeColor de�i�tirmeme ra�men (bir�ok ba�ka y�ntem de denedim) progressBar�n rengini hi�bir �ekilde
        //de�i�tiremiyorum.
        //Internette yazan neredeyse her �eyi denedim ancak bir t�rl� de�i�tiremedim.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox1.Text;

            if (sifre.Length < 8 || sifre.Length > 20)
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                progressBar1.Value = sifre.Length * 5;
                textBox1.BackColor = Color.White;
            }


            if (sifre.Length >= 8 && sifre.Length <= 12)
            {
                progressBar1.ForeColor = Color.Red;
                label1.Text = "Zay�f";
            }
            else if (sifre.Length >= 13 && sifre.Length <= 17)
            {
                progressBar1.ForeColor = Color.Yellow;
                label1.Text = "Orta";
            }
            else if (sifre.Length >= 18 && sifre.Length <= 20)
            {
                progressBar1.ForeColor = Color.Green;
                label1.Text = "G��l�";
            }
            else if (sifre.Length >= 20)
            {
                progressBar1.Value = 0;
                label1.Text = "Ge�ersiz";
            }
        }
    }
}