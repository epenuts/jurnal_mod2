namespace jurnal_mod2
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text += "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text != "0")
            {
                textDisplay.Text += "0";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "+";
            textDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bil2 = Convert.ToDecimal(textDisplay.Text);
            {
                switch (opr)
                {
                    case 1:
                        textDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}