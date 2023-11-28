﻿using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = OOO_Bank_NVA.DB.ApplicationContext;

namespace OOO_Bank_NVA.Forms
{
    public partial class PersonRegisterForm : MaterialForm
    {
        private Person person;
        private DbContextOptions<ApplicationContext> options;
        public PersonRegisterForm()
        {
            InitializeComponent();
            person = new Person();
            options = DataBaseHelper.Options();
        }
        public Person Person => person;
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
                !string.IsNullOrEmpty(person.Surname) &&
                !string.IsNullOrEmpty(person.Name) &&
                !string.IsNullOrEmpty(person.Phone);
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
            if(person.CardName != string.Empty)
            {
                using (var db = new ApplicationContext(options))
                {
                    var card = db.Cards.FirstOrDefault(x => x.Nomer == person.CardName);
                    if(card == null)
                    {
                        MessageBox.Show("Ваша карта не найдена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        maskNumberCardText.Text = string.Empty;
                        return;
                    }



                }
            }
        }
    }
}