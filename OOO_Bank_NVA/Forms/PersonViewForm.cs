

using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Nuget;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class PersonViewForm : MaterialForm
    {
        private Person person;
        private DBBank dbBank;
        private DbContextOptions<ApplicationContext> options;
        private BaseWriteRepository<Card> baseCardWriteRepository;
        private BaseWriteRepository<DBBank> baseDBBankWriteRepository;
        public PersonViewForm(Person person)
        {
            InitializeComponent();
            options = DataBaseHelper.Options();
            baseCardWriteRepository = new BaseWriteRepository<Card>();
            baseDBBankWriteRepository = new BaseWriteRepository<DBBank>();
            this.person = person;
            textBoxName.Text = person.Name;
            textBoxSurname.Text = person.Surname;
            maskTextBoxPhone.Text = person.Phone;
            textBoxGender.Text = person.Gender.PerevodDescription();
            maskTextBoxCardName.Text = person.CardName ?? string.Empty;
            using (var db = new ApplicationContext(options))
            {
                dbBank = db.DBBanks.NotDeletedAt().FirstOrDefault(x=>x.Login == person.Phone);
                if (dbBank == null) return;
                butBan.Text = dbBank.Status == StatusType.Blocked ? "Разбанить" : "Забанить";
            }
            butTranslate.Enabled = AuthorizationForm.user.CardName != null;
        }

        private void butTranslate_Click(object sender, System.EventArgs e)
        {
            var cardName = maskTextBoxCardName.Text;
            if (person.CardName == null)
            {
                MessageBox.Show($"У данного пользователя нет карты!",
                       "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(cardName == AuthorizationForm.user.CardName)
            {
                MessageBox.Show($"Вы не можете отправить деньги на одну и туже карту!",
                      "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var db = new ApplicationContext(options))
            {
                var cardOther = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == cardName);
                var cardUser = db.Cards.NotDeletedAt().FirstOrDefault(x => x.Nomer == AuthorizationForm.user.CardName);
                if (cardOther == null || cardOther == null) return;
                var cardTranslateMoneyForm = new CardTranslateMoneyForm(cardUser.Nomer, cardUser.Balance);
                this.Hide();
                if (cardTranslateMoneyForm.ShowDialog() == DialogResult.OK)
                {
                    cardOther.Balance += cardTranslateMoneyForm.GetPrice();
                    cardUser.Balance -= cardTranslateMoneyForm.GetPrice();
                    baseCardWriteRepository.Update(cardOther);
                    baseCardWriteRepository.Update(cardUser);
                    MessageBox.Show($"Перевод успешно выполнен!",
                       "Информация!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Show();
            }
        }

        private void butBan_Click(object sender, System.EventArgs e)
        {
            var phone = maskTextBoxPhone.Text;
            using (var db = new ApplicationContext(options))
            {
                var person = db.Persons.NotDeletedAt().FirstOrDefault(x => x.Phone == phone);
                if (person == null) return;

                var result = MessageBox.Show($"Вы действительно хотите {butBan.Text}\n" +
                    $"Id: {person.Id}\n" +
                    $"Телефон: {person.Phone}\n" +
                    $"Фамилия:{person.Surname}\n" +
                    $"Имя: {person.Name}", "Предупреждение!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    dbBank.Status = dbBank.Status == StatusType.Blocked ? StatusType.Offline : StatusType.Blocked;
                    baseDBBankWriteRepository.Update(dbBank, AuthorizationForm.UserName);
                    MessageBox.Show($"Пользователь успешно {(dbBank.Status == StatusType.Blocked ? "Забанен" : "Разбанен")}!",
                        "Информация!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
