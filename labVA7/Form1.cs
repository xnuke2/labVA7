namespace labVA7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMidleRectangle.Text = string.Empty;
            labelLeftRegtangle.Text = string.Empty;
            labelRightRectangle.Text = string.Empty;
            labelSimpson.Text = string.Empty;
            labelTrapezoid.Text = string.Empty;
            labelErrorLeftRectangl.Text=string.Empty;
            labelErrorMidleRectangl.Text = string.Empty;
            labelErrorRightRectangl.Text = string.Empty;
            labelErrorSimpson.Text = string.Empty;
            labelErrorTrapezoid.Text=string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntegralCalculator calculator = new IntegralCalculator(Convert.ToDouble( numericUpDown1.Value));
            IntegralCalculator.rezult rez = calculator.FindIntegralMiddleRectangle();
            labelMidleRectangle.Text = Convert.ToString(rez.value);
            labelErrorMidleRectangl.Text=Convert.ToString(rez.ErrorRate);
            rez = calculator.FindIntegralLeftRectangle();
            labelLeftRegtangle.Text=Convert.ToString(rez.value);
            labelErrorLeftRectangl.Text= Convert.ToString(rez.ErrorRate);
            rez = calculator.FindIntegralRightRectangle();
            labelRightRectangle.Text=Convert.ToString(rez.value);
            labelErrorRightRectangl.Text = Convert.ToString(rez.ErrorRate);
            rez = calculator.FindIntegralTrapezoid();
            labelTrapezoid.Text=Convert.ToString(rez.value);
            labelErrorTrapezoid.Text = Convert.ToString(rez.ErrorRate);
            rez = calculator.FindIntegralSimpson();
            labelSimpson.Text=Convert.ToString(rez.value);
            labelErrorSimpson.Text= Convert.ToString(rez.ErrorRate);
        }
    }
}
