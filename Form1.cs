namespace WinFormsApp1{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            textBox1.PlaceholderText = "WprowadŸ pierwsz¹ liczbê";
            textBox2.PlaceholderText = "WprowadŸ drug¹ liczbê";
            textBox3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e){
            Operacja("+");
        }

        private void button2_Click(object sender, EventArgs e){
            Operacja("-");
        }

        private void button3_Click(object sender, EventArgs e){
            Operacja("*");
        }

        private void button4_Click(object sender, EventArgs e){
            Operacja("/");
        }

        private void button5_Click(object sender, EventArgs e){
            textBox3.Text = wynik.ToString();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e){

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e){

        }

        private double wynik = 0;
        private void Operacja(string operacja) {
            double liczba1, liczba2;
            if (double.TryParse(textBox1.Text, out liczba1) && double.TryParse(textBox2.Text, out liczba2))
            {
                switch (operacja)
                {
                    case "+":
                        wynik = liczba1 + liczba2;
                        break;
                    case "-":
                        wynik = liczba1 - liczba2;
                        break;
                    case "*":
                        wynik = liczba1 * liczba2;
                        break;
                    case "/":
                        if (liczba2 != 0)
                        {
                            wynik = liczba1 / liczba2;
                        }
                        else
                        {
                            MessageBox.Show("Nie mo¿na dzieliæ przez 0");
                        }
                        break;
                }
            }
        }
    }
}
