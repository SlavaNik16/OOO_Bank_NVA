using MaterialSkin.Controls;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.Models;
using System;
using System.Windows.Forms;
namespace OOO_Bank_NVA.Forms
{
    public partial class PersonEnterForm : MaterialForm
    {
        private DBBank dbBank;
        public PersonEnterForm(bool IsDelete = false)
        {
            InitializeComponent();

            dbBank = new DBBank();
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butCancel);

            if (IsDelete)
            {
                this.Text = "Удаление аккаунта";
                maskPhoneText.ReadOnly = true;
                maskPhoneText.Text = AuthorizationForm.user.Phone;

            }
        }

        public DBBank DBBank => dbBank;

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            if (maskPhoneText.MaskFull)
            {
                dbBank.Login = maskPhoneText.Text.Trim();
            }
            else
            {
                dbBank.Login = string.Empty;
            }
            ValidatePerson();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            dbBank.Password = passwordBox.Text.Length >= 8 ? passwordBox.Text.Trim() : string.Empty;
            ValidatePerson();
        }
        private void ValidatePerson()
        {
            butEnter.Enabled =
                !string.IsNullOrEmpty(dbBank.Login) &&
                !string.IsNullOrEmpty(dbBank.Password);
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
