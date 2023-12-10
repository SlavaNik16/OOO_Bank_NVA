using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class PersonRegisterForm : MaterialForm
    {
        private Person person;
        private string password;
        private DbContextOptions<ApplicationContext> options;
        public PersonRegisterForm()
        {
            InitializeComponent();
            person = new Person();
            options = DataBaseHelper.Options();
        }
        public Person Person => person;
        public string Password => password;
        private void genderFemaleRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            person.Gender = Gender.Female;
        }

        private void genderMaleRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            person.Gender = Gender.Male;
        }

        private void ValidatePerson()
        {
            butCreate.Enabled =
                !string.IsNullOrEmpty(person.Surname.Trim()) &&
                !string.IsNullOrEmpty(person.Name.Trim()) &&
                !string.IsNullOrEmpty(password.Trim()) &&
                !string.IsNullOrEmpty(person.Phone.Trim());
        }

        private void surnameBox_TextChanged(object sender, System.EventArgs e)
        {
            person.Name = surnameBox.Text.Trim();
            ValidatePerson();
        }

        private void nameBox_TextChanged(object sender, System.EventArgs e)
        {
            person.Surname = nameBox.Text.Trim();
            ValidatePerson();
        }

        private void maskPhoneText_TextChanged(object sender, System.EventArgs e)
        {
            if (maskPhoneText.MaskFull)
            {
                person.Phone = maskPhoneText.Text.Trim();
            }
            else
            {
                person.Phone = string.Empty;
            }
            ValidatePerson();
        }

        private void maskNumberCardText_TextChanged(object sender, System.EventArgs e)
        {
            if (maskNumberCardText.MaskFull)
            {
                person.CardName = maskNumberCardText.Text.Trim();
            }
            else
            {
                person.CardName = string.Empty;
            }
        }

        private void butCreate_Click(object sender, System.EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                var personValidate = db.DBBanks.IsPhoneWithLogin(person.Phone);
                if (personValidate)
                {
                    MessageBox.Show("Номер уже занят!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskPhoneText.Text = string.Empty;
                    return;
                }
                if (!string.IsNullOrEmpty(person.CardName.Trim()))
                {

                    var card = db.Cards.IsCardWithPerson(person.CardName.Trim());
                    if (!card)
                    {
                        MessageBox.Show("Ваша карта не найдена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maskNumberCardText.Text = string.Empty;
                        return;
                    }

                    var cardValidateForm = new CardValidateForm();
                    this.Hide();
                    cardValidateForm.ShowDialog();
                    this.Show();

                }
            }
            DialogResult = DialogResult.OK;
        }

        private void passwordBox_TextChanged(object sender, System.EventArgs e)
        {
            password = passwordBox.Text.Length >= 8 ? passwordBox.Text.Trim() : string.Empty;
            ValidatePerson();
        }
    }
}
