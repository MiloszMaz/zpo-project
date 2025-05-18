using projekt.Dto;
using projekt.Exceptions;
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

            this.displayRatesFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.downloadData();
            }
            catch (FileException exception)
            {
                MessageBox.Show(exception.Message, "FileException");
            }
            catch (ApiException exception)
            {
                MessageBox.Show(exception.Message, "ApiException");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception");
            }
            finally
            {
                this.displayRatesFromFile();
                MessageBox.Show("Dane zosta³y zapisane i odœwie¿ono tabelê", "Success");
            }
        }

        private void downloadData()
        {
            List<ExchangeRate> list = _nbpService.getExchangeRates();

            _fileService.save(list);
        }

        private void displayRatesFromFile()
        {
            List<ExchangeRate> list = _fileService.getFromFile();

            this.displayRates(list);
        }

        private void displayRates(List<ExchangeRate> list)
        {
            this.changeColumn();
            dataGridViewRates.DataSource = null;
            dataGridViewRates.DataSource = list.OrderBy(r => r.currency).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<ExchangeRate> list = _fileService.getFromFile();
            string code = textBox1.Text.Trim().ToUpper();

            var filtered = list
                .Where(rate => rate.code.Contains(code))
                .OrderBy(rate => rate.code)
                .ToList();

            this.displayRates(filtered);
        }
    }
}
