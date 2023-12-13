using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Models;
using System;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class RegCardBankForm : MaterialForm
    {
        private Card card;
        private Random rnd;
        private DbContextOptions<ApplicationContext> options;
        public RegCardBankForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
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
                !string.IsNullOrEmpty(card.Nomer) &&
                !string.IsNullOrEmpty(card.PinCode);
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

        private void butEnter_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                var cardValidate = db.Cards.NotDeletedAt().IsCardWithPerson(card.Nomer);
                if (cardValidate)
                {
                    MessageBox.Show("Номер уже занят!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextBoxNomer.Text = string.Empty;
                    return;
                }
                DialogResult = DialogResult.OK;
            }

        }
    }
}
