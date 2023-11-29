using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
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
    public partial class MainForm : MaterialForm
    {
        private readonly BaseWriteRepository<Person> writeRepository;
        private readonly DbContextOptions<ApplicationContext> options;
        public static string UserName = ""; 
        public MainForm()
        {
            InitializeComponent();
            writeRepository = new BaseWriteRepository<Person>();
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
            if (personEnterForm.ShowDialog() == DialogResult.OK)
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
                        return;
                    }
                    var person = db.Persons.FirstOrDefault(x => x.Phone == dbBank.Login);
                    UserName = $"{person.Surname}_{person.Name}";
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
                UserName = $"{person.Surname}_{person.Name}";
                writeRepository.Add(person, UserName);
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
