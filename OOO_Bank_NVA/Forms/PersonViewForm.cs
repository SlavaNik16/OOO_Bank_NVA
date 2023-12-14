using MaterialSkin.Controls;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.Forms
{
    public partial class PersonViewForm : MaterialForm
    {
        private Person person;
        public PersonViewForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            textBoxName.Text = person.Name;
            textBoxSurname.Text = person.Surname;
            maskTextBoxPhone.Text = person.Phone;
            maskTextBoxCardName.Text = person.CardName ?? string.Empty;
        }

        private void burDelete_Click(object sender, System.EventArgs e)
        {

        }
    }
}
