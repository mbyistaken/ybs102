using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace soru3hamburger
{
    public partial class Form1 : Form
    {
        List<string> ekstralarr = new List<string>();
        string ekstralar;
        string menu;
        string icecek;


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            icecek = "Fuse Tea Þeftali";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            menu = "Big King";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ekstralarr.Add(checkBox1.Text);
            }
            else
            {
                ekstralarr.Remove(checkBox1.Text);
            }
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ekstralarr.Add(checkBox2.Text);
            }
            else
            {
                ekstralarr.Remove(checkBox2.Text);
            }
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                ekstralarr.Add(checkBox3.Text);
            }
            else
            {
                ekstralarr.Remove(checkBox3.Text);
            }
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            menu = "BK Steakhouse";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            menu = "BK Smokehouse";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            icecek = "Coca Cola";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            icecek = "Coca Cola Zero";
            listBox1.Items.Clear();
            foreach (string item in ekstralarr)
            {
                ekstralar = ekstralar + item + " ";
            }
            listBox1.Items.Add("Menü: " + menu);
            listBox1.Items.Add("Ýçecek: " + icecek);
            listBox1.Items.Add("Ekstra: " + ekstralar);
            ekstralar = "";
        }
    }
}
