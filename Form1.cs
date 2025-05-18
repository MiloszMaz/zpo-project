using projekt.Dto;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NbpService nbpService = new NbpService();
            List<ExchangeRate> list = nbpService.getExchangeRates();

            foreach (var item in list)
            {
                MessageBox.Show(item.currency);
            }
        }
    }
}
