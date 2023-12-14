using MaterialSkin.Controls;
using System.Globalization;

namespace OOO_Bank_NVA.Forms
{
    public partial class CardTranslateMoneyForm : MaterialForm
    {
        private decimal balance;
        public CardTranslateMoneyForm(string cardNomer, decimal balance)
        {
            InitializeComponent();
            this.balance = balance;
            maskedTextBoxCard.Text = cardNomer;
            textBoxBalance.Text = balance.ToString();

            CultureInfo culture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }

        private void textBoxPrice_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }
        private decimal price = 0;
        public decimal GetPrice() => price;
        private void textBoxPrice_TextChanged(object sender, System.EventArgs e)
        {
            if (!decimal.TryParse(textBoxPrice.Text, out price) || price < 10 || price > balance)
            {
                butAdd.Enabled = false;
            }
            else
            {
                butAdd.Enabled = true;
            }
        }
    }
}
