using MaterialSkin.Controls;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Forms;
using OOO_Bank_NVA.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OOO_Bank_NVA
{
    public partial class MainForm : MaterialForm
    {
        BaseWriteRepository<Person> writeRepository;
        public static string UserName = ""; 
        public MainForm()
        {
            InitializeComponent();
            writeRepository = new BaseWriteRepository<Person>();

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
