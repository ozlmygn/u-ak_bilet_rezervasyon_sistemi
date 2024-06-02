namespace uçak_bilet_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : " + "Nereden " + comboBox1 + "Nereye: " + comboBox2 + "Tarih: " + dateTimePicker1 + "Yolcu Bilgileri >>> Adı Soyadı : " + textBox1 + "Telefon: " + maskedTextBox1 + "TC: " + maskedTextBox2);
            MessageBox.Show("Yolcu kaydı yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;

        }
    }

}