using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Colors;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OOO_Bank_NVA
{
    public partial class MainForm : MaterialForm
    {
        //BaseWriteRepository<Person> writeRepository;
        public MainForm()
        {
            InitializeComponent();
            //writeRepository = new BaseWriteRepository<Person>();
            //var person = new Person()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Test",
            //    Surname = "Test",
            //    Phone = "Test"
            //};
            //writeRepository.Add(person);

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
