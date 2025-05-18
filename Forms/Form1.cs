using System.Globalization;
using projekt.Calculators;
using projekt.Dto;
using projekt.Exceptions;
using projekt.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projekt
{
    public partial class Form1 : Form
    {
        private readonly NbpService _nbpService = new NbpService();
        private readonly FileService _fileService = new FileService();
        private readonly CurrencyCalculator _currencyCalculator = new CurrencyCalculator();
        private readonly OptionsService<string> _optionsService = new OptionsService<string>();

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
            this.addToListBox(list);
        }

        private void addToListBox(List<ExchangeRate> list)
        {
            var codes = list.Select(r => r.code).ToList();

            _optionsService.addOptions(codes);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(_optionsService.getOptions().ToArray());

            listBox2.Items.Clear();
            listBox2.Items.AddRange(_optionsService.getOptions().ToArray());
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

        private void calculate()
        {
            string input = textBox2.Text.Trim();

            if (decimal.TryParse(input, NumberStyles.Any, new CultureInfo("pl-PL"), out decimal amount))
            {
                string? fromCode = listBox1.SelectedItem?.ToString() ?? null;
                string? toCode = listBox2.SelectedItem?.ToString() ?? null;

                if (!string.IsNullOrEmpty(fromCode) && !string.IsNullOrEmpty(toCode))
                {
                    decimal calculatedAmount = this._currencyCalculator.convert(fromCode, toCode, amount);

                    label4.Text = calculatedAmount.ToString("0.00") + " " + toCode;
                }
            } else
            {
                throw new Exception("Wrong amount");
            }
        }

        public void selectRate(object sender, EventArgs e)
        {
            try
            {
                this.calculate();
            } catch(Exception exception) {
                MessageBox.Show("Coœ posz³o nie tak: " + exception.Message);
            }
        }
    }
}