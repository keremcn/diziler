namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 78, 48, 55, 12, 99, 7, 33, 45, 78, 59 };
            int cifttoplam = 0;
            int tektoplam = 0;

            foreach (int i in dizi)
            {
                if (i % 2 == 0) cifttoplam += i;
                else tektoplam += i;
            }

            button1.Text = $"çift toplam={cifttoplam}, tek toplam = {tektoplam}, Fark = {Math.Abs(tektoplam-cifttoplam)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 78, 0, 55, 12, 0, 7, 33, 45, 0, 59 };
            

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 0) dizi[i] = 10;
                
            }

            button2.Text = "{"+string.Join(", ", dizi)+"}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] dizi = { "6", "M", "M", "L", "E", "6", "I", "I", "L", "E" };
            string tmp = "";

            tmp = dizi[2];
            dizi[2] = dizi[6];
            dizi[6] = tmp;

            button3.Text = string.Join(", ", dizi);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sonuc = 1;

            for (int i = 50; i <= 75; i+=5)
            {
                sonuc *= i;                
            }

            button4.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] dizi = { 12, 3, 4, 5, 6, 7, 8 };
            int ort = dizi.Length/2;

            button6.Text = "Ortanca = " + dizi[ort];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] dizi = { 78, 48, 55, 12, 99, 7, 33, 45, 78, 59 };
            int tektoplam = 0;

            foreach (int i in dizi)
            {
                if (i % 2 != 0) tektoplam += i;
                
            }

            button7.Text = $"Tek toplam = {tektoplam}";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(91,100);

            }

            button8.Text = string.Join(", ",dizi);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] dizi = { 78, 48, 55, 12, 99, 7, 33, 45, 78, 59 };            
            double toplam = 0;

            foreach (int i in dizi)
            {
                toplam += i;
            }

            button9.Text = "Ortalama = "+toplam/dizi.Length;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 0, 5, 6, 7, 8, 7, 5, 7, 4 };
            int sayac = 0;

            foreach (var item in dizi)
            {
                if (item == 7) sayac++;
            }

            button10.Text ="Dizide "+ sayac + " adet 7 vardýr.";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 0, 5, 6, 7, 8, 7, 5, 7, 4 };
            int len = dizi.Length; //10
            int[] ydizi = new int[len/2]; //5

            for (int i = 0; i < len/2; i++) //01234
            {
                ydizi[i] = dizi[i] + dizi[len-i-1];
            }

            button11.Text = "{"+string.Join(", ",ydizi)+"}";



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] dizi = { 78, 48, 55, 12, 99, 7, 33, 45, 78, 59 };

            //Array.Sort(dizi);
            int len = dizi.Length;


            for (int i = 0; i < len; i++)
            {
                for (int j = i+1; j < len; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        //swap
                        (dizi[i], dizi[j]) = (dizi[j], dizi[i]);
                    }

                }
            }

            button5.Text = "{"+string.Join(", ",dizi)+"}";

        }
       
        
    }
}