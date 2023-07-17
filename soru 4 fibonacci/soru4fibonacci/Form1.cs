namespace soru4fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string sonuc1;

        static void FibonnacciHesapla(int kacDefa)
        {
            int gecici1 = 1;
            int gecici2 = 1;
            int gecici3 = 0;

            sonuc1 = "1 - 1";
            if (kacDefa <= 0)
            {
                sonuc1 = "GEÇERSÝZ SAYI";
            }
            else if (kacDefa == 1)
            {
                sonuc1 = "1";
            }
            else if (kacDefa > 1)
            {
                for (int i = 0; i < kacDefa - 2; i++)
                {
                    gecici3 = (gecici1 + gecici2);
                    gecici1 = gecici2;
                    gecici2 = gecici3;
                    sonuc1 += " - " + gecici3.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                FibonnacciHesapla(int.Parse(textBox1.Text));
            }
            label2.Text = sonuc1;
        }
    }
}