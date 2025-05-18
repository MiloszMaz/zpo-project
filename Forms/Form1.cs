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
                MessageBox.Show("Data saved.", "Success");
            }
        }

        private void downloadData()
        {
            List<ExchangeRate> list = _nbpService.getExchangeRates();

            _fileService.save(list);
        }
    }
}
