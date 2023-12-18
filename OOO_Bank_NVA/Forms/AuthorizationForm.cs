using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.ChatConnect;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.DB.ReadDB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Forms;
using OOO_Bank_NVA.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA
{
    public partial class AuthorizationForm : MaterialForm
    {
        private readonly BaseWriteRepository<Person> writePersonRepository;
        private readonly BaseWriteRepository<DBBank> writeDbBankRepository;
        private readonly DbContextOptions<ApplicationContext> options;
        public static string UserName = "";
        private readonly Chat chat;
        public static Person user { get; private set; }
        public static Person SetCardNameUser(string cardName)
        {
            user.CardName = cardName;
            return user;
        }
        public AuthorizationForm()
        {
            InitializeComponent();
            writePersonRepository = new BaseWriteRepository<Person>();
            writeDbBankRepository = new BaseWriteRepository<DBBank>();
            options = DataBaseHelper.Options();
            ColorsHelp.ButtonSubmit(butReg);
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butExit);
            chat = new Chat();
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            var personEnterForm = new PersonEnterForm();
            this.Hide();
            var result = personEnterForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var db = new ApplicationContext(options))
                {
                    var dbBankRequest = personEnterForm.DBBank;
                    var dbBank = db.DBBanks.NotDeletedAt().IsAuthorization(dbBankRequest.Login, dbBankRequest.Password);

                    if (dbBank == null)
                    {
                        MessageBox.Show("Пользователь не найден среди зарегистрированных пользователей!",
                            "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                    }
                    if(dbBank.Status == StatusType.Blocked)
                    {
                        MessageBox.Show("Аккаунт забанен!\nНапишите в тех. поддержку для дальнейшего продвижения!", 
                            "Забанен!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                    }
                    var person = db.Persons.NotDeletedAt().FirstOrDefault(x => x.Phone == dbBank.Login);
                    user = person;

                    UserName = $"{person.Surname}_{person.Name}";
                    chat.CreateOrReplace(user.Phone);
                    dbBank.Status = StatusType.Online;
                    writeDbBankRepository.Update(dbBank, UserName);
                    var mainForm = new MainForm(chat, dbBank.Role);
                    mainForm.ShowDialog();

                }
            }
            this.Show();
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            var personRegisterForm = new PersonRegisterForm();
            this.Hide();
            if (personRegisterForm.ShowDialog() == DialogResult.OK)
            {
                var person = personRegisterForm.Person;
                var dbbank = new DBBank()
                {
                    Login = person.Phone,
                    Password = CommonSpec.getHashSha256(personRegisterForm.Password)
                };
                UserName = $"{person.Surname}_{person.Name}";
                writePersonRepository.Add(person, UserName);
                writeDbBankRepository.Add(dbbank, UserName);

                MessageBox.Show("Пользователь успешно зарегистрирован!",
                           "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Show();
        }
    }
}
