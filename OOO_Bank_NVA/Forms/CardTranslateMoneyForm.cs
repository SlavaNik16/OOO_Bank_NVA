using MaterialSkin.Controls;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.Forms
{
    public partial class CardTranslateMoneyForm : MaterialForm
    {
        public CardTranslateMoneyForm(string cardNomer, decimal balance)
        {
            InitializeComponent();
            maskedTextBoxCard.Text = cardNomer;
            textBoxBalance.Text = balance.ToString();
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
            if(!decimal.TryParse(textBoxPrice.Text, out price) && price < 10)
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
