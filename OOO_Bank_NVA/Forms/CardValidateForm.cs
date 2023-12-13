using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class CardValidateForm : MaterialForm
    {
        private Card card;
        private DbContextOptions<ApplicationContext> options;
        public CardValidateForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
            card = new Card();
        }
        public Card Card => card;
        private void maskDataEnd_TextChanged(object sender, System.EventArgs e)
        {
            if (maskDataEnd.MaskFull)
            {
                card.DateEnd = maskDataEnd.Text.Trim();
            }
            else
            {
                card.DateEnd = string.Empty;
            }
            ValidatePerson();
        }

        private void maskedTextBoxCVCCode_TextChanged(object sender, System.EventArgs e)
        {
            if (maskedTextBoxCVCCode.MaskFull)
            {
                card.CSCCode = int.Parse(maskedTextBoxCVCCode.Text.Trim());
            }
            else
            {
                card.CSCCode = 0;
            }
            ValidatePerson();
        }
        private void ValidatePerson()
        {
            butEnter.Enabled =
                !string.IsNullOrEmpty(card.DateEnd) &&
                !string.IsNullOrEmpty(card.Nomer) &&
                card.CSCCode != 0;

        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            var pinCodeForm = new PINCodeForm();
            if (pinCodeForm.ShowDialog() == DialogResult.OK)
            {
                using (var db = new ApplicationContext(options))
                {
                    var cardValidate = db.Cards.NotDeletedAt().FirstOrDefault(x => x.DateEnd == card.DateEnd && x.CSCCode == card.CSCCode && x.PinCode == pinCodeForm.PINCODE);
                    if (cardValidate == null)
                    {
                        MessageBox.Show("Неверно введенные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            DialogResult = DialogResult.OK;

        }

        private void maskedTextBoxNomer_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxNomer.MaskFull)
            {
                card.Nomer = maskedTextBoxNomer.Text.Trim();
            }
            else
            {
                card.Nomer = string.Empty;
            }
            ValidatePerson();
        }
    }
}
