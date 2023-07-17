namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Payas");
                listBox1.Items.Add("Dörtyol");
                listBox1.Items.Add("Ýskenderun");
                listBox1.Items.Add("Antakya");
                listBox1.Items.Add("Samandað");
                listBox1.Items.Add("Erzin");
                listBox1.Items.Add("Arsuz");
                listBox1.Items.Add("Kumlu");
                listBox1.Items.Add("Kýrýkhan");
                listBox1.Items.Add("Belen");
                listBox1.Items.Add("Altýnözü");
                listBox1.Items.Add("Yayladað");
                listBox1.Items.Add("Hassa");
                listBox1.Items.Add("Defne");
                listBox1.Items.Add("Reyhanlý");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Sultanhaný");
                listBox1.Items.Add("Güzelyurt");
                listBox1.Items.Add("Gülaðaç");
                listBox1.Items.Add("Sarýyahþi");
                listBox1.Items.Add("Aðaçören");
                listBox1.Items.Add("Ortaköy");
                listBox1.Items.Add("Eskil");
                listBox1.Items.Add("Aksaray Merkez");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Zara");
                listBox1.Items.Add("Gölova");
                listBox1.Items.Add("Koyulhisar");
                listBox1.Items.Add("Akýncýlar");
                listBox1.Items.Add("Yýldýzeli");
                listBox1.Items.Add("Þarkýþla");
                listBox1.Items.Add("Gemerek");
                listBox1.Items.Add("Divriði");
                listBox1.Items.Add("Altýnyayla");
                listBox1.Items.Add("Kangal");
                listBox1.Items.Add("Sivas Merkez");
                listBox1.Items.Add("Gürün");
                listBox1.Items.Add("Doðanþar");
                listBox1.Items.Add("Ulaþ");
                listBox1.Items.Add("Hafik");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Altýnordu");
                listBox1.Items.Add("Gülyalý");
                listBox1.Items.Add("Fatsa");
                listBox1.Items.Add("Ünye");
                listBox1.Items.Add("Çamaþ");
                listBox1.Items.Add("Korgan");
                listBox1.Items.Add("Kabadüz");
                listBox1.Items.Add("Ulubey");
                listBox1.Items.Add("Çaybaþý");
                listBox1.Items.Add("Akkuþ");
                listBox1.Items.Add("Kumru");
                listBox1.Items.Add("Kabataþ");
                listBox1.Items.Add("Aybastý");
                listBox1.Items.Add("Gölköy");
                listBox1.Items.Add("Gürgentepe");
                listBox1.Items.Add("Ýkizce");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}