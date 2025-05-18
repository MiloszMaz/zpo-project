using projekt.Dto;
using projekt.Services;

namespace projekt
{
    public partial class Form1 : Form
    {
        private readonly NbpService _nbpService = new NbpService();
        private readonly FileService _fileService = new FileService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ExchangeRate> list = _nbpService.getExchangeRates();

            _fileService.save(list);

            //foreach (var item in list)
            //{
            //    MessageBox.Show(item.currency);
            //}
        }
    }
}
