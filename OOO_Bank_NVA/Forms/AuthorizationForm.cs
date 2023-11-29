using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Forms;
using OOO_Bank_NVA.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        public AuthorizationForm()
        {
            InitializeComponent();
            writePersonRepository = new BaseWriteRepository<Person>();
            writeDbBankRepository = new BaseWriteRepository<DBBank>();
            options = DataBaseHelper.Options();
            ColorsHelp.ButtonSubmit(butReg);
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butExit);
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
                    var dbBank = db.DBBanks.FirstOrDefault(x =>
                        x.Login.StartsWith(dbBankRequest.Login) &&
                        x.Password == getHashSha256(dbBankRequest.Password));
                    if(dbBank == null)
                    {
                        MessageBox.Show("Пользователь не найден среди зарегистрированных пользователей!",
                            "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                    }
                    var person = db.Persons.FirstOrDefault(x => x.Phone == dbBank.Login);
                    UserName = $"{person.Surname}_{person.Name}";
                    dbBank.Status = StatusType.Online;
                    writeDbBankRepository.Update(dbBank, UserName);
                    var mainForm = new MainForm();
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
                    Password = getHashSha256(personRegisterForm.Password)
                };
                UserName = $"{person.Surname}_{person.Name}";
                writePersonRepository.Add(person, UserName);
                writeDbBankRepository.Add(dbbank, UserName);
                MessageBox.Show("Пользователь успешно зарегистрирован!",
                           "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Show();
        }

        public static string getHashSha256(string text)
        {
            using (SHA256 hashString = SHA256.Create())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(text);
                byte[] hash = hashString.ComputeHash(bytes);
                string hashstring = "";
                foreach (byte x in hash)
                {
                    hashstring += String.Format("{0:x2}", x);
                }
                return hashstring;
            }
        }
    }
}
