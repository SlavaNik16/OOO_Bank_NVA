using OOO_Bank_NVA.Models;
using System;
using System.Windows.Forms;

namespace OOO_Bank_NVA.Forms
{
    public partial class RegCardBankForm : Form
    {
        private Card card;
        private Random rnd;
        public RegCardBankForm()
        {
            InitializeComponent();
            rnd = new Random();
            card = new Card()
            {
                Balance = 0,
                CSCCode = rnd.Next(100, 1000),
                DateEnd = DateTime.Now.AddYears(4).ToString("MM/yy"),
            };
        }
        public Card Card => card;



        private void maskedTextBoxPinCode_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxPinCode.MaskFull)
            {
                card.PinCode = maskedTextBoxPinCode.Text;
            }
            else
            {
                card.PinCode = string.Empty;
            }
            ValidatePerson();
        }
        private void ValidatePerson()
        {
            butEnter.Enabled =
                !string.IsNullOrEmpty(card.Nomer.Trim()) &&
                !string.IsNullOrEmpty(card.PinCode.Trim());
               
        }

        private void maskedTextBoxNomer_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxNomer.MaskFull)
            {
                card.Nomer = maskedTextBoxNomer.Text;
            }
            else
            {
                card.Nomer = string.Empty;
            }
            ValidatePerson();
        }
    }
}
