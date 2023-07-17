namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Not: Sayýn hocam, ForeColor deðiþtirmeme raðmen (birçok baþka yöntem de denedim) progressBarýn rengini hiçbir þekilde
        //deðiþtiremiyorum.
        //Internette yazan neredeyse her þeyi denedim ancak bir türlü deðiþtiremedim.
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
                label1.Text = "Zayýf";
            }
            else if (sifre.Length >= 13 && sifre.Length <= 17)
            {
                progressBar1.ForeColor = Color.Yellow;
                label1.Text = "Orta";
            }
            else if (sifre.Length >= 18 && sifre.Length <= 20)
            {
                progressBar1.ForeColor = Color.Green;
                label1.Text = "Güçlü";
            }
            else if (sifre.Length >= 20)
            {
                progressBar1.Value = 0;
                label1.Text = "Geçersiz";
            }
        }
    }
}