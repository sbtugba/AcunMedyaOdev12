namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model = textBox2.Text;
            string renk = textBox3.Text;
            string kapiSayisi = textBox4.Text;
            string pencereSayisi = textBox5.Text;
            string yakit = textBox6.Text;

            string mesaj = $"Marka: {marka}\n" +
                           $"Model: {model}\n" +
                           $"Renk: {renk}\n" +
                           $"Kap� Say�s�: {kapiSayisi}\n" +
                           $"Pencere Say�s�: {pencereSayisi}\n" +
                           $"100 km�de Yakt��� Yak�t: {yakit} Litre";

            MessageBox.Show(mesaj, "Ara� Bilgileri");
        }
    }
}
