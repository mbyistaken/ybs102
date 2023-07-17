namespace soru2_personelidd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] personelAd = { "Polat Alemdar", "Lightning McQueen", "Rick Grimes", "Berat Tahtabiçen", "Mustafa Sandal", "Elon Musk", "Ryan Gosling", "Patrick Bateman", "Max Verstappen", "Mustafa Burak Yýldýrým" };
        private string[] personelTelefon = { "05555555555", "+1 666 778 54 42", "+1 432432434 44", "0506 600 00 00", "0500 001 01 01", "+1 111 111 22 33", "+1 232 232 23 23", "+1 123 123 1231", "+1 111 11 11 111", "0523 354 44 22" };
        private string[] personelYasadigiyer = { "Ýstanbul", "Amerika", "Amerika", "Ankara", "Ýstanbul", "SpaceX Konutlarý", "Ankara", "Hatay", "Hollanda", "Ankara" };


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Add.Text = personelAd[selectedIndex];
                Telefonn.Text = personelTelefon[selectedIndex];
                Yasadigiyerr.Text = personelYasadigiyer[selectedIndex];
            }
        }
    }
}