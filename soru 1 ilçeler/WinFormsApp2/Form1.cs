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
                listBox1.Items.Add("D�rtyol");
                listBox1.Items.Add("�skenderun");
                listBox1.Items.Add("Antakya");
                listBox1.Items.Add("Samanda�");
                listBox1.Items.Add("Erzin");
                listBox1.Items.Add("Arsuz");
                listBox1.Items.Add("Kumlu");
                listBox1.Items.Add("K�r�khan");
                listBox1.Items.Add("Belen");
                listBox1.Items.Add("Alt�n�z�");
                listBox1.Items.Add("Yaylada�");
                listBox1.Items.Add("Hassa");
                listBox1.Items.Add("Defne");
                listBox1.Items.Add("Reyhanl�");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Sultanhan�");
                listBox1.Items.Add("G�zelyurt");
                listBox1.Items.Add("G�la�a�");
                listBox1.Items.Add("Sar�yah�i");
                listBox1.Items.Add("A�a��ren");
                listBox1.Items.Add("Ortak�y");
                listBox1.Items.Add("Eskil");
                listBox1.Items.Add("Aksaray Merkez");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Zara");
                listBox1.Items.Add("G�lova");
                listBox1.Items.Add("Koyulhisar");
                listBox1.Items.Add("Ak�nc�lar");
                listBox1.Items.Add("Y�ld�zeli");
                listBox1.Items.Add("�ark��la");
                listBox1.Items.Add("Gemerek");
                listBox1.Items.Add("Divri�i");
                listBox1.Items.Add("Alt�nyayla");
                listBox1.Items.Add("Kangal");
                listBox1.Items.Add("Sivas Merkez");
                listBox1.Items.Add("G�r�n");
                listBox1.Items.Add("Do�an�ar");
                listBox1.Items.Add("Ula�");
                listBox1.Items.Add("Hafik");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Alt�nordu");
                listBox1.Items.Add("G�lyal�");
                listBox1.Items.Add("Fatsa");
                listBox1.Items.Add("�nye");
                listBox1.Items.Add("�ama�");
                listBox1.Items.Add("Korgan");
                listBox1.Items.Add("Kabad�z");
                listBox1.Items.Add("Ulubey");
                listBox1.Items.Add("�ayba��");
                listBox1.Items.Add("Akku�");
                listBox1.Items.Add("Kumru");
                listBox1.Items.Add("Kabata�");
                listBox1.Items.Add("Aybast�");
                listBox1.Items.Add("G�lk�y");
                listBox1.Items.Add("G�rgentepe");
                listBox1.Items.Add("�kizce");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}